using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    public class ScriptLibraryPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("scripts")]
        public List<ScriptPayloadDto> Scripts { get; set; } = new List<ScriptPayloadDto>();

        [JsonProperty("criteria")]
        public List<CriterionPayloadDto> Criteria { get; set; } = new List<CriterionPayloadDto>();
    }

    public class ScriptPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>Ordered list of Criterion UIDs; list position = DISPLAY_ORDER.</summary>
        [JsonProperty("criterionUids")]
        public List<Guid> CriterionUids { get; set; } = new List<Guid>();
    }

    public class CriterionPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>RulePriority enum value (e.g. "Easiest", "Earliest", "Latest", "Longest").</summary>
        [JsonProperty("rulePriority")]
        public string? RulePriority { get; set; }

        /// <summary>RuleType enum value (e.g. "ReduceRemainingDuration", "ChangeCalendar", "RemoveConstraint").</summary>
        [JsonProperty("ruleType")]
        public string? RuleType { get; set; }

        [JsonProperty("rulePercentage")]
        public double RulePercentage { get; set; }

        /// <summary>RemoveConstraintMode enum value; only relevant when RuleType = "RemoveConstraint".</summary>
        [JsonProperty("ruleConstraintMode")]
        public string? RuleConstraintMode { get; set; }

        /// <summary>Calendar name; only relevant when RuleType = "ChangeCalendar".</summary>
        [JsonProperty("ruleCalendarName")]
        public string? RuleCalendarName { get; set; }

        [JsonProperty("filterGroups")]
        public List<FilterGroupPayloadDto> FilterGroups { get; set; } = new List<FilterGroupPayloadDto>();
    }

    public class FilterGroupPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("filters")]
        public List<MetricFilterExpressionPayloadDto> Filters { get; set; } = new List<MetricFilterExpressionPayloadDto>();
    }
}
