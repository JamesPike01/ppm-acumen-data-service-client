using Newtonsoft.Json;
using System;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    public class AcumenFieldDefinitionPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("fieldKey")]
        public string? FieldKey { get; set; }

        [JsonProperty("fieldLabel")]
        public string? FieldLabel { get; set; }

        [JsonProperty("fieldDataType")]
        public string? FieldDataType { get; set; }

        [JsonProperty("slotName")]
        public string? SlotName { get; set; }

        [JsonProperty("entityType")]
        public string? EntityType { get; set; }

        [JsonProperty("isMandatory")]
        public bool IsMandatory { get; set; }

        [JsonProperty("isReadOnly")]
        public bool IsReadOnly { get; set; }

        [JsonProperty("evaluateInForensicReport")]
        public bool EvaluateInForensicReport { get; set; }

        [JsonProperty("showInForensicReport")]
        public bool ShowInForensicReport { get; set; }

        [JsonProperty("isWork")]
        public bool IsWork { get; set; }

        [JsonProperty("isDuration")]
        public bool IsDuration { get; set; }

        [JsonProperty("isCost")]
        public bool IsCost { get; set; }

        [JsonProperty("isPercent")]
        public bool IsPercent { get; set; }

        [JsonProperty("loadingType")]
        public string? LoadingType { get; set; }
    }
}
