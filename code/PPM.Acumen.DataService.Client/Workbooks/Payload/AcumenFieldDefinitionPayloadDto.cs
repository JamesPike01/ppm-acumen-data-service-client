using Newtonsoft.Json;
using System;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    public class AcumenFieldDefinitionPayloadDto
    {
        // USER_FIELD_DEFINITION base row
        [JsonProperty("userFieldDefUid")]
        public Guid UserFieldDefUid { get; set; }

        [JsonProperty("fieldName")]
        public string? FieldName { get; set; }

        [JsonProperty("fieldLabel")]
        public string? FieldLabel { get; set; }

        [JsonProperty("fieldDataType")]
        public string? FieldDataType { get; set; }

        [JsonProperty("codeFileUid")]
        public Guid? CodeFileUid { get; set; }

        // ACUMEN_FIELD_DEFINITION extension row
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("isMandatory")]
        public bool IsMandatory { get; set; }

        [JsonProperty("isReadOnly")]
        public bool IsReadOnly { get; set; }

        [JsonProperty("evaluateInForensicReport")]
        public bool EvaluateInForensicReport { get; set; }

        [JsonProperty("showInForensicReport")]
        public bool ShowInForensicReport { get; set; }
    }
}
