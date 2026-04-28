using PPM.Acumen.DataService.Client.Workbooks.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PPM.Acumen.DataService.Client.Workbooks.Interfaces
{
    public interface IWorkbooksService
    {
        /// <summary>Returns a paginated summary list of all accessible workbooks.</summary>
        Task<IEnumerable<WorkbookSummaryResponse>> GetAllAsync(int page = 0, int size = 50);

        /// <summary>Returns workbook header metadata (no child data). Returns null if not found.</summary>
        Task<WorkbookResponse?> GetAsync(Guid uid);

        /// <summary>Permanently deletes a workbook and all child data.</summary>
        Task DeleteAsync(Guid uid);

        /// <summary>
        /// Triggers async import of a new workbook from a staged file.
        /// Fails with 409 if a workbook with the payload UID already exists —
        /// use <see cref="OverwriteAsync"/> in that case.
        /// </summary>
        Task<JobAcceptedResponse> ImportAsync(WorkbookImportRequest request);

        /// <summary>
        /// Triggers async import that replaces all child data of an existing workbook.
        /// Returns null if the workbook does not exist (404).
        /// </summary>
        Task<JobAcceptedResponse?> OverwriteAsync(Guid uid, WorkbookImportRequest request);

        /// <summary>
        /// Polls for the status of an async import job.
        /// Returns null if the job is not found (expired or never existed).
        /// Poll until <see cref="ImportJobResponse.IsTerminal"/> is true.
        /// </summary>
        Task<ImportJobResponse?> GetImportJobStatusAsync(Guid jobUid);

        /// <summary>Triggers async export of a workbook to gzip-compressed JSON in object storage.</summary>
        Task<JobAcceptedResponse> ExportAsync(Guid uid, WorkbookExportRequest? request = null);

        /// <summary>
        /// Polls for the status of an async export job.
        /// Returns null if the job is not found.
        /// When complete, follow <see cref="ExportJobResponse.DownloadUrl"/> directly (no auth required).
        /// </summary>
        Task<ExportJobResponse?> GetExportJobStatusAsync(Guid jobUid);
    }
}
