using Newtonsoft.Json;
using System;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    public class UserCodeValuePayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("fieldName")]
        public string? FieldName { get; set; }

        [JsonProperty("codeUid")]
        public Guid CodeUid { get; set; }
    }
}
