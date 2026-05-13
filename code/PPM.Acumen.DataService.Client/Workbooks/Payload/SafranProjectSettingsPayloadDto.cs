using Newtonsoft.Json;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    /// <summary>
    /// Value shape for the <see cref="PreferenceKeys.SafranProjectSettings"/> preference.
    /// Per-project Safran import settings; stored at ENTITY scope (<c>ENTITY_TYPE = "Project"</c>).
    /// Mirrors the model class <c>Acumen.Fuse.Business.SafranProjectSettings</c>.
    /// </summary>
    public class SafranProjectSettingsPayloadDto
    {
        [JsonProperty("wbsFieldNumber")]
        public int WbsFieldNumber { get; set; }

        [JsonProperty("wbsFieldName")]
        public string? WbsFieldName { get; set; }
    }
}
