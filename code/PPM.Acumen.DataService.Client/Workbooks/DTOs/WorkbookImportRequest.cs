using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace PPM.Acumen.DataService.Client.Workbooks.DTOs
{
    public class WorkbookImportRequest
    {
        /// <summary>UID returned by POST /files/upload. Must be used within 1 hour of upload.</summary>
        [Required]
        [JsonProperty("fileUid")]
        public Guid FileUid { get; set; }

        /// <summary>
        /// When false (default), existing ACTIVITY_FORECAST rows are preserved and all other
        /// workbook data is replaced. Set true to overwrite forecast data from the payload.
        /// </summary>
        [JsonProperty("includeForecast")]
        public bool IncludeForecast { get; set; } = false;
    }
}
