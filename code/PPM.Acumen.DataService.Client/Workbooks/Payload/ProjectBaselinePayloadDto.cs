using Newtonsoft.Json;
using System;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    public class ProjectBaselinePayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("filePath")]
        public string? FilePath { get; set; }

        [JsonProperty("mergeField")]
        public string? MergeField { get; set; }

        [JsonProperty("p6WebObjectId")]
        public int? P6WebObjectId { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }
    }
}
