using Newtonsoft.Json;
using System;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    public class ActivityForecastPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("scenarioProjectUid")]
        public Guid ScenarioProjectUid { get; set; }

        [JsonProperty("analysisRunDate")]
        public DateTime? AnalysisRunDate { get; set; }

        [JsonProperty("pStart")]
        public DateTime? PStart { get; set; }

        [JsonProperty("pFinish")]
        public DateTime? PFinish { get; set; }

        [JsonProperty("pDuration")]
        public double? PDuration { get; set; }

        [JsonProperty("pFloat")]
        public double? PFloat { get; set; }

        [JsonProperty("pCost")]
        public double? PCost { get; set; }
    }
}
