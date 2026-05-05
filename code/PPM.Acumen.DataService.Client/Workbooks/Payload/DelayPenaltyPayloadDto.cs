using Newtonsoft.Json;
using System;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    public class DelayPenaltyPayloadDto
    {
        [JsonProperty("riskEventUid")]
        public Guid RiskEventUid { get; set; }

        [JsonProperty("start")]
        public DateTime Start { get; set; }

        [JsonProperty("isRecurring")]
        public bool IsRecurring { get; set; }

        [JsonProperty("recurrenceInterval")]
        public int RecurrenceInterval { get; set; }

        [JsonProperty("recurrenceUnit")]
        public string? RecurrenceUnit { get; set; }

        [JsonProperty("cost")]
        public double Cost { get; set; }

        [JsonProperty("hasMaxCost")]
        public bool HasMaxCost { get; set; }

        [JsonProperty("maxCost")]
        public double MaxCost { get; set; }
    }
}
