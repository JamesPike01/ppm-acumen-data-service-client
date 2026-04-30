using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    public class WeatherEventPayloadDto
    {
        [JsonProperty("riskEventUid")]
        public Guid RiskEventUid { get; set; }

        [JsonProperty("preventSplitting")]
        public bool PreventSplitting { get; set; }

        [JsonProperty("periods")]
        public List<WeatherEventPeriodPayloadDto> Periods { get; set; } = new List<WeatherEventPeriodPayloadDto>();
    }

    public class WeatherEventPeriodPayloadDto
    {
        [JsonProperty("periodMonth")]
        public int PeriodMonth { get; set; }

        [JsonProperty("probability")]
        public double? Probability { get; set; }

        [JsonProperty("min")]
        public double Min { get; set; }

        [JsonProperty("likely")]
        public double Likely { get; set; }

        [JsonProperty("max")]
        public double Max { get; set; }

        [JsonProperty("isEnabled")]
        public bool IsEnabled { get; set; }
    }
}
