using System;
using Microsoft.Extensions.DependencyInjection;
using SingItBetter.UI.ViewModel.DI;

namespace SingItBetter.UI.Console
{
    class Program
    {
        private static IServiceProvider Provider { get; set; }
        static void Main(string[] args)
        {
            Provider = DependencyInjection.SetUpDependencyInjection(SetUpExternalDependencyInjection);

            Provider.GetRequiredService<Startup>().Run();
        }

        static void SetUpExternalDependencyInjection(IServiceCollection services)
        {
            services.AddScoped<Startup>();
        }
    }
}
