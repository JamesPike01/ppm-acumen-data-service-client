using Newtonsoft.Json;
using PPM.Acumen.DataService.Client.Common;
using System;

namespace PPM.Acumen.DataService.Client.Workbooks.DTOs
{
    public class WorkbookResponse
    {
        [JsonProperty("uid")]
        public Guid Uid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("subject")]
        public string? Subject { get; set; }

        [JsonProperty("author")]
        public string? Author { get; set; }

        /// <summary>.afw format version, e.g. "8.9.0.0".</summary>
        [JsonProperty("fileVersion")]
        public string FileVersion { get; set; } = string.Empty;

        /// <summary>Acumen Suite application version at time of last save.</summary>
        [JsonProperty("appVersion")]
        public string? AppVersion { get; set; }

        /// <summary>Valid values: Hours, Days, Weeks, Months.</summary>
        [JsonProperty("workMeasureUnit")]
        public string WorkMeasureUnit { get; set; } = string.Empty;

        /// <summary>Valid values: Hours, Days, Weeks, Months.</summary>
        [JsonProperty("durationMeasureUnit")]
        public string DurationMeasureUnit { get; set; } = string.Empty;

        /// <summary>Valid values: Hours, Days, Weeks, Months.</summary>
        [JsonProperty("elapsedDurationUnit")]
        public string ElapsedDurationUnit { get; set; } = string.Empty;

        /// <summary>When true, hours-per-day is derived from the default calendar rather than a fixed value.</summary>
        [JsonProperty("useCalendarForHpd")]
        public bool UseCalendarForHpd { get; set; }

        [JsonProperty("currencySymbol")]
        public string? CurrencySymbol { get; set; }

        [JsonProperty("currencyScale")]
        public string? CurrencyScale { get; set; }

        /// <summary>Default percentile for probability displays, e.g. 80.0.</summary>
        [JsonProperty("percentileValue")]
        public double? PercentileValue { get; set; }

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

        [JsonProperty("lastModifiedDate")]
        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? LastModifiedDate { get; set; }
    }
}
