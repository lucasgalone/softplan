using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace CalculaJuros.Infrastructure.Integration
{
    public class RestIntegration
    {
        protected readonly HttpClient Client;

        public RestIntegration(HttpClient client)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            Client = client;
            Client.Timeout = TimeSpan.FromMinutes(4);
        }

        protected virtual async Task<HttpResponseMessage> GetAsync(string parameters, CancellationToken ct)
        {
            ct.ThrowIfCancellationRequested();
            return await Client.GetAsync(parameters, ct);
        }
    }
}
