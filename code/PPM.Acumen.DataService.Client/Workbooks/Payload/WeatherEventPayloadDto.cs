using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    public class WeatherEventPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("periods")]
        public List<WeatherEventPeriodPayloadDto> Periods { get; set; } = new List<WeatherEventPeriodPayloadDto>();
    }

    public class WeatherEventPeriodPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("periodMonth")]
        public int PeriodMonth { get; set; }

        [JsonProperty("periodYear")]
        public int PeriodYear { get; set; }

        [JsonProperty("probability")]
        public double? Probability { get; set; }

        [JsonProperty("impact")]
        public double? Impact { get; set; }
    }
}
