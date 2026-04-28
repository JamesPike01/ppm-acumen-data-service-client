using Newtonsoft.Json;
using System;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    public class ResourcePayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("sourceId")]
        public string? SourceId { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("resourceType")]
        public string? ResourceType { get; set; }

        [JsonProperty("defaultUnitsPerHour")]
        public double? DefaultUnitsPerHour { get; set; }

        [JsonProperty("pricePerUnit")]
        public double? PricePerUnit { get; set; }
    }
}
