using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    public class MetricLibraryPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("libraryType")]
        public string? LibraryType { get; set; }

        [JsonProperty("groups")]
        public List<MetricGroupPayloadDto> Groups { get; set; } = new List<MetricGroupPayloadDto>();
    }

    public class MetricGroupPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("parentGroupUid")]
        public Guid? ParentGroupUid { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }

        [JsonProperty("metrics")]
        public List<MetricPayloadDto> Metrics { get; set; } = new List<MetricPayloadDto>();
    }

    public class MetricPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }

        [JsonProperty("weight")]
        public double? Weight { get; set; }

        [JsonProperty("includeInNewWorkbook")]
        public bool IncludeInNewWorkbook { get; set; }

        [JsonProperty("columnFields")]
        public List<string>? ColumnFields { get; set; }

        [JsonProperty("filters")]
        public List<MetricFilterPayloadDto> Filters { get; set; } = new List<MetricFilterPayloadDto>();

        [JsonProperty("thresholds")]
        public List<MetricThresholdPayloadDto> Thresholds { get; set; } = new List<MetricThresholdPayloadDto>();
    }

    public class MetricThresholdPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("minValue")]
        public double MinValue { get; set; }

        [JsonProperty("color")]
        public string? Color { get; set; }

        [JsonProperty("isFail")]
        public bool IsFail { get; set; }
    }

    public class MetricFilterPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("filterType")]
        public string? FilterType { get; set; }

        [JsonProperty("includeNormal")]
        public bool IncludeNormal { get; set; }

        [JsonProperty("includeMilestone")]
        public bool IncludeMilestone { get; set; }

        [JsonProperty("includeSummary")]
        public bool IncludeSummary { get; set; }

        [JsonProperty("includeHammock")]
        public bool IncludeHammock { get; set; }

        [JsonProperty("includePlanned")]
        public bool IncludePlanned { get; set; }

        [JsonProperty("includeInProgress")]
        public bool IncludeInProgress { get; set; }

        [JsonProperty("includeComplete")]
        public bool IncludeComplete { get; set; }

        [JsonProperty("timePhaseFilter")]
        public string? TimePhaseFilter { get; set; }

        [JsonProperty("phaseAnalysisBasis")]
        public string? PhaseAnalysisBasis { get; set; }

        [JsonProperty("prorateSwitch")]
        public string? ProrateSwitch { get; set; }

        [JsonProperty("definedColumns")]
        public List<string>? DefinedColumns { get; set; }

        [JsonProperty("expressions")]
        public List<MetricFilterExpressionPayloadDto> Expressions { get; set; } = new List<MetricFilterExpressionPayloadDto>();
    }

    public class MetricFilterExpressionPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }

        [JsonProperty("leftField")]
        public string? LeftField { get; set; }

        [JsonProperty("rightField")]
        public string? RightField { get; set; }

        [JsonProperty("operation")]
        public string? Operation { get; set; }

        [JsonProperty("wbsUid")]
        public Guid? WbsUid { get; set; }
    }

    public class MetricVariablePayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("parentVariableUid")]
        public Guid? ParentVariableUid { get; set; }

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }

        [JsonProperty("isFieldVariable")]
        public bool IsFieldVariable { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("value")]
        public string? Value { get; set; }
    }

    public class ProjectVariablePayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }
    }

    public class ProjectVariableValuePayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("projectVariableUid")]
        public Guid ProjectVariableUid { get; set; }

        [JsonProperty("value")]
        public string? Value { get; set; }
    }

    public class CalculatedFieldPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("operatesOn")]
        public string? OperatesOn { get; set; }

        [JsonProperty("formula")]
        public string? Formula { get; set; }

        [JsonProperty("displayFormat")]
        public string? DisplayFormat { get; set; }
    }
}
