using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    public class ActivityPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("activityId")]
        public string? ActivityId { get; set; }

        [JsonProperty("sourceId")]
        public string? SourceId { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("activityType")]
        public string? ActivityType { get; set; }

        [JsonProperty("startDate")]
        public DateTime? StartDate { get; set; }

        [JsonProperty("finishDate")]
        public DateTime? FinishDate { get; set; }

        [JsonProperty("earlyStart")]
        public DateTime? EarlyStart { get; set; }

        [JsonProperty("earlyFinish")]
        public DateTime? EarlyFinish { get; set; }

        [JsonProperty("lateStart")]
        public DateTime? LateStart { get; set; }

        [JsonProperty("lateFinish")]
        public DateTime? LateFinish { get; set; }

        [JsonProperty("actualStart")]
        public DateTime? ActualStart { get; set; }

        [JsonProperty("actualFinish")]
        public DateTime? ActualFinish { get; set; }

        [JsonProperty("previousStart")]
        public DateTime? PreviousStart { get; set; }

        [JsonProperty("previousFinish")]
        public DateTime? PreviousFinish { get; set; }

        [JsonProperty("previousActualStart")]
        public DateTime? PreviousActualStart { get; set; }

        [JsonProperty("previousActualFinish")]
        public DateTime? PreviousActualFinish { get; set; }

        [JsonProperty("baselineStart")]
        public DateTime? BaselineStart { get; set; }

        [JsonProperty("baselineFinish")]
        public DateTime? BaselineFinish { get; set; }

        [JsonProperty("baselineTimeNow")]
        public DateTime? BaselineTimeNow { get; set; }

        [JsonProperty("expectedFinish")]
        public DateTime? ExpectedFinish { get; set; }

        [JsonProperty("primaryConstraintDate")]
        public DateTime? PrimaryConstraintDate { get; set; }

        [JsonProperty("primaryConstraint")]
        public string? PrimaryConstraint { get; set; }

        [JsonProperty("secondaryConstraintDate")]
        public DateTime? SecondaryConstraintDate { get; set; }

        [JsonProperty("secondaryConstraint")]
        public string? SecondaryConstraint { get; set; }

        [JsonProperty("suspendDate")]
        public DateTime? SuspendDate { get; set; }

        [JsonProperty("resumeDate")]
        public DateTime? ResumeDate { get; set; }

        [JsonProperty("remainingDuration")]
        public double? RemainingDuration { get; set; }

        [JsonProperty("actualDuration")]
        public double? ActualDuration { get; set; }

        [JsonProperty("prevRemainingDuration")]
        public double? PrevRemainingDuration { get; set; }

        [JsonProperty("totalFloat")]
        public double? TotalFloat { get; set; }

        [JsonProperty("freeFloat")]
        public double? FreeFloat { get; set; }

        [JsonProperty("actualCost")]
        public double? ActualCost { get; set; }

        [JsonProperty("remainingCost")]
        public double? RemainingCost { get; set; }

        [JsonProperty("remainingLaborUnits")]
        public double? RemainingLaborUnits { get; set; }

        [JsonProperty("actualLaborUnits")]
        public double? ActualLaborUnits { get; set; }

        [JsonProperty("remainingNonLaborUnits")]
        public double? RemainingNonLaborUnits { get; set; }

        [JsonProperty("actualNonLaborUnits")]
        public double? ActualNonLaborUnits { get; set; }

        [JsonProperty("physicalPctComplete")]
        public double? PhysicalPctComplete { get; set; }

        [JsonProperty("pctCompleteType")]
        public string? PctCompleteType { get; set; }

        [JsonProperty("existencePct")]
        public double? ExistencePct { get; set; }

        [JsonProperty("calendarUid")]
        public Guid? CalendarUid { get; set; }

        [JsonProperty("isCritical")]
        public bool IsCritical { get; set; }

        [JsonProperty("isLongestPath")]
        public bool IsLongestPath { get; set; }

        [JsonProperty("isExternal")]
        public bool IsExternal { get; set; }

        [JsonProperty("isExcludedFromAnalysis")]
        public bool IsExcludedFromAnalysis { get; set; }

        [JsonProperty("isCalibrationLocked")]
        public bool IsCalibrationLocked { get; set; }

        [JsonProperty("isUncertaintyLocked")]
        public bool IsUncertaintyLocked { get; set; }

        [JsonProperty("isCorrelated")]
        public bool IsCorrelated { get; set; }

        [JsonProperty("loeActivity")]
        public bool LoeActivity { get; set; }

        [JsonProperty("includeInTimeline")]
        public bool IncludeInTimeline { get; set; }

        [JsonProperty("integrateCostSchedule")]
        public bool IntegrateCostSchedule { get; set; }

        [JsonProperty("externalPredCount")]
        public int ExternalPredCount { get; set; }

        [JsonProperty("externalSuccCount")]
        public int ExternalSuccCount { get; set; }

        [JsonProperty("externalEarlyStart")]
        public DateTime? ExternalEarlyStart { get; set; }

        [JsonProperty("externalLateFinish")]
        public DateTime? ExternalLateFinish { get; set; }

        [JsonProperty("annotations")]
        public string? Annotations { get; set; }

        [JsonProperty("riskNotes")]
        public string? RiskNotes { get; set; }

        [JsonProperty("originalActivityUid")]
        public Guid? OriginalActivityUid { get; set; }

        [JsonProperty("uncertainty")]
        public List<ActivityUncertaintyPayloadDto> Uncertainty { get; set; } = new List<ActivityUncertaintyPayloadDto>();

        [JsonProperty("riskLinks")]
        public List<ActivityRiskLinkPayloadDto> RiskLinks { get; set; } = new List<ActivityRiskLinkPayloadDto>();

        [JsonProperty("resourceAssignments")]
        public List<ResourceAssignmentPayloadDto> ResourceAssignments { get; set; } = new List<ResourceAssignmentPayloadDto>();

        [JsonProperty("userFieldValues")]
        public Dictionary<string, string>? UserFieldValues { get; set; }

        [JsonProperty("userCodeValues")]
        public List<UserCodeValuePayloadDto> UserCodeValues { get; set; } = new List<UserCodeValuePayloadDto>();

        [JsonProperty("calibration")]
        public ActivityCalibrationPayloadDto? Calibration { get; set; }
    }

    public class ActivityCalibrationPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("isEnabled")]
        public bool IsEnabled { get; set; }

        [JsonProperty("useFactor")]
        public bool UseFactor { get; set; }

        [JsonProperty("factor")]
        public double Factor { get; set; }

        [JsonProperty("templateFactorIndex")]
        public int? TemplateFactorIndex { get; set; }
    }
}
