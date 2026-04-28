using Newtonsoft.Json;
using System;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    public class ActivityRiskLinkPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("riskEventUid")]
        public Guid RiskEventUid { get; set; }

        [JsonProperty("currMinRemCost")]
        public double? CurrMinRemCost { get; set; }

        [JsonProperty("currModeRemCost")]
        public double? CurrModeRemCost { get; set; }

        [JsonProperty("currMaxRemCost")]
        public double? CurrMaxRemCost { get; set; }

        [JsonProperty("currMinRemDuration")]
        public double? CurrMinRemDuration { get; set; }

        [JsonProperty("currModeRemDuration")]
        public double? CurrModeRemDuration { get; set; }

        [JsonProperty("currMaxRemDuration")]
        public double? CurrMaxRemDuration { get; set; }

        [JsonProperty("mitMinRemCost")]
        public double? MitMinRemCost { get; set; }

        [JsonProperty("mitModeRemCost")]
        public double? MitModeRemCost { get; set; }

        [JsonProperty("mitMaxRemCost")]
        public double? MitMaxRemCost { get; set; }

        [JsonProperty("mitMinRemDuration")]
        public double? MitMinRemDuration { get; set; }

        [JsonProperty("mitModeRemDuration")]
        public double? MitModeRemDuration { get; set; }

        [JsonProperty("mitMaxRemDuration")]
        public double? MitMaxRemDuration { get; set; }
    }
}
