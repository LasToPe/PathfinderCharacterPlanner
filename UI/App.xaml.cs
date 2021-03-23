using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using UI.ViewModels;

namespace UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IHost _host;
        public static IServiceProvider ServiceProvider { get; private set; }
        public App()
        {
            _host = Host.CreateDefaultBuilder().ConfigureServices((context, services) => ConfigureServices(services)).Build();
            ServiceProvider = _host.Services;
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<MainWindowViewModel>();
            services.AddSingleton<ClassSelectorDialogViewModel>();
            services.AddSingleton<ArchetypeSelectorDialogViewModel>();
            services.AddSingleton<SpellsViewDialogViewModel>();
        }
    }
}
