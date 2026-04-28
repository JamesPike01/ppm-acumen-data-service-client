using Newtonsoft.Json;
using PPM.Acumen.DataService.Client.Common;
using System;

namespace PPM.Acumen.DataService.Client.Files.DTOs
{
    public class FileUploadResponse
    {
        /// <summary>Short-lived reference to the staged file. Pass to the import endpoint within the expiry window.</summary>
        [JsonProperty("fileUid")]
        public Guid FileUid { get; set; }

        /// <summary>UTC timestamp when the staged file and fileUid expire (typically 1 hour after upload).</summary>
        [JsonProperty("expiresAt")]
        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? ExpiresAt { get; set; }
    }
}
