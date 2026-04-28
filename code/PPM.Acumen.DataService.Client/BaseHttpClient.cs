using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace PPM.Acumen.DataService.Client
{
    public abstract class BaseHttpClient : IBaseHttpClient
    {
        protected readonly HttpClient _httpClient;
        protected readonly ILogger? _logger;
        protected string _baseEndpoint = string.Empty;

        protected BaseHttpClient(HttpClient httpClient, ILogger? logger = null)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            _logger = logger;
        }

        public HttpClient HttpClient => _httpClient;
        public ILogger? Logger => _logger;

        public string BaseEndpoint
        {
            get => _baseEndpoint;
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Base endpoint cannot be null or empty", nameof(value));
                _baseEndpoint = value.TrimEnd('/');
            }
        }

        public async Task CheckResponseForSuccessAsync(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                _logger?.LogError(
                    "API request failed. Endpoint: {BaseEndpoint}, Status: {StatusCode}, Response: {Response}",
                    BaseEndpoint, response.StatusCode, errorContent);
                throw new HttpRequestException(
                    $"{BaseEndpoint} API call failed with status {(int)response.StatusCode}: {response.StatusCode}",
                    new Exception(errorContent));
            }
        }
    }
}
