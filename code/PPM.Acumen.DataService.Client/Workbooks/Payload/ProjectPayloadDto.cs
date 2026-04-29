using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    public class ProjectPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("originalName")]
        public string? OriginalName { get; set; }

        [JsonProperty("sourcePlatform")]
        public string? SourcePlatform { get; set; }

        [JsonProperty("cultureLcid")]
        public int? CultureLcid { get; set; }

        [JsonProperty("startDate")]
        public DateTime? StartDate { get; set; }

        [JsonProperty("finishDate")]
        public DateTime? FinishDate { get; set; }

        [JsonProperty("statusDate")]
        public DateTime? StatusDate { get; set; }

        [JsonProperty("previousTimeNow")]
        public DateTime? PreviousTimeNow { get; set; }

        [JsonProperty("targetFinishDate")]
        public DateTime? TargetFinishDate { get; set; }

        [JsonProperty("mustFinishBy")]
        public DateTime? MustFinishBy { get; set; }

        [JsonProperty("baselineStartDate")]
        public DateTime? BaselineStartDate { get; set; }

        [JsonProperty("baselineFinishDate")]
        public DateTime? BaselineFinishDate { get; set; }

        [JsonProperty("baselineStatusDate")]
        public DateTime? BaselineStatusDate { get; set; }

        [JsonProperty("defaultCalendarUid")]
        public Guid? DefaultCalendarUid { get; set; }

        [JsonProperty("hoursPerDay")]
        public double? HoursPerDay { get; set; }

        [JsonProperty("schedulingLogic")]
        public string? SchedulingLogic { get; set; }

        [JsonProperty("lagCalendarOption")]
        public string? LagCalendarOption { get; set; }

        [JsonProperty("floatType")]
        public string? FloatType { get; set; }

        [JsonProperty("useExpectedFinishDates")]
        public bool UseExpectedFinishDates { get; set; }

        [JsonProperty("ssLagFromEarlyDates")]
        public bool SsLagFromEarlyDates { get; set; }

        [JsonProperty("useFloatForCritical")]
        public bool UseFloatForCritical { get; set; }

        [JsonProperty("maxFloatForCritical")]
        public double? MaxFloatForCritical { get; set; }

        [JsonProperty("ignoreCrossProjectLinks")]
        public bool IgnoreCrossProjectLinks { get; set; }

        [JsonProperty("enabledForAnalysis")]
        public bool EnabledForAnalysis { get; set; }

        [JsonProperty("integrateCostSchedule")]
        public bool IntegrateCostSchedule { get; set; }

        [JsonProperty("isUncertaintyLocked")]
        public bool IsUncertaintyLocked { get; set; }

        [JsonProperty("isCalibrationLocked")]
        public bool IsCalibrationLocked { get; set; }

        [JsonProperty("isCorrelated")]
        public bool IsCorrelated { get; set; }

        [JsonProperty("contractUid")]
        public Guid? ContractUid { get; set; }

        [JsonProperty("contractorUid")]
        public Guid? ContractorUid { get; set; }

        [JsonProperty("p6WebObjectId")]
        public int? P6WebObjectId { get; set; }

        [JsonProperty("mspServerProjectId")]
        public Guid? MspServerProjectId { get; set; }

        [JsonProperty("author")]
        public string? Author { get; set; }

        [JsonProperty("originalFilePath")]
        public string? OriginalFilePath { get; set; }

        [JsonProperty("lastImportDate")]
        public DateTime? LastImportDate { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; } = "Live";

        [JsonProperty("projectType")]
        public string? ProjectType { get; set; }

        [JsonProperty("parentProjectUid")]
        public Guid? ParentProjectUid { get; set; }

        [JsonProperty("locations")]
        public string? Locations { get; set; }

        [JsonProperty("popFromDate")]
        public DateTime? PopFromDate { get; set; }

        [JsonProperty("popToDate")]
        public DateTime? PopToDate { get; set; }

        [JsonProperty("additionalNotes")]
        public string? AdditionalNotes { get; set; }

        [JsonProperty("projectBudgetCost")]
        public double? ProjectBudgetCost { get; set; }

        [JsonProperty("targetRiskIterations")]
        public int TargetRiskIterations { get; set; } = -1;

        [JsonProperty("ermProjectUid")]
        public Guid? ErmProjectUid { get; set; }

        [JsonProperty("ermProjectName")]
        public string? ErmProjectName { get; set; }

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }

        [JsonProperty("riskRegisterUid")]
        public Guid? RiskRegisterUid { get; set; }

        [JsonProperty("baselines")]
        public List<ProjectBaselinePayloadDto> Baselines { get; set; } = new List<ProjectBaselinePayloadDto>();

        [JsonProperty("fieldMappings")]
        public List<FieldMappingPayloadDto> FieldMappings { get; set; } = new List<FieldMappingPayloadDto>();

        [JsonProperty("codeFiles")]
        public List<CodeFilePayloadDto> CodeFiles { get; set; } = new List<CodeFilePayloadDto>();

        [JsonProperty("calendars")]
        public List<CalendarPayloadDto> Calendars { get; set; } = new List<CalendarPayloadDto>();

        [JsonProperty("resources")]
        public List<ResourcePayloadDto> Resources { get; set; } = new List<ResourcePayloadDto>();

        [JsonProperty("activities")]
        public List<ActivityPayloadDto> Activities { get; set; } = new List<ActivityPayloadDto>();

        [JsonProperty("links")]
        public List<ActivityLinkPayloadDto> Links { get; set; } = new List<ActivityLinkPayloadDto>();

    }
}
