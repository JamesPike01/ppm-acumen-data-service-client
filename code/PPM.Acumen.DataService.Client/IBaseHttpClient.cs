using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Threading.Tasks;

namespace PPM.Acumen.DataService.Client
{
    public interface IBaseHttpClient
    {
        HttpClient HttpClient { get; }
        ILogger? Logger { get; }
        string BaseEndpoint { get; }
        Task CheckResponseForSuccessAsync(HttpResponseMessage response);
    }
}
