using CalculaJuros.Crosscutting.DependencyInjection.ApplicationInjection;
using Microsoft.Extensions.DependencyInjection;

namespace CalculaJuros.Crosscutting.DependencyInjection
{
    public class ConfigureDependencyInjection
    {
        public static void RegisterBindings(IServiceCollection services)
        {
            ConfigureBindingsCalculoApplication.RegisterBindings(services);
            ConfigureBindingsTaxaJurosIntegrationApplication.RegisterBindings(services);
        }
    }
}
