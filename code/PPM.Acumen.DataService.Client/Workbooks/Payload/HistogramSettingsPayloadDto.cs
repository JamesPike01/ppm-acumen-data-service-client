using System.Collections.Generic;
using Newtonsoft.Json;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    /// <summary>
    /// Value shape for the <see cref="PreferenceKeys.HistogramSettings"/> preference.
    /// Per-project histogram chart settings; stored at ENTITY scope (<c>ENTITY_TYPE = "Project"</c>).
    /// Mirrors the persisted properties of <c>Acumen.Fuse.Business.Risk.Outputs.HistogramSettings</c>;
    /// computed properties (WorkingMinutesPerDay, WorkingMinutesPerWeek) and the parent
    /// <c>RiskAnalysisSettings</c> back-reference are intentionally not carried.
    /// </summary>
    public class HistogramSettingsPayloadDto
    {
        /// <summary><c>NumberOfBars</c> enum, serialised as the name (Five, Ten, Twenty, …).</summary>
        [JsonProperty("desiredNumberOfBars")]
        public string? DesiredNumberOfBars { get; set; }

        [JsonProperty("secondaryYAxisIncrement")]
        public int SecondaryYAxisIncrement { get; set; }

        [JsonProperty("xAxisDateTimeFormat")]
        public int XAxisDateTimeFormat { get; set; }

        [JsonProperty("xAxisDateTimeFormatString")]
        public string? XAxisDateTimeFormatString { get; set; }

        [JsonProperty("dateTimeMeasurementUnit")]
        public int DateTimeMeasurementUnit { get; set; }

        [JsonProperty("contingencyLevel")]
        public int? ContingencyLevel { get; set; }

        [JsonProperty("showTable")]
        public bool ShowTable { get; set; }

        /// <summary>P-value highlighters (e.g. 50, 80, 90).</summary>
        [JsonProperty("highlighters")]
        public List<int> Highlighters { get; set; } = new List<int>();
    }
}
