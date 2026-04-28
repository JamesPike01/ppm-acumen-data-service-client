using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PPM.Acumen.DataService.Client.Files.DTOs;
using PPM.Acumen.DataService.Client.Files.Interfaces;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace PPM.Acumen.DataService.Client.Files.Services
{
    public class FilesHttpClient : BaseHttpClient, IFilesService
    {
        public FilesHttpClient(HttpClient httpClient, ILogger? logger = null)
            : base(httpClient, logger)
        {
            BaseEndpoint = "files";
        }

        public async Task<FileUploadResponse> UploadAsync(Stream content, string fileName = "workbook.json.gz")
        {
            try
            {
                _logger?.LogDebug("Uploading workbook file '{FileName}' to staging", fileName);

                using var formData = new MultipartFormDataContent();
                var streamContent = new StreamContent(content);
                streamContent.Headers.ContentType = new MediaTypeHeaderValue("application/gzip");
                formData.Add(streamContent, "file", fileName);

                var response = await _httpClient.PostAsync($"{BaseEndpoint}/upload", formData);
                await CheckResponseForSuccessAsync(response);

                var json = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<FileUploadResponse>(json)
                    ?? throw new InvalidOperationException("Server returned an empty response for file upload");

                _logger?.LogDebug("File staged successfully. FileUid: {FileUid}, ExpiresAt: {ExpiresAt}",
                    result.FileUid, result.ExpiresAt);

                return result;
            }
            catch (Exception ex) when (!(ex is HttpRequestException || ex is InvalidOperationException))
            {
                _logger?.LogError(ex, "Unexpected error uploading workbook file '{FileName}'", fileName);
                throw;
            }
        }
    }
}
