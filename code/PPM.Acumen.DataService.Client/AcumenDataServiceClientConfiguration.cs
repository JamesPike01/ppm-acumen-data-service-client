using Microsoft.Extensions.Logging;

namespace PPM.Acumen.DataService.Client
{
    public class AcumenDataServiceClientConfiguration
    {
        /// <summary>Gets or sets the base URL of the ppm-acumen-data-service, e.g. "https://host/api/data".</summary>
        public string AcumenDataServiceEndpoint { get; set; } = string.Empty;

        /// <summary>Gets or sets the Bearer token for JWT authentication.</summary>
        public string BearerToken { get; set; } = string.Empty;

        public ILoggerFactory LoggerFactory { get; set; } = null!;
    }
}
