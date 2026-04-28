using Newtonsoft.Json;
using System;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    public class ScoreMetricPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>Serialised JSON blob stored as-is in NCLOB.</summary>
        [JsonProperty("configuration")]
        public string? Configuration { get; set; }
    }
}
