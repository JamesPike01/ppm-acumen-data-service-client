using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    public class RiskRegisterPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("udfDefinitions")]
        public List<RiskRegisterUdfPayloadDto> UdfDefinitions { get; set; } = new List<RiskRegisterUdfPayloadDto>();

        [JsonProperty("weatherEvents")]
        public List<WeatherEventPayloadDto> WeatherEvents { get; set; } = new List<WeatherEventPayloadDto>();

        [JsonProperty("events")]
        public List<RiskEventPayloadDto> Events { get; set; } = new List<RiskEventPayloadDto>();
    }

    public class RiskRegisterUdfPayloadDto
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

    public class RiskEventPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("eventId")]
        public string? EventId { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("eventType")]
        public string? EventType { get; set; }

        [JsonProperty("isEnabled")]
        public bool IsEnabled { get; set; }

        [JsonProperty("isAiGenerated")]
        public bool IsAiGenerated { get; set; }

        [JsonProperty("seed")]
        public int? Seed { get; set; }

        [JsonProperty("currentProbability")]
        public double? CurrentProbability { get; set; }

        [JsonProperty("currentMinProbability")]
        public double? CurrentMinProbability { get; set; }

        [JsonProperty("currentMaxProbability")]
        public double? CurrentMaxProbability { get; set; }

        [JsonProperty("mitigatedMinProbability")]
        public double? MitigatedMinProbability { get; set; }

        [JsonProperty("mitigatedMaxProbability")]
        public double? MitigatedMaxProbability { get; set; }

        [JsonProperty("currentScore")]
        public double? CurrentScore { get; set; }

        [JsonProperty("distributionType")]
        public string? DistributionType { get; set; }

        [JsonProperty("currentProbabilityImpact")]
        public string? CurrentProbabilityImpact { get; set; }

        [JsonProperty("useAbsoluteMapping")]
        public bool UseAbsoluteMapping { get; set; }

        [JsonProperty("correlationParentId")]
        public string? CorrelationParentId { get; set; }

        [JsonProperty("correlationCoefficient")]
        public double? CorrelationCoefficient { get; set; }

        [JsonProperty("weatherEventUid")]
        public Guid? WeatherEventUid { get; set; }

        [JsonProperty("projectType")]
        public string? ProjectType { get; set; }

        [JsonProperty("location")]
        public string? Location { get; set; }

        [JsonProperty("popFromDate")]
        public DateTime? PopFromDate { get; set; }

        [JsonProperty("popToDate")]
        public DateTime? PopToDate { get; set; }

        [JsonProperty("ermRiskUid")]
        public Guid? ErmRiskUid { get; set; }

        [JsonProperty("ermLastImported")]
        public DateTime? ErmLastImported { get; set; }

        [JsonProperty("mitigationDescription")]
        public string? MitigationDescription { get; set; }

        [JsonProperty("impacts")]
        public List<RiskEventImpactPayloadDto> Impacts { get; set; } = new List<RiskEventImpactPayloadDto>();

        [JsonProperty("userFieldValues")]
        public List<RiskEventUserFieldValuePayloadDto> UserFieldValues { get; set; } = new List<RiskEventUserFieldValuePayloadDto>();

        [JsonProperty("mitigationSteps")]
        public List<MitigationStepPayloadDto> MitigationSteps { get; set; } = new List<MitigationStepPayloadDto>();
    }

    public class RiskEventImpactPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("riskImpactUid")]
        public Guid RiskImpactUid { get; set; }

        [JsonProperty("impactName")]
        public string? ImpactName { get; set; }

        [JsonProperty("isRelative")]
        public bool IsRelative { get; set; }
    }

    public class RiskEventUserFieldValuePayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("udfIndex")]
        public int UdfIndex { get; set; }

        [JsonProperty("value")]
        public string? Value { get; set; }
    }

    public class MitigationStepPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("isEnabled")]
        public bool IsEnabled { get; set; }

        [JsonProperty("stepOrder")]
        public int StepOrder { get; set; }

        [JsonProperty("probabilityLabel")]
        public string? ProbabilityLabel { get; set; }

        [JsonProperty("minProbability")]
        public double? MinProbability { get; set; }

        [JsonProperty("maxProbability")]
        public double? MaxProbability { get; set; }

        [JsonProperty("duration")]
        public double? Duration { get; set; }

        [JsonProperty("cost")]
        public double? Cost { get; set; }

        [JsonProperty("score")]
        public double? Score { get; set; }

        [JsonProperty("notes")]
        public string? Notes { get; set; }

        [JsonProperty("isAiGenerated")]
        public bool IsAiGenerated { get; set; }

        [JsonProperty("impacts")]
        public List<MitigationStepImpactPayloadDto> Impacts { get; set; } = new List<MitigationStepImpactPayloadDto>();
    }

    public class MitigationStepImpactPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("riskImpactUid")]
        public Guid RiskImpactUid { get; set; }

        [JsonProperty("impactName")]
        public string? ImpactName { get; set; }
    }
}
