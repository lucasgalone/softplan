using Microsoft.Extensions.DependencyInjection;
using TaxaJuros.Application.Service;

namespace TaxaJuros.Crosscutting.DependencyInjection.ApplicationInjection
{
    public static class ConfigureBindingsTaxaJurosApplication
    {
        public static void RegisterBindings(IServiceCollection services)
        {
            services.AddScoped<TaxaJurosService, TaxaJurosService>();
        }
    }
}
