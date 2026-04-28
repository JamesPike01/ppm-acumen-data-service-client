using Newtonsoft.Json;
using PPM.Acumen.DataService.Client.Common;
using System;

namespace PPM.Acumen.DataService.Client.Workbooks.DTOs
{
    public class WorkbookSummaryResponse
    {
        [JsonProperty("uid")]
        public Guid Uid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>Number of Live-type projects (excludes Snapshot and Scenario rows).</summary>
        [JsonProperty("projectCount")]
        public int ProjectCount { get; set; }

        [JsonProperty("lastModifiedDate")]
        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? LastModifiedDate { get; set; }
    }
}
