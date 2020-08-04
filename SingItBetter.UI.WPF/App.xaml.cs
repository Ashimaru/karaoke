using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using SingItBetter.Interfaces.ViewModel;
using SingItBetter.UI.ViewModel.DI;
using SingItBetter.UI.WPF.Windows;

namespace SingItBetter.UI.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IServiceProvider _provider { get; set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            _provider = DependencyInjection.SetUpDependencyInjection(SetUpExternalDependencies);
            var mainWindow = _provider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }

        private void SetUpExternalDependencies(IServiceCollection services)
        {
            services.AddScoped(s => new MainWindow{DataContext = s.GetRequiredService<IMainViewModel>()});
        }
    }
}
