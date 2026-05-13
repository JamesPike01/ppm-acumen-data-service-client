using Newtonsoft.Json;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    /// <summary>
    /// Value shape for the <see cref="PreferenceKeys.IpmdrExportSchedule"/> preference.
    /// Per-project IPMDR schedule export settings; stored at ENTITY scope
    /// (<c>ENTITY_TYPE = "Project"</c>).
    /// Mirrors <c>Acumen.Fuse.Business.IPMDR.IPMDRExportScheduleSettings</c>.
    /// </summary>
    public class IpmdrExportScheduleSettingsPayloadDto
    {
        [JsonProperty("filePath")]
        public string? FilePath { get; set; }

        [JsonProperty("onlyUsedCalendars")]
        public bool OnlyUsedCalendars { get; set; }

        [JsonProperty("onlyUsedResources")]
        public bool OnlyUsedResources { get; set; }

        [JsonProperty("appendDateToFilename")]
        public bool AppendDateToFilename { get; set; }

        [JsonProperty("taskId")]
        public string? TaskId { get; set; }

        [JsonProperty("taskSubtype")]
        public string? TaskSubtype { get; set; }

        [JsonProperty("taskPlanningLevel")]
        public string? TaskPlanningLevel { get; set; }

        [JsonProperty("wbsId")]
        public string? WbsId { get; set; }

        [JsonProperty("obsId")]
        public string? ObsId { get; set; }

        [JsonProperty("controlAccountId")]
        public string? ControlAccountId { get; set; }

        [JsonProperty("workPackageId")]
        public string? WorkPackageId { get; set; }

        [JsonProperty("integratedMasterPlanId")]
        public string? IntegratedMasterPlanId { get; set; }

        [JsonProperty("sowReference")]
        public string? SowReference { get; set; }

        [JsonProperty("subcontractorReferenceId")]
        public string? SubcontractorReferenceId { get; set; }

        [JsonProperty("earnedValueTechnique")]
        public string? EarnedValueTechnique { get; set; }

        [JsonProperty("criticalPath")]
        public string? CriticalPath { get; set; }

        [JsonProperty("drivingPath")]
        public string? DrivingPath { get; set; }

        [JsonProperty("totalFloat")]
        public string? TotalFloat { get; set; }

        [JsonProperty("field1")]
        public string? Field1 { get; set; }

        [JsonProperty("field2")]
        public string? Field2 { get; set; }

        [JsonProperty("field3")]
        public string? Field3 { get; set; }

        [JsonProperty("field4")]
        public string? Field4 { get; set; }

        [JsonProperty("field5")]
        public string? Field5 { get; set; }

        [JsonProperty("field6")]
        public string? Field6 { get; set; }

        [JsonProperty("field7")]
        public string? Field7 { get; set; }

        [JsonProperty("field8")]
        public string? Field8 { get; set; }

        [JsonProperty("field9")]
        public string? Field9 { get; set; }

        [JsonProperty("field10")]
        public string? Field10 { get; set; }
    }
}
