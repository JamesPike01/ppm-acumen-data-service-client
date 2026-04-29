using Newtonsoft.Json;
using System;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    public class WorkbookPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("fileVersion")]
        public string? FileVersion { get; set; }

        [JsonProperty("appVersion")]
        public string? AppVersion { get; set; }

        [JsonProperty("workMeasureUnit")]
        public string? WorkMeasureUnit { get; set; }

        [JsonProperty("durationMeasureUnit")]
        public string? DurationMeasureUnit { get; set; }

        [JsonProperty("elapsedDurationUnit")]
        public string? ElapsedDurationUnit { get; set; }

        [JsonProperty("useCalendarForHpd")]
        public bool UseCalendarForHpd { get; set; }

        [JsonProperty("currencySymbol")]
        public string? CurrencySymbol { get; set; }

        [JsonProperty("currencyScale")]
        public string? CurrencyScale { get; set; }

        [JsonProperty("dashboardMode")]
        public string? DashboardMode { get; set; }

        [JsonProperty("autoScheduleScenarios")]
        public bool AutoScheduleScenarios { get; set; }

        [JsonProperty("isUncertaintyLocked")]
        public bool IsUncertaintyLocked { get; set; }

        [JsonProperty("isCalibrationLocked")]
        public bool IsCalibrationLocked { get; set; }

        [JsonProperty("isCorrelated")]
        public bool IsCorrelated { get; set; }

        [JsonProperty("integrateCostSchedule")]
        public bool IntegrateCostSchedule { get; set; }

        [JsonProperty("usePert")]
        public bool UsePert { get; set; }

        [JsonProperty("percentileValue")]
        public double? PercentileValue { get; set; }

        [JsonProperty("runCpmRiskAuto")]
        public bool RunCpmRiskAuto { get; set; }

        [JsonProperty("workbookBudgetCost")]
        public double? WorkbookBudgetCost { get; set; }

        [JsonProperty("riskNotes")]
        public string? RiskNotes { get; set; }

        [JsonProperty("cloudProjectTypeId")]
        public string? CloudProjectTypeId { get; set; }

        [JsonProperty("riskEventTemplateUid")]
        public Guid? RiskEventTemplateUid { get; set; }
    }
}
