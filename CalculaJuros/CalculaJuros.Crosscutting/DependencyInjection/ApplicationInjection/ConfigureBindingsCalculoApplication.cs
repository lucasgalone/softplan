using CalculaJuros.Application.Service;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;

namespace CalculaJuros.Crosscutting.DependencyInjection.ApplicationInjection
{
    public class ConfigureBindingsCalculoApplication
    {
        public static void RegisterBindings(IServiceCollection services)
        {
            services.AddScoped<CalculoService, CalculoService>();
            services.AddScoped<HttpClient, HttpClient>(); 
        }
    }
}
