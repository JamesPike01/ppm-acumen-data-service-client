namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    /// <summary>
    /// Canonical PREFERENCE_KEY values used by Acumen. These map 1:1 to rows in the
    /// PREFERENCE_DEFINITION table. Each key has a documented JSON value shape — see the
    /// matching <c>*PayloadDto</c> class in this folder for the contract.
    /// <para>
    /// Keep these aligned with the seed JSON in
    /// <c>obsidian/vault/acumen-web/database/proposed-schema/preference-definitions.json</c>.
    /// </para>
    /// </summary>
    public static class PreferenceKeys
    {
        /// <summary>
        /// Per-project Excel import settings (ID column, WBS column, WBS delimiter, build-WBS flag,
        /// relationships worksheet). Stored at ENTITY scope with <c>ENTITY_TYPE = "Project"</c>.
        /// Value shape: <see cref="ExcelProjectSettingsPayloadDto"/>.
        /// </summary>
        public const string ExcelProjectSettings = "EXCEL_PROJECT_SETTINGS";

        /// <summary>
        /// Per-project Safran import settings (WBS field number and name). Stored at ENTITY scope
        /// with <c>ENTITY_TYPE = "Project"</c>. Value shape: <see cref="SafranProjectSettingsPayloadDto"/>.
        /// </summary>
        public const string SafranProjectSettings = "SAFRAN_PROJECT_SETTINGS";

        /// <summary>
        /// Per-project IPMDR cost-performance export settings. Stored at ENTITY scope with
        /// <c>ENTITY_TYPE = "Project"</c>. Value shape: <see cref="IpmdrExportCostPerformanceSettingsPayloadDto"/>.
        /// </summary>
        public const string IpmdrExportCostPerformance = "IPMDR_EXPORT_COST_PERFORMANCE";

        /// <summary>
        /// Per-project IPMDR schedule export settings. Stored at ENTITY scope with
        /// <c>ENTITY_TYPE = "Project"</c>. Value shape: <see cref="IpmdrExportScheduleSettingsPayloadDto"/>.
        /// </summary>
        public const string IpmdrExportSchedule = "IPMDR_EXPORT_SCHEDULE";

        /// <summary>
        /// Per-project IPMR2 export settings (schedule + contract-performance paths plus structural
        /// field-key references). Stored at ENTITY scope with <c>ENTITY_TYPE = "Project"</c>.
        /// Value shape: <see cref="Ipmr2ExportSettingsPayloadDto"/>.
        /// </summary>
        public const string Ipmr2Export = "IPMR2_EXPORT";

        /// <summary>
        /// Per-project Monte Carlo risk analysis configuration (iterations, seed, correlation, phase,
        /// mode, …). Nested chart settings (Histogram, Tornado, Scatter, TopCriticalPaths) live in
        /// their own preferences. Stored at ENTITY scope with <c>ENTITY_TYPE = "Project"</c>.
        /// Value shape: <see cref="RiskAnalysisSettingsPayloadDto"/>.
        /// </summary>
        public const string RiskAnalysisSettings = "RISK_ANALYSIS_SETTINGS";

        /// <summary>
        /// Per-project histogram chart settings (bar count, axis formats, highlighters, contingency
        /// level, …). Stored at ENTITY scope with <c>ENTITY_TYPE = "Project"</c>.
        /// Value shape: <see cref="HistogramSettingsPayloadDto"/>.
        /// </summary>
        public const string HistogramSettings = "HISTOGRAM_SETTINGS";

        /// <summary>
        /// Per-project tornado chart settings (top-N, sort mode, label modes, axis modes, …).
        /// Stored at ENTITY scope with <c>ENTITY_TYPE = "Project"</c>.
        /// Value shape: <see cref="TornadoSettingsPayloadDto"/>.
        /// </summary>
        public const string TornadoSettings = "TORNADO_SETTINGS";

        /// <summary>
        /// Per-project tornado-comparison chart settings (scalar properties only — layers and
        /// per-type primary-layer mapping are deferred to their own model). Stored at ENTITY scope
        /// with <c>ENTITY_TYPE = "Project"</c>.
        /// Value shape: <see cref="TornadoComparisonSettingsPayloadDto"/>.
        /// </summary>
        public const string TornadoComparisonSettings = "TORNADO_COMPARISON_SETTINGS";

        /// <summary>
        /// Per-project scatter chart settings (axis modes, JCL, regression toggle, …).
        /// Stored at ENTITY scope with <c>ENTITY_TYPE = "Project"</c>.
        /// Value shape: <see cref="ScatterChartSettingsPayloadDto"/>.
        /// </summary>
        public const string ScatterChartSettings = "SCATTER_CHART_SETTINGS";

        /// <summary>
        /// Per-project top-critical-paths chart setting (single <c>topN</c> property).
        /// Stored at ENTITY scope with <c>ENTITY_TYPE = "Project"</c>.
        /// Value shape: <see cref="TopCriticalPathsSettingsPayloadDto"/>.
        /// </summary>
        public const string TopCriticalPathsSettings = "TOP_CRITICAL_PATHS_SETTINGS";

        /// <summary>
        /// Workbook-scoped named list of Smart Gantt time scale definitions
        /// (defaults are 4 generic Dates / Start / Finish triples).
        /// Stored at ENTITY scope with <c>ENTITY_TYPE = "Workbook"</c>.
        /// Value shape: <see cref="SmartGanttTimeScalesPayloadDto"/>.
        /// </summary>
        public const string SmartGanttTimeScales = "SMART_GANTT_TIME_SCALES";
    }
}
