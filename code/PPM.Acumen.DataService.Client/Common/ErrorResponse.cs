using Newtonsoft.Json;

namespace PPM.Acumen.DataService.Client.Common
{
    public class ErrorResponse
    {
        [JsonProperty("message")]
        public string? Message { get; set; }

        [JsonProperty("details")]
        public string? Details { get; set; }
    }
}
