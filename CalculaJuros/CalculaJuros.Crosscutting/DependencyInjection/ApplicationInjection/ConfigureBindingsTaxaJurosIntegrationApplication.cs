using CalculaJuros.Application.Service;
using Microsoft.Extensions.DependencyInjection;

namespace CalculaJuros.Crosscutting.DependencyInjection.ApplicationInjection
{
    public class ConfigureBindingsTaxaJurosIntegrationApplication
    {
        public static void RegisterBindings(IServiceCollection services)
        {
            services.AddScoped<TaxaJurosIntegrationService, TaxaJurosIntegrationService>();
        }
    }
}
