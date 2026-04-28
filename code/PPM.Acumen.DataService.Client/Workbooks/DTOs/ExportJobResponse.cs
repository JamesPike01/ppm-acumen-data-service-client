using Newtonsoft.Json;
using PPM.Acumen.DataService.Client.Common;
using System;

namespace PPM.Acumen.DataService.Client.Workbooks.DTOs
{
    public class ExportJobResponse
    {
        [JsonProperty("jobUid")]
        public Guid JobUid { get; set; }

        /// <summary>Current job status. Poll until "complete" or "failed". See <see cref="JobStatus"/>.</summary>
        [JsonProperty("status")]
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// Pre-signed S3/MinIO URL to download the gzip-compressed workbook JSON.
        /// Valid for 15 minutes from completion. Follow directly — no auth headers required.
        /// Null until status is "complete".
        /// </summary>
        [JsonProperty("downloadUrl")]
        public string? DownloadUrl { get; set; }

        /// <summary>UTC expiry time of the download URL. Null until status is "complete".</summary>
        [JsonProperty("expiresAt")]
        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>Human-readable failure reason. Populated when status is "failed".</summary>
        [JsonProperty("errorMessage")]
        public string? ErrorMessage { get; set; }

        [JsonProperty("startedAt")]
        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? StartedAt { get; set; }

        [JsonProperty("completedAt")]
        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? CompletedAt { get; set; }

        public bool IsComplete => Status == JobStatus.Complete;
        public bool IsFailed => Status == JobStatus.Failed;
        public bool IsTerminal => IsComplete || IsFailed;
    }
}
