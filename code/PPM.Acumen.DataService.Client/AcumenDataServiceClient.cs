using Microsoft.Extensions.Logging;
using PPM.Acumen.DataService.Client.Files.Interfaces;
using PPM.Acumen.DataService.Client.Files.Services;
using PPM.Acumen.DataService.Client.Workbooks.Interfaces;
using PPM.Acumen.DataService.Client.Workbooks.Services;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace PPM.Acumen.DataService.Client
{
    /// <summary>
    /// Top-level HTTP client for the ppm-acumen-data-service REST API.
    ///
    /// Typical import flow:
    ///   1. Serialize a workbook to gzip-compressed JSON (WorkbookSerializer in Fuse).
    ///   2. Call FilesService.UploadAsync(stream) → fileUid.
    ///   3. Call WorkbooksService.ImportAsync(new WorkbookImportRequest { FileUid = fileUid }) → jobUid.
    ///   4. Poll WorkbooksService.GetImportJobStatusAsync(jobUid) until IsTerminal.
    ///
    /// Typical export (Open) flow:
    ///   1. Call WorkbooksService.ExportAsync(workbookUid) → jobUid.
    ///   2. Poll WorkbooksService.GetExportJobStatusAsync(jobUid) until IsTerminal.
    ///   3. Follow ExportJobResponse.DownloadUrl to download the gzip file (no auth headers needed).
    ///   4. Gunzip and deserialise with WorkbookSerializer in Fuse.
    /// </summary>
    public class AcumenDataServiceClient
    {
        #region Properties

        public IFilesService FilesService { get; }
        public IWorkbooksService WorkbooksService { get; }

        #endregion

        public AcumenDataServiceClient(AcumenDataServiceClientConfiguration configuration)
        {
            if (configuration == null) throw new ArgumentNullException(nameof(configuration));
            if (string.IsNullOrWhiteSpace(configuration.AcumenDataServiceEndpoint))
                throw new ArgumentException("AcumenDataServiceEndpoint must be set", nameof(configuration));

            var baseAddress = configuration.AcumenDataServiceEndpoint.TrimEnd('/') + "/";

            FilesService = new FilesHttpClient(
                CreateHttpClient(baseAddress, configuration.BearerToken),
                configuration.LoggerFactory?.CreateLogger<FilesHttpClient>());

            WorkbooksService = new WorkbooksHttpClient(
                CreateHttpClient(baseAddress, configuration.BearerToken),
                configuration.LoggerFactory?.CreateLogger<WorkbooksHttpClient>());
        }

        private static HttpClient CreateHttpClient(string baseAddress, string bearerToken)
        {
            var client = new HttpClient { BaseAddress = new Uri(baseAddress) };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            if (!string.IsNullOrWhiteSpace(bearerToken))
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);
            return client;
        }
    }
}
