using System.Collections.Generic;
using Newtonsoft.Json;

namespace PPM.Acumen.DataService.Client.Workbooks.Payload
{
    /// <summary>
    /// Value shape for the <see cref="PreferenceKeys.SmartGanttTimeScales"/> preference.
    /// Workbook-scoped named list of Smart Gantt time scale definitions; stored at ENTITY scope
    /// with <c>ENTITY_TYPE = "Workbook"</c>.
    /// Mirrors <c>Workbook.SmartGanttTimeScales</c>.
    /// </summary>
    public class SmartGanttTimeScalesPayloadDto
    {
        [JsonProperty("scales")]
        public List<SmartGanttTimeScalePayloadDto> Scales { get; set; } = new List<SmartGanttTimeScalePayloadDto>();
    }

    /// <summary>
    /// One Smart Gantt time scale — a named (Name, StartField, FinishField) triple plus a check flag.
    /// Mirrors <c>Acumen.Fuse.Business.SmartGantt.SmartGanttTimeScale</c>.
    /// </summary>
    public class SmartGanttTimeScalePayloadDto
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("startField")]
        public string? StartField { get; set; }

        [JsonProperty("finishField")]
        public string? FinishField { get; set; }

        [JsonProperty("isChecked")]
        public bool IsChecked { get; set; }
    }
}
