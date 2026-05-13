using Newtonsoft.Json;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    /// <summary>
    /// Value shape for the <see cref="PreferenceKeys.TopCriticalPathsSettings"/> preference.
    /// Per-project top-critical-paths chart settings; stored at ENTITY scope
    /// (<c>ENTITY_TYPE = "Project"</c>).
    /// Mirrors <c>Acumen.Fuse.Business.Risk.Outputs.TopCriticalPathsSettings</c>.
    /// </summary>
    public class TopCriticalPathsSettingsPayloadDto
    {
        /// <summary>Number of top critical paths to show (must be &gt; 0).</summary>
        [JsonProperty("topN")]
        public int TopN { get; set; }
    }
}
