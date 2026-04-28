using Newtonsoft.Json;
using System;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    public class UserNoteValuePayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("fieldName")]
        public string? FieldName { get; set; }

        [JsonProperty("value")]
        public string? Value { get; set; }
    }
}
