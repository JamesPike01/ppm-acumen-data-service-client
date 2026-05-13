using Newtonsoft.Json;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    /// <summary>
    /// Value shape for the <see cref="PreferenceKeys.ExcelProjectSettings"/> preference.
    /// Serialised to JSON and stored in <c>PREFERENCE_VALUE.VALUE</c> at ENTITY scope
    /// (<c>ENTITY_TYPE = "Project"</c>, <c>ENTITY_UID = project.RowUid</c>).
    /// Mirrors the model class <c>Acumen.Fuse.Business.ExcelProjectSettings</c>.
    /// </summary>
    public class ExcelProjectSettingsPayloadDto
    {
        [JsonProperty("idColumn")]
        public string? IdColumn { get; set; }

        [JsonProperty("wbsColumn")]
        public string? WbsColumn { get; set; }

        [JsonProperty("wbsDelimiter")]
        public string? WbsDelimiter { get; set; }

        [JsonProperty("buildWbs")]
        public bool BuildWbs { get; set; }

        [JsonProperty("relationshipsWorksheet")]
        public string? RelationshipsWorksheet { get; set; }
    }
}
