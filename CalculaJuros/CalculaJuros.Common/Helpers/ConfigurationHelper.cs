using CalculaJuros.Common.Configuration;

namespace CalculaJuros.Common.Helpers
{
    public class ConfigurationHelper
    {
        private static AppSettings _appSettings;

        public ConfigurationHelper(AppSettings settings)
        {
            _appSettings = settings;
        }

        public static string GetAppSettingsValue(string key)
        {
            return _appSettings.Get(key);
        }
    }
}
