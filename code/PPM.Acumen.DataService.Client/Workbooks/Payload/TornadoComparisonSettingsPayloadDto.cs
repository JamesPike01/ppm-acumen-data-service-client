using Newtonsoft.Json;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    /// <summary>
    /// Value shape for the <see cref="PreferenceKeys.TornadoComparisonSettings"/> preference.
    /// Per-project tornado-comparison chart settings; stored at ENTITY scope
    /// (<c>ENTITY_TYPE = "Project"</c>).
    /// Mirrors the persisted scalar properties of
    /// <c>Acumen.Fuse.Business.Risk.Outputs.TornadoComparisonSettings</c>.
    /// <para>
    /// <b>Deferred:</b> the <c>Layers</c> collection (<c>ObservableCollection&lt;ComparisonLayer&gt;</c>)
    /// and the <c>PrimaryLayerByType</c> dictionary are structural model data, not scalar
    /// settings — they need their own modelling decision (likely a dedicated table or DTO type)
    /// and are not carried in this preference value yet.
    /// The obsolete <c>ShowDescriptionOnLegend</c> property is intentionally not carried.
    /// </para>
    /// </summary>
    public class TornadoComparisonSettingsPayloadDto
    {
        [JsonProperty("useRelativeValues")]
        public bool UseRelativeValues { get; set; }

        /// <summary>Nullable <c>TornadoType</c> enum, serialised as the name; null when unset.</summary>
        [JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary><c>TornadoSettings.BarsMode</c> enum, serialised as the name.</summary>
        [JsonProperty("barsMode")]
        public string? BarsMode { get; set; }

        /// <summary><c>TornadoSettings.TornadoXAxisMode</c> enum, serialised as the name.</summary>
        [JsonProperty("xAxisMode")]
        public string? XAxisMode { get; set; }

        [JsonProperty("showLogicAndUncertaintyInTornadoMode")]
        public bool ShowLogicAndUncertaintyInTornadoMode { get; set; }

        [JsonProperty("showNonWorkdaysInTornadoMode")]
        public bool ShowNonWorkdaysInTornadoMode { get; set; }
    }
}
