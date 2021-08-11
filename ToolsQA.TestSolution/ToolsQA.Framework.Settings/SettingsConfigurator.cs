namespace ToolsQA.Framework.Settings
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Newtonsoft.Json.Linq;
    using System;
    using System.IO;
    using ToolsQA.Framework.Settings.Models;

    public static class SettingsConfigurator
    {
        private static readonly Lazy<IConfiguration> Configuration = new(LoadConfiguration);

        private static ServiceProvider serviceProvider;

        public static ServiceProvider ServiceProvider => serviceProvider ??= GetServiceProvider();

        public static AppSettingsModel AppSettings => ServiceProvider.GetService<AppSettingsModel>();

        private static IConfigurationRoot LoadConfiguration()
        {
            var environment = GetEnvironment();
            return new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
                .AddJsonFile($@"SettingsFiles\appsettings.{environment}.json", false, true)
                .Build();
        }

        private static string GetEnvironment()
        {
            var jsonContent = File.ReadAllText(@"SettingsFiles\environment.json");

            return JObject.Parse(jsonContent).SelectToken("Environment").Value<string>();
        }

        private static ServiceProvider GetServiceProvider()
        {
            var appSettings = new AppSettingsModel();

            Configuration.Value.Bind(appSettings);

            var services = new ServiceCollection();

            services.AddSingleton(Configuration);
            services.AddSingleton(appSettings);

            return services.BuildServiceProvider();
        }
    }
}
