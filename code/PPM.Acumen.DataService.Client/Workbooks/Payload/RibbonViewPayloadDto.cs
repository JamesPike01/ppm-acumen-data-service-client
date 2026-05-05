using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    public class RibbonViewPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("groupBy")]
        public string? GroupBy { get; set; }

        [JsonProperty("groupByFieldName")]
        public string? GroupByFieldName { get; set; }

        [JsonProperty("interval")]
        public string? Interval { get; set; }

        [JsonProperty("intervalSize")]
        public double IntervalSize { get; set; }

        [JsonProperty("numberOfRanges")]
        public int NumberOfRanges { get; set; }

        [JsonProperty("delimiterGroupingLevels")]
        public int DelimiterGroupingLevels { get; set; }

        [JsonProperty("analyzersFontSize")]
        public double AnalyzersFontSize { get; set; }

        [JsonProperty("wbsGroupingLevel")]
        public int WbsGroupingLevel { get; set; }

        [JsonProperty("currentActivityBrowserView")]
        public string? CurrentActivityBrowserView { get; set; }

        [JsonProperty("showNormalActivities")]
        public bool ShowNormalActivities { get; set; }

        [JsonProperty("showSummaries")]
        public bool ShowSummaries { get; set; }

        [JsonProperty("showHammocks")]
        public bool ShowHammocks { get; set; }

        [JsonProperty("showMilestones")]
        public bool ShowMilestones { get; set; }

        [JsonProperty("showTimeNowLine")]
        public bool ShowTimeNowLine { get; set; }

        [JsonProperty("isSelected")]
        public bool IsSelected { get; set; }

        [JsonProperty("activitiesShowCompletePct")]
        public bool ActivitiesShowCompletePct { get; set; }

        [JsonProperty("discreteGrouping")]
        public bool DiscreteGrouping { get; set; }

        [JsonProperty("delimiterGrouping")]
        public bool DelimiterGrouping { get; set; }

        [JsonProperty("delimiterGroupingShowParents")]
        public bool DelimiterGroupingShowParents { get; set; }

        [JsonProperty("rangeGrouping")]
        public bool RangeGrouping { get; set; }

        [JsonProperty("singleRibbonMode")]
        public bool SingleRibbonMode { get; set; }

        [JsonProperty("inWindowAnalysisMode")]
        public bool InWindowAnalysisMode { get; set; }

        [JsonProperty("wbsGroupingShowParents")]
        public bool WbsGroupingShowParents { get; set; }

        [JsonProperty("intervalSizeGrouping")]
        public bool IntervalSizeGrouping { get; set; }

        [JsonProperty("whenLeavingTrendRestoreGroupByProjects")]
        public bool WhenLeavingTrendRestoreGroupByProjects { get; set; }

        [JsonProperty("whenLeavingTrendRestoreGroupingField")]
        public string? WhenLeavingTrendRestoreGroupingField { get; set; }

        [JsonProperty("whenLeavingTrendClearTabularMetric")]
        public bool WhenLeavingTrendClearTabularMetric { get; set; }

        /// <summary>GroupByPathSettings.Filter (TopBottomRule enum).</summary>
        [JsonProperty("groupbyFilter")]
        public string? GroupbyFilter { get; set; }

        /// <summary>FK → METRIC; Prac.TabularModeMetric.</summary>
        [JsonProperty("tabularMetricUid")]
        public Guid? TabularMetricUid { get; set; }

        [JsonProperty("tabularChartIsVisible")]
        public bool TabularChartIsVisible { get; set; }

        [JsonProperty("tabularChartShowMarkers")]
        public bool TabularChartShowMarkers { get; set; }

        [JsonProperty("tabularChartIsLegendVisible")]
        public bool TabularChartIsLegendVisible { get; set; }

        [JsonProperty("tabularChartIsCumulative")]
        public bool TabularChartIsCumulative { get; set; }

        /// <summary>ChartType enum value (e.g. "Bar", "Column", "Line").</summary>
        [JsonProperty("tabularChartType")]
        public string? TabularChartType { get; set; }

        [JsonProperty("dateMarkers")]
        public List<DateMarkerPayloadDto> DateMarkers { get; set; } = new List<DateMarkerPayloadDto>();

        [JsonProperty("analyzers")]
        public List<RibbonAnalyzerPayloadDto> Analyzers { get; set; } = new List<RibbonAnalyzerPayloadDto>();

        [JsonProperty("ribbons")]
        public List<RibbonPayloadDto> Ribbons { get; set; } = new List<RibbonPayloadDto>();
    }

    public class RibbonAnalyzerPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        /// <summary>"Phase", "Ribbon", or "Segment".</summary>
        [JsonProperty("analyzerType")]
        public string? AnalyzerType { get; set; }

        [JsonProperty("chartIsVisible")]
        public bool ChartIsVisible { get; set; }

        [JsonProperty("chartShowMarkers")]
        public bool ChartShowMarkers { get; set; }

        [JsonProperty("chartIsLegendVisible")]
        public bool ChartIsLegendVisible { get; set; }

        [JsonProperty("chartIsCumulative")]
        public bool ChartIsCumulative { get; set; }

        /// <summary>ChartType enum value (e.g. "Bar", "Column", "Line").</summary>
        [JsonProperty("chartType")]
        public string? ChartType { get; set; }

        /// <summary>Ordered metric UIDs for Analyzer.AnalyzerMetrics; list position = ORDER_SEQ.</summary>
        [JsonProperty("metricUids")]
        public List<Guid> MetricUids { get; set; } = new List<Guid>();
    }

    public class RibbonPayloadDto
    {
        [JsonProperty("rowUid")]
        public Guid RowUid { get; set; }

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("timeNow")]
        public DateTime? TimeNow { get; set; }
    }

    public class DateMarkerPayloadDto
    {
        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("start")]
        public DateTime Start { get; set; }
    }
}
