using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    public class MetricLibraryPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("libraryType")]
        public string? LibraryType { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("groups")]
        public List<MetricGroupPayloadDto> Groups { get; set; } = new List<MetricGroupPayloadDto>();
    }

    public class MetricGroupPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }

        [JsonProperty("metrics")]
        public List<MetricPayloadDto> Metrics { get; set; } = new List<MetricPayloadDto>();
    }

    public class MetricPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("weight")]
        public double? Weight { get; set; }

        [JsonProperty("includeInNewWorkbook")]
        public bool IncludeInNewWorkbook { get; set; }

        [JsonProperty("filterExpression")]
        public string? FilterExpression { get; set; }

        [JsonProperty("columnDefinitions")]
        public string? ColumnDefinitions { get; set; }

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }
    }
}
