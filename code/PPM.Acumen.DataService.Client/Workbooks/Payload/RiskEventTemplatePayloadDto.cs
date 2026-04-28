using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    public class RiskEventTemplatePayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("impacts")]
        public List<RiskImpactPayloadDto> Impacts { get; set; } = new List<RiskImpactPayloadDto>();

        [JsonProperty("probabilityImpacts")]
        public List<RiskProbabilityImpactPayloadDto> ProbabilityImpacts { get; set; } = new List<RiskProbabilityImpactPayloadDto>();

        [JsonProperty("thresholds")]
        public List<RiskThresholdPayloadDto> Thresholds { get; set; } = new List<RiskThresholdPayloadDto>();

        [JsonProperty("udfDefinitions")]
        public List<RiskEventTemplateUdfPayloadDto> UdfDefinitions { get; set; } = new List<RiskEventTemplateUdfPayloadDto>();
    }

    public class RiskImpactPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("impactType")]
        public string? ImpactType { get; set; }

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }

        [JsonProperty("values")]
        public List<RiskImpactValuePayloadDto> Values { get; set; } = new List<RiskImpactValuePayloadDto>();
    }

    public class RiskImpactValuePayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("valueIndex")]
        public int ValueIndex { get; set; }

        [JsonProperty("impactName")]
        public string? ImpactName { get; set; }

        [JsonProperty("value")]
        public double? Value { get; set; }

        [JsonProperty("isRelative")]
        public bool IsRelative { get; set; }
    }

    public class RiskProbabilityImpactPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("minValue")]
        public double? MinValue { get; set; }

        [JsonProperty("maxValue")]
        public double? MaxValue { get; set; }

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }

        [JsonProperty("values")]
        public List<RiskProbabilityImpactValuePayloadDto> Values { get; set; } = new List<RiskProbabilityImpactValuePayloadDto>();
    }

    public class RiskProbabilityImpactValuePayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("riskImpactUid")]
        public Guid RiskImpactUid { get; set; }

        [JsonProperty("impactName")]
        public string? ImpactName { get; set; }

        [JsonProperty("value")]
        public double? Value { get; set; }
    }

    public class RiskThresholdPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("upperBound")]
        public double? UpperBound { get; set; }

        [JsonProperty("hexColor")]
        public string? HexColor { get; set; }

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }
    }

    public class RiskEventTemplateUdfPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("udfIndex")]
        public int UdfIndex { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("isEnabled")]
        public bool IsEnabled { get; set; }
    }
}
