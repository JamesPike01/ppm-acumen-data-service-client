using Newtonsoft.Json;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    /// <summary>
    /// Value shape for the <see cref="PreferenceKeys.TornadoSettings"/> preference.
    /// Per-project tornado chart settings; stored at ENTITY scope (<c>ENTITY_TYPE = "Project"</c>).
    /// Mirrors the persisted properties of <c>Acumen.Fuse.Business.Risk.Outputs.TornadoSettings</c>;
    /// the obsolete <c>ShowNonWorkdaysInTornadoMode</c> property is intentionally not carried.
    /// </summary>
    public class TornadoSettingsPayloadDto
    {
        [JsonProperty("topN")]
        public int TopN { get; set; }

        [JsonProperty("autoRange")]
        public bool AutoRange { get; set; }

        [JsonProperty("useRelativeValues")]
        public bool UseRelativeValues { get; set; }

        [JsonProperty("showLegend")]
        public bool ShowLegend { get; set; }

        [JsonProperty("showHeading")]
        public bool ShowHeading { get; set; }

        [JsonProperty("showDescriptionOnLegend")]
        public bool ShowDescriptionOnLegend { get; set; }

        [JsonProperty("showLogicAndUncertaintyInTornadoMode")]
        public bool ShowLogicAndUncertaintyInTornadoMode { get; set; }

        [JsonProperty("scrollView")]
        public bool ScrollView { get; set; }

        [JsonProperty("itemsPerPage")]
        public int ItemsPerPage { get; set; }

        [JsonProperty("displayLegendLabels")]
        public bool DisplayLegendLabels { get; set; }

        [JsonProperty("useAverageOfOverlayFactors")]
        public bool UseAverageOfOverlayFactors { get; set; }

        /// <summary><c>TornadoType</c> enum, serialised as the name (Schedule / Cost / …).</summary>
        [JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary><c>TornadoSettings.BarsMode</c> enum, serialised as the name.</summary>
        [JsonProperty("mode")]
        public string? Mode { get; set; }

        /// <summary><c>TornadoSettings.LabelType</c> enum, serialised as the name.</summary>
        [JsonProperty("labelMode")]
        public string? LabelMode { get; set; }

        [JsonProperty("activityBarLabelType")]
        public string? ActivityBarLabelType { get; set; }

        [JsonProperty("criticalBarLabelType")]
        public string? CriticalBarLabelType { get; set; }

        [JsonProperty("eventBarLabelType")]
        public string? EventBarLabelType { get; set; }

        /// <summary><c>TornadoSettings.TornadoXAxisMode</c> enum, serialised as the name.</summary>
        [JsonProperty("xAxisMode")]
        public string? XAxisMode { get; set; }

        /// <summary><c>TornadoSortMode</c> enum, serialised as the name.</summary>
        [JsonProperty("sortMode")]
        public string? SortMode { get; set; }

        /// <summary><c>PPM.Risk.RiskDriverRollupType</c> enum, serialised as the name.</summary>
        [JsonProperty("rollupMode")]
        public string? RollupMode { get; set; }

        /// <summary>
        /// Free-form risk-exposure point — typically "Mean" or "P<i>n</i>" (e.g. "P50").
        /// Stored as a string; the model property is <c>object</c> for legacy reasons.
        /// </summary>
        [JsonProperty("calculateRiskExposureAt")]
        public string? CalculateRiskExposureAt { get; set; }
    }
}
