using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PPM.Acumen.DataService.Client.Workbooks.DTOs;
using PPM.Acumen.DataService.Client.Workbooks.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PPM.Acumen.DataService.Client.Workbooks.Services
{
    public class WorkbooksHttpClient : BaseHttpClient, IWorkbooksService
    {
        public WorkbooksHttpClient(HttpClient httpClient, ILogger? logger = null)
            : base(httpClient, logger)
        {
            BaseEndpoint = "workbooks";
        }

        public async Task<IEnumerable<WorkbookSummaryResponse>> GetAllAsync(int page = 0, int size = 50)
        {
            try
            {
                _logger?.LogDebug("Listing workbooks (page={Page}, size={Size})", page, size);

                var response = await _httpClient.GetAsync($"{BaseEndpoint}?page={page}&size={size}");
                await CheckResponseForSuccessAsync(response);

                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<WorkbookSummaryResponse>>(json)
                    ?? Array.Empty<WorkbookSummaryResponse>();
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Error listing workbooks");
                throw;
            }
        }

        public async Task<WorkbookResponse?> GetAsync(Guid uid)
        {
            try
            {
                _logger?.LogDebug("Getting workbook {Uid}", uid);

                var response = await _httpClient.GetAsync($"{BaseEndpoint}/{uid}");
                if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    _logger?.LogDebug("Workbook {Uid} not found", uid);
                    return null;
                }

                await CheckResponseForSuccessAsync(response);
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<WorkbookResponse>(json);
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Error getting workbook {Uid}", uid);
                throw;
            }
        }

        public async Task DeleteAsync(Guid uid)
        {
            try
            {
                _logger?.LogDebug("Deleting workbook {Uid}", uid);

                var response = await _httpClient.DeleteAsync($"{BaseEndpoint}/{uid}");
                if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    _logger?.LogWarning("Workbook {Uid} not found for deletion", uid);
                    return;
                }

                await CheckResponseForSuccessAsync(response);
                _logger?.LogDebug("Workbook {Uid} deleted", uid);
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Error deleting workbook {Uid}", uid);
                throw;
            }
        }

        public async Task<JobAcceptedResponse> ImportAsync(WorkbookImportRequest request)
        {
            try
            {
                _logger?.LogDebug("Triggering import for fileUid {FileUid} (includeForecast={IncludeForecast})",
                    request.FileUid, request.IncludeForecast);

                var body = Serialize(request);
                var response = await _httpClient.PostAsync($"{BaseEndpoint}/import", body);
                await CheckResponseForSuccessAsync(response);

                var json = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<JobAcceptedResponse>(json)
                    ?? throw new InvalidOperationException("Server returned an empty response for import trigger");

                _logger?.LogDebug("Import job queued. JobUid: {JobUid}", result.JobUid);
                return result;
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Error triggering workbook import for fileUid {FileUid}", request.FileUid);
                throw;
            }
        }

        public async Task<JobAcceptedResponse?> OverwriteAsync(Guid uid, WorkbookImportRequest request)
        {
            try
            {
                _logger?.LogDebug("Triggering overwrite import for workbook {Uid}, fileUid {FileUid}", uid, request.FileUid);

                var body = Serialize(request);
                var response = await _httpClient.PutAsync($"{BaseEndpoint}/{uid}/import", body);

                if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    _logger?.LogDebug("Workbook {Uid} not found for overwrite — use ImportAsync to create", uid);
                    return null;
                }

                await CheckResponseForSuccessAsync(response);
                var json = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<JobAcceptedResponse>(json)
                    ?? throw new InvalidOperationException("Server returned an empty response for overwrite trigger");

                _logger?.LogDebug("Overwrite import job queued. JobUid: {JobUid}", result.JobUid);
                return result;
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Error triggering overwrite import for workbook {Uid}", uid);
                throw;
            }
        }

        public async Task<ImportJobResponse?> GetImportJobStatusAsync(Guid jobUid)
        {
            try
            {
                var response = await _httpClient.GetAsync($"{BaseEndpoint}/import-jobs/{jobUid}");
                if (response.StatusCode == HttpStatusCode.NotFound) return null;

                await CheckResponseForSuccessAsync(response);
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ImportJobResponse>(json);
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Error polling import job {JobUid}", jobUid);
                throw;
            }
        }

        public async Task<JobAcceptedResponse> ExportAsync(Guid uid, WorkbookExportRequest? request = null)
        {
            try
            {
                _logger?.LogDebug("Triggering export for workbook {Uid} (includeForecast={IncludeForecast})",
                    uid, request?.IncludeForecast ?? false);

                var body = request != null ? Serialize(request) : new StringContent("{}", Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync($"{BaseEndpoint}/{uid}/export", body);
                await CheckResponseForSuccessAsync(response);

                var json = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<JobAcceptedResponse>(json)
                    ?? throw new InvalidOperationException("Server returned an empty response for export trigger");

                _logger?.LogDebug("Export job queued. JobUid: {JobUid}", result.JobUid);
                return result;
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Error triggering export for workbook {Uid}", uid);
                throw;
            }
        }

        public async Task<ExportJobResponse?> GetExportJobStatusAsync(Guid jobUid)
        {
            try
            {
                var response = await _httpClient.GetAsync($"{BaseEndpoint}/export-jobs/{jobUid}");
                if (response.StatusCode == HttpStatusCode.NotFound) return null;

                await CheckResponseForSuccessAsync(response);
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ExportJobResponse>(json);
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Error polling export job {JobUid}", jobUid);
                throw;
            }
        }

        private static StringContent Serialize(object obj)
        {
            var json = JsonConvert.SerializeObject(obj);
            return new StringContent(json, Encoding.UTF8, "application/json");
        }
    }
}
