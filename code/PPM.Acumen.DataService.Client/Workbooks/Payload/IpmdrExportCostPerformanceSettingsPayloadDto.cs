using System.Collections.Generic;
using Newtonsoft.Json;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    /// <summary>
    /// Value shape for the <see cref="PreferenceKeys.IpmdrExportCostPerformance"/> preference.
    /// Per-project IPMDR cost-performance export settings; stored at ENTITY scope
    /// (<c>ENTITY_TYPE = "Project"</c>).
    /// Mirrors the live properties of
    /// <c>Acumen.Fuse.Business.IPMDR.IPMDRExportCostPerformanceSettings</c>;
    /// obsolete properties (DirectValues, IndirectValues, Overhead, GeneralAndAdministrative,
    /// CostOfMoney) are intentionally not carried.
    /// </summary>
    public class IpmdrExportCostPerformanceSettingsPayloadDto
    {
        [JsonProperty("filePath")]
        public string? FilePath { get; set; }

        [JsonProperty("topNodeCode")]
        public string? TopNodeCode { get; set; }

        [JsonProperty("exportLevel")]
        public string? ExportLevel { get; set; }

        [JsonProperty("historicalData")]
        public string? HistoricalData { get; set; }

        [JsonProperty("aggregateBy")]
        public string? AggregateBy { get; set; }

        [JsonProperty("appendDateToFilename")]
        public bool AppendDateToFilename { get; set; }

        [JsonProperty("useWbsObsForControlAccount")]
        public bool UseWbsObsForControlAccount { get; set; }

        /// <summary>10-slot boolean array — values flagged for export at the control-account level (set 1).</summary>
        [JsonProperty("exportControlAccountValues")]
        public List<bool> ExportControlAccountValues { get; set; } = new List<bool>();

        /// <summary>10-slot boolean array — values flagged for export at the work-package level (set 1).</summary>
        [JsonProperty("exportWorkPackageValues")]
        public List<bool> ExportWorkPackageValues { get; set; } = new List<bool>();

        /// <summary>10-slot boolean array — values flagged for export at the control-account level (set 2).</summary>
        [JsonProperty("exportControlAccountValues2")]
        public List<bool> ExportControlAccountValues2 { get; set; } = new List<bool>();

        /// <summary>10-slot boolean array — values flagged for export at the work-package level (set 2).</summary>
        [JsonProperty("exportWorkPackageValues2")]
        public List<bool> ExportWorkPackageValues2 { get; set; } = new List<bool>();
    }
}
