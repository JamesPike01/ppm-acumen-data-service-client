using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    public class SelectionSetPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("members")]
        public List<SelectionSetMemberPayloadDto> Members { get; set; } = new List<SelectionSetMemberPayloadDto>();
    }

    public class SelectionSetMemberPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("entityUid")]
        public Guid EntityUid { get; set; }

        /// <summary>"Activity" or "HierarchyNode"</summary>
        [JsonProperty("entityType")]
        public string? EntityType { get; set; }
    }
}
