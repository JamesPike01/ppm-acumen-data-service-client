using Newtonsoft.Json;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    /// <summary>
    /// Value shape for the <see cref="PreferenceKeys.Ipmr2Export"/> preference.
    /// Per-project IPMR2 export settings; stored at ENTITY scope (<c>ENTITY_TYPE = "Project"</c>).
    /// Mirrors <c>Acumen.Fuse.Business.IPMR2.IPMR2ExportSettings</c>.
    /// <para>
    /// The four <c>*Structure</c> properties on the model are <c>MappedField</c> references —
    /// stored here as the destination Acumen field key (e.g. "WBS Code"). Full mapping data
    /// already lives in <c>FIELD_MAPPING</c> rows for the project, so we only retain the
    /// stable identifier.
    /// </para>
    /// </summary>
    public class Ipmr2ExportSettingsPayloadDto
    {
        [JsonProperty("scheduleFilePath")]
        public string? ScheduleFilePath { get; set; }

        [JsonProperty("contractPerformanceFilePath")]
        public string? ContractPerformanceFilePath { get; set; }

        [JsonProperty("wbsStructureFieldKey")]
        public string? WbsStructureFieldKey { get; set; }

        [JsonProperty("obsStructureFieldKey")]
        public string? ObsStructureFieldKey { get; set; }

        [JsonProperty("workPackageStructureFieldKey")]
        public string? WorkPackageStructureFieldKey { get; set; }

        [JsonProperty("controlAccountStructureFieldKey")]
        public string? ControlAccountStructureFieldKey { get; set; }
    }
}
