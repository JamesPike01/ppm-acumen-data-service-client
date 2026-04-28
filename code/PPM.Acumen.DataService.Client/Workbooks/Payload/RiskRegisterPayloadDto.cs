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

        [JsonProperty("udf1Name")] public string? Udf1Name { get; set; }
        [JsonProperty("udf2Name")] public string? Udf2Name { get; set; }
        [JsonProperty("udf3Name")] public string? Udf3Name { get; set; }
        [JsonProperty("udf4Name")] public string? Udf4Name { get; set; }
        [JsonProperty("udf5Name")] public string? Udf5Name { get; set; }
        [JsonProperty("udf6Name")] public string? Udf6Name { get; set; }
        [JsonProperty("udf7Name")] public string? Udf7Name { get; set; }
        [JsonProperty("udf8Name")] public string? Udf8Name { get; set; }
        [JsonProperty("udf9Name")] public string? Udf9Name { get; set; }
        [JsonProperty("udf10Name")] public string? Udf10Name { get; set; }

        [JsonProperty("udf1Enabled")] public bool Udf1Enabled { get; set; }
        [JsonProperty("udf2Enabled")] public bool Udf2Enabled { get; set; }
        [JsonProperty("udf3Enabled")] public bool Udf3Enabled { get; set; }
        [JsonProperty("udf4Enabled")] public bool Udf4Enabled { get; set; }
        [JsonProperty("udf5Enabled")] public bool Udf5Enabled { get; set; }
        [JsonProperty("udf6Enabled")] public bool Udf6Enabled { get; set; }
        [JsonProperty("udf7Enabled")] public bool Udf7Enabled { get; set; }
        [JsonProperty("udf8Enabled")] public bool Udf8Enabled { get; set; }
        [JsonProperty("udf9Enabled")] public bool Udf9Enabled { get; set; }
        [JsonProperty("udf10Enabled")] public bool Udf10Enabled { get; set; }

        [JsonProperty("events")]
        public List<RiskEventPayloadDto> Events { get; set; } = new List<RiskEventPayloadDto>();
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

        [JsonProperty("mitigatedScore")]
        public double? MitigatedScore { get; set; }

        [JsonProperty("distributionType")]
        public string? DistributionType { get; set; }

        [JsonProperty("currentProbabilityImpact")]
        public string? CurrentProbabilityImpact { get; set; }

        [JsonProperty("scheduleImpact")]
        public string? ScheduleImpact { get; set; }

        [JsonProperty("costImpact")]
        public string? CostImpact { get; set; }

        [JsonProperty("scheduleImpactIsRelative")]
        public bool ScheduleImpactIsRelative { get; set; }

        [JsonProperty("costImpactIsRelative")]
        public bool CostImpactIsRelative { get; set; }

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

        [JsonProperty("udf1")] public string? Udf1 { get; set; }
        [JsonProperty("udf2")] public string? Udf2 { get; set; }
        [JsonProperty("udf3")] public string? Udf3 { get; set; }
        [JsonProperty("udf4")] public string? Udf4 { get; set; }
        [JsonProperty("udf5")] public string? Udf5 { get; set; }
        [JsonProperty("udf6")] public string? Udf6 { get; set; }
        [JsonProperty("udf7")] public string? Udf7 { get; set; }
        [JsonProperty("udf8")] public string? Udf8 { get; set; }
        [JsonProperty("udf9")] public string? Udf9 { get; set; }
        [JsonProperty("udf10")] public string? Udf10 { get; set; }

        [JsonProperty("mitigationSteps")]
        public List<MitigationStepPayloadDto> MitigationSteps { get; set; } = new List<MitigationStepPayloadDto>();
    }

    public class MitigationStepPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("stepId")]
        public string? StepId { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("isEnabled")]
        public bool IsEnabled { get; set; }

        [JsonProperty("stepOrder")]
        public int StepOrder { get; set; }

        /// <summary>
        /// Probability as a fraction (0.0–1.0). Fuse stores this as a string label ("Low"/"Medium"/"High");
        /// the serialiser converts to a numeric value using the register's probability scale.
        /// </summary>
        [JsonProperty("mitigatedProbability")]
        public double? MitigatedProbability { get; set; }

        [JsonProperty("scheduleImpact")]
        public string? ScheduleImpact { get; set; }

        [JsonProperty("costImpact")]
        public string? CostImpact { get; set; }
    }
}
