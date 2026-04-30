using Newtonsoft.Json;
using System;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    public class RiskAdvisePayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("entityUid")]
        public Guid EntityUid { get; set; }

        [JsonProperty("entityType")]
        public string? EntityType { get; set; }

        [JsonProperty("adviseType")]
        public string? AdviseType { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("toolTip")]
        public string? ToolTip { get; set; }
    }
}
