using Newtonsoft.Json;

namespace PPM.Acumen.DataService.Client.Workbooks.DTOs
{
    public class WorkbookExportRequest
    {
        /// <summary>
        /// When false (default), ACTIVITY_FORECAST rows are excluded from the export payload
        /// for faster export and smaller download size. Set true to include forecast data.
        /// </summary>
        [JsonProperty("includeForecast")]
        public bool IncludeForecast { get; set; } = false;
    }
}
