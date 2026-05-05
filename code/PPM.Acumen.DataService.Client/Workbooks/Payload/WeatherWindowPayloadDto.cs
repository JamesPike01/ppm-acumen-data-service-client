using Newtonsoft.Json;
using System;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    public class WeatherWindowPayloadDto
    {
        [JsonProperty("riskEventUid")]
        public Guid RiskEventUid { get; set; }

        [JsonProperty("minStart")]
        public DateTime MinStart { get; set; }

        [JsonProperty("likelyStart")]
        public DateTime LikelyStart { get; set; }

        [JsonProperty("maxStart")]
        public DateTime MaxStart { get; set; }

        [JsonProperty("minFinish")]
        public DateTime MinFinish { get; set; }

        [JsonProperty("likelyFinish")]
        public DateTime LikelyFinish { get; set; }

        [JsonProperty("maxFinish")]
        public DateTime MaxFinish { get; set; }

        [JsonProperty("preventSplitting")]
        public bool PreventSplitting { get; set; }
    }
}
