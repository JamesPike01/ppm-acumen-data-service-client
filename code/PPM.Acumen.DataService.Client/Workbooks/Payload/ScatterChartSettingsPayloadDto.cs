using Newtonsoft.Json;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    /// <summary>
    /// Value shape for the <see cref="PreferenceKeys.ScatterChartSettings"/> preference.
    /// Per-project scatter chart settings; stored at ENTITY scope (<c>ENTITY_TYPE = "Project"</c>).
    /// Mirrors the persisted properties of <c>Acumen.Fuse.Business.Risk.Outputs.ScatterChartSettings</c>;
    /// the <c>[NonSerialized]</c> back-references (<c>XAxis</c>, <c>YAxis</c>, <c>YAxisProject</c>)
    /// are runtime fields and are intentionally not carried.
    /// </summary>
    public class ScatterChartSettingsPayloadDto
    {
        /// <summary><c>RiskOutputType</c> enum, serialised as the name (Schedule / Cost / …).</summary>
        [JsonProperty("xAxisMode")]
        public string? XAxisMode { get; set; }

        /// <summary><c>RiskOutputType</c> enum, serialised as the name.</summary>
        [JsonProperty("yAxisMode")]
        public string? YAxisMode { get; set; }

        [JsonProperty("chartVisible")]
        public bool ChartVisible { get; set; }

        [JsonProperty("showDeterministic")]
        public bool ShowDeterministic { get; set; }

        [JsonProperty("showJointConfidenceLevelLine")]
        public bool ShowJointConfidenceLevelLine { get; set; }

        [JsonProperty("showQuadrants")]
        public bool ShowQuadrants { get; set; }

        [JsonProperty("showRegressionLine")]
        public bool ShowRegressionLine { get; set; }

        [JsonProperty("jointConfidenceLevel")]
        public double JointConfidenceLevel { get; set; }
    }
}
