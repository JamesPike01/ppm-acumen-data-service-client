using Newtonsoft.Json;
using System;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    public class ContractPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("number")]
        public string? Number { get; set; }

        [JsonProperty("programName")]
        public string? ProgramName { get; set; }

        [JsonProperty("programPhase")]
        public string? ProgramPhase { get; set; }

        [JsonProperty("proprietaryStatement")]
        public string? ProprietaryStatement { get; set; }

        [JsonProperty("securityClassification")]
        public string? SecurityClassification { get; set; }

        [JsonProperty("contractType")]
        public string? ContractType { get; set; }

        [JsonProperty("contractTaskOrEffortName")]
        public string? ContractTaskOrEffortName { get; set; }

        [JsonProperty("evmsAccepted")]
        public bool? EvmsAccepted { get; set; }

        [JsonProperty("evmsAcceptanceDate")]
        public DateTime? EvmsAcceptanceDate { get; set; }

        [JsonProperty("reportingPeriodEndDate")]
        public DateTime? ReportingPeriodEndDate { get; set; }
    }
}
