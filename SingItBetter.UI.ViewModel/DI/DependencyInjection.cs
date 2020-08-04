using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SingItBetter.Interfaces.ViewModel;
using SingItBetter.UI.ViewModel.ViewModel;

namespace SingItBetter.UI.ViewModel.DI
{
    public static class DependencyInjection
    {
        public static IServiceProvider SetUpDependencyInjection(Action<IServiceCollection> setUpExternalDependencies)
        {
            //setup our DI
            var serviceProvider = new ServiceCollection()
                .ConfigureLogging()
                .ConfigureServices(setUpExternalDependencies)
                .BuildServiceProvider();

            return serviceProvider;
        }

        private static IConfiguration GetConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            return builder.Build();
        }

        private static IServiceCollection ConfigureLogging(this IServiceCollection services)
        {
            services.AddLogging(l =>
            {
                l.ClearProviders();
                l.AddConsole();
                l.SetMinimumLevel(LogLevel.Debug);
            });
            return services;
        }

        private static IServiceCollection ConfigureServices(this IServiceCollection services,
            Action<IServiceCollection> setUpExternalDependencies)
        {
            var configuration = GetConfiguration();
            services
                .AddSingleton(configuration)

                .AddScoped<ISampleService, SampleService>()
                .AddScoped<IMainViewModel, MainViewModel>()
                
                ;

            setUpExternalDependencies(services);

            return services;
        }
    }
}