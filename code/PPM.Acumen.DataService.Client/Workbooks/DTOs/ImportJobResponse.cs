using Newtonsoft.Json;
using PPM.Acumen.DataService.Client.Common;
using System;

namespace PPM.Acumen.DataService.Client.Workbooks.DTOs
{
    public class ImportJobResponse
    {
        [JsonProperty("jobUid")]
        public Guid JobUid { get; set; }

        /// <summary>Current job status. Poll until "complete" or "failed". See <see cref="JobStatus"/>.</summary>
        [JsonProperty("status")]
        public string Status { get; set; } = string.Empty;

        /// <summary>UID of the imported workbook. Populated when status is "complete".</summary>
        [JsonProperty("workbookUid")]
        public Guid? WorkbookUid { get; set; }

        /// <summary>Human-readable failure reason. Populated when status is "failed".</summary>
        [JsonProperty("errorMessage")]
        public string? ErrorMessage { get; set; }

        /// <summary>UTC timestamp when processing began. Null while status is "pending".</summary>
        [JsonProperty("startedAt")]
        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? StartedAt { get; set; }

        /// <summary>UTC timestamp when processing finished (whether complete or failed).</summary>
        [JsonProperty("completedAt")]
        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? CompletedAt { get; set; }

        public bool IsComplete => Status == JobStatus.Complete;
        public bool IsFailed => Status == JobStatus.Failed;
        public bool IsTerminal => IsComplete || IsFailed;
    }
}
