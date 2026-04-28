using Newtonsoft.Json;
using System;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    public class FieldMappingPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("acumenFieldUid")]
        public Guid AcumenFieldUid { get; set; }

        [JsonProperty("sourceFieldKey")]
        public string? SourceFieldKey { get; set; }

        [JsonProperty("sourceFieldName")]
        public string? SourceFieldName { get; set; }

        [JsonProperty("sourceDataType")]
        public string? SourceDataType { get; set; }

        [JsonProperty("sourcePlatform")]
        public string? SourcePlatform { get; set; }

        [JsonProperty("isBaseline")]
        public bool IsBaseline { get; set; }
    }
}
