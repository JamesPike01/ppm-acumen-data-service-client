using Newtonsoft.Json;
using System;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    public class ActivityLinkPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("fromActivityUid")]
        public Guid FromActivityUid { get; set; }

        [JsonProperty("toActivityUid")]
        public Guid ToActivityUid { get; set; }

        [JsonProperty("linkType")]
        public string? LinkType { get; set; }

        [JsonProperty("lag")]
        public int Lag { get; set; }

        [JsonProperty("isLagElapsed")]
        public bool IsLagElapsed { get; set; }

        [JsonProperty("isDriving")]
        public bool? IsDriving { get; set; }

        [JsonProperty("isCycleLink")]
        public bool IsCycleLink { get; set; }

        [JsonProperty("isFuseCreated")]
        public bool IsFuseCreated { get; set; }

        [JsonProperty("freeFloat")]
        public double? FreeFloat { get; set; }
    }
}
