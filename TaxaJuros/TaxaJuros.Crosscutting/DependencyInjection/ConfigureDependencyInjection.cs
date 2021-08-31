using Microsoft.Extensions.DependencyInjection;
using TaxaJuros.Crosscutting.DependencyInjection.ApplicationInjection;

namespace TaxaJuros.Crosscutting.DependencyInjection
{
    public static class ConfigureDependencyInjection
    {
        public static void RegisterBindings(IServiceCollection services)
        {
            ConfigureBindingsTaxaJurosApplication.RegisterBindings(services);
        }
    }
}
