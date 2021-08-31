using CalculaJuros.Infrastructure.Integration;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace CalculaJuros.Application.Service
{
    public class TaxaJurosIntegrationService : RestIntegration
    {
        private readonly string _url;
        public TaxaJurosIntegrationService(HttpClient client) : base(client)
        {
            client.DefaultRequestHeaders.Clear();
            _url = "http://taxajuros:80/";
        }
        public async Task<double> GetTaxaJuros(CancellationToken ct)
        {
            ct.ThrowIfCancellationRequested();
            var response = await GetAsync($"{_url}TaxaJuros", ct);
            var result = JsonConvert.DeserializeObject<double>(await response.Content.ReadAsStringAsync());
            return result;
        }
    }
}
