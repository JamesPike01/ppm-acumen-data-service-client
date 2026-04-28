using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    public class CodeFilePayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("codeType")]
        public string? CodeType { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("fieldName")]
        public string? FieldName { get; set; }

        [JsonProperty("fieldDescription")]
        public string? FieldDescription { get; set; }

        [JsonProperty("ownerUserUid")]
        public Guid? OwnerUserUid { get; set; }

        [JsonProperty("maxLevel")]
        public int? MaxLevel { get; set; }

        [JsonProperty("codeLength")]
        public int? CodeLength { get; set; }

        [JsonProperty("codes")]
        public List<CodePayloadDto> Codes { get; set; } = new List<CodePayloadDto>();
    }

    public class CodePayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("parentCodeUid")]
        public Guid? ParentCodeUid { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("codeLevel")]
        public int CodeLevel { get; set; }

        [JsonProperty("childCount")]
        public int ChildCount { get; set; }

        [JsonProperty("childPos")]
        public int ChildPos { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("tag")]
        public string? Tag { get; set; }

        [JsonProperty("children")]
        public List<CodePayloadDto> Children { get; set; } = new List<CodePayloadDto>();
    }
}
