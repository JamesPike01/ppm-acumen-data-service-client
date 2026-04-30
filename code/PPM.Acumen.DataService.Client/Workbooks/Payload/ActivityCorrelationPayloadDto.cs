using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    public class ActivityCorrelationPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("parentActivityUid")]
        public Guid ParentActivityUid { get; set; }

        [JsonProperty("coefficient")]
        public double Coefficient { get; set; }

        [JsonProperty("children")]
        public List<Guid> Children { get; set; } = new List<Guid>();
    }
}
