using Newtonsoft.Json;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    /// <summary>
    /// Value shape for the <see cref="PreferenceKeys.RiskAnalysisSettings"/> preference.
    /// Per-project Monte Carlo configuration; stored at ENTITY scope (<c>ENTITY_TYPE = "Project"</c>).
    /// Mirrors the scalar properties of <c>Acumen.Fuse.Business.Risk.RiskAnalysisSettings</c>.
    /// The nested Histogram / Tornado / Scatter / TopCriticalPaths objects are stored as
    /// independent preferences (see <see cref="PreferenceKeys"/>), so they're not nested here.
    /// </summary>
    public class RiskAnalysisSettingsPayloadDto
    {
        [JsonProperty("runUntilConverged")]
        public bool RunUntilConverged { get; set; }

        [JsonProperty("useFixedSeed")]
        public bool UseFixedSeed { get; set; }

        [JsonProperty("useCorrelation")]
        public bool UseCorrelation { get; set; }

        [JsonProperty("correlationEnabled")]
        public bool CorrelationEnabled { get; set; }

        [JsonProperty("addScenario")]
        public bool AddScenario { get; set; }

        [JsonProperty("seed")]
        public int Seed { get; set; }

        [JsonProperty("iterations")]
        public int Iterations { get; set; }

        [JsonProperty("convergenceIterations")]
        public int ConvergenceIterations { get; set; }

        [JsonProperty("correlationFrequency")]
        public double CorrelationFrequency { get; set; }

        [JsonProperty("convergencePct")]
        public double ConvergencePct { get; set; }

        /// <summary><c>MonteCarloSimulationMode</c> enum, serialised as the name.</summary>
        [JsonProperty("mode")]
        public string? Mode { get; set; }

        /// <summary><c>MonteCarloPhase</c> enum, serialised as the name.</summary>
        [JsonProperty("phase")]
        public string? Phase { get; set; }

        [JsonProperty("integrateCostSchedule")]
        public bool IntegrateCostSchedule { get; set; }

        [JsonProperty("useDynamicScheduleOverlayResults")]
        public bool UseDynamicScheduleOverlayResults { get; set; }
    }
}
