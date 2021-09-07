using System.IO;
using Microsoft.Extensions.Configuration;

namespace Shared
{
    public static class ConfigBuilder
    {
        public static IConfigurationRoot GetConfig()
        {
            var configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddXmlFile("App.config", optional: true, reloadOnChange: true);
            return configurationBuilder.Build();
        }
    }
}