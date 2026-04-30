using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    public class WorkbookImportPayload
    {
        [JsonProperty("schemaVersion")]
        public string SchemaVersion { get; set; } = "1.0";

        [JsonProperty("exportedAt")]
        public DateTime ExportedAt { get; set; }

        [JsonProperty("workbook")]
        public WorkbookPayloadDto Workbook { get; set; } = new WorkbookPayloadDto();

        [JsonProperty("riskEventTemplate")]
        public RiskEventTemplatePayloadDto? RiskEventTemplate { get; set; }

        [JsonProperty("riskRegisters")]
        public List<RiskRegisterPayloadDto> RiskRegisters { get; set; } = new List<RiskRegisterPayloadDto>();

        [JsonProperty("projects")]
        public List<ProjectPayloadDto> Projects { get; set; } = new List<ProjectPayloadDto>();

        [JsonProperty("fieldDefinitions")]
        public List<AcumenFieldDefinitionPayloadDto> FieldDefinitions { get; set; } = new List<AcumenFieldDefinitionPayloadDto>();

        [JsonProperty("contracts")]
        public List<ContractPayloadDto> Contracts { get; set; } = new List<ContractPayloadDto>();

        [JsonProperty("contractors")]
        public List<ContractorPayloadDto> Contractors { get; set; } = new List<ContractorPayloadDto>();

        [JsonProperty("selectionSets")]
        public List<SelectionSetPayloadDto> SelectionSets { get; set; } = new List<SelectionSetPayloadDto>();

        [JsonProperty("metricLibraries")]
        public List<MetricLibraryPayloadDto> MetricLibraries { get; set; } = new List<MetricLibraryPayloadDto>();

        [JsonProperty("calculatedFields")]
        public List<CalculatedFieldPayloadDto> CalculatedFields { get; set; } = new List<CalculatedFieldPayloadDto>();

        [JsonProperty("projectVariables")]
        public List<ProjectVariablePayloadDto> ProjectVariables { get; set; } = new List<ProjectVariablePayloadDto>();

        [JsonProperty("metricVariables")]
        public List<MetricVariablePayloadDto> MetricVariables { get; set; } = new List<MetricVariablePayloadDto>();

        [JsonProperty("riskAdvise")]
        public List<RiskAdvisePayloadDto> RiskAdvise { get; set; } = new List<RiskAdvisePayloadDto>();

        [JsonProperty("activityCorrelations")]
        public List<ActivityCorrelationPayloadDto> ActivityCorrelations { get; set; } = new List<ActivityCorrelationPayloadDto>();

        [JsonProperty("weatherEvents")]
        public List<WeatherEventPayloadDto> WeatherEvents { get; set; } = new List<WeatherEventPayloadDto>();
    }
}
