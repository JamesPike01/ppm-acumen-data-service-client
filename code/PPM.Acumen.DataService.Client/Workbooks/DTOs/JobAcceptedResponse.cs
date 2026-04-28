using Newtonsoft.Json;
using System;

namespace PPM.Acumen.DataService.Client.Workbooks.DTOs
{
    public class JobAcceptedResponse
    {
        /// <summary>UID of the queued async job. Use this to poll for status.</summary>
        [JsonProperty("jobUid")]
        public Guid JobUid { get; set; }

        /// <summary>Always "pending" at acceptance time. See <see cref="Common.JobStatus"/> for valid values.</summary>
        [JsonProperty("status")]
        public string Status { get; set; } = Common.JobStatus.Pending;
    }
}
