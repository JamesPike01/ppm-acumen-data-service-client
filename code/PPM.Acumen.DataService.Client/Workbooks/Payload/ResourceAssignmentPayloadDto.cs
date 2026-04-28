using Newtonsoft.Json;
using System;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    public class ResourceAssignmentPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("resourceUid")]
        public Guid? ResourceUid { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("resourceType")]
        public string? ResourceType { get; set; }

        [JsonProperty("sourceId")]
        public int? SourceId { get; set; }

        [JsonProperty("units")]
        public double? Units { get; set; }

        [JsonProperty("actualUnits")]
        public double? ActualUnits { get; set; }

        [JsonProperty("remainingUnits")]
        public double? RemainingUnits { get; set; }

        [JsonProperty("remainingUnitsPerHour")]
        public double? RemainingUnitsPerHour { get; set; }

        [JsonProperty("plannedUnits")]
        public double? PlannedUnits { get; set; }

        [JsonProperty("plannedUnitsPerHour")]
        public double? PlannedUnitsPerHour { get; set; }

        [JsonProperty("rate")]
        public double? Rate { get; set; }

        [JsonProperty("actualCost")]
        public double? ActualCost { get; set; }

        [JsonProperty("remainingCost")]
        public double? RemainingCost { get; set; }

        [JsonProperty("budgetCost")]
        public double? BudgetCost { get; set; }

        [JsonProperty("totalCost")]
        public double? TotalCost { get; set; }

        [JsonProperty("isCostBasedOnUnits")]
        public bool IsCostBasedOnUnits { get; set; }

        [JsonProperty("plannedStart")]
        public DateTime? PlannedStart { get; set; }

        [JsonProperty("plannedFinish")]
        public DateTime? PlannedFinish { get; set; }

        [JsonProperty("percentComplete")]
        public double? PercentComplete { get; set; }
    }
}
