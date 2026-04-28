using Newtonsoft.Json;
using System;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    public class ActivityUncertaintyPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("uncertaintyType")]
        public string? UncertaintyType { get; set; }

        [JsonProperty("useUncertainty")]
        public bool UseUncertainty { get; set; }

        [JsonProperty("distributionType")]
        public string? DistributionType { get; set; }

        [JsonProperty("minValue")]
        public double? MinValue { get; set; }

        [JsonProperty("modeValue")]
        public double? ModeValue { get; set; }

        [JsonProperty("maxValue")]
        public double? MaxValue { get; set; }

        [JsonProperty("meanValue")]
        public double? MeanValue { get; set; }

        [JsonProperty("stdDeviation")]
        public double? StdDeviation { get; set; }

        [JsonProperty("upperPct")]
        public double? UpperPct { get; set; }

        [JsonProperty("lowerPct")]
        public double? LowerPct { get; set; }

        [JsonProperty("templateName")]
        public string? TemplateName { get; set; }

        [JsonProperty("correlationCoefficient")]
        public double? CorrelationCoefficient { get; set; }

        [JsonProperty("correlationParentUid")]
        public Guid? CorrelationParentUid { get; set; }
    }
}
