using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;
using Vitalize_Vault.Data;
using Vitalize_Vault.View;
using Vitalize_Vault.ViewModel;

namespace Vitalize_Vault
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider _serviceProvider;
        public App()
        {
            ServiceCollection services = new ServiceCollection();
            Configures(services);
            _serviceProvider = services.BuildServiceProvider();
        }

        private void Configures(ServiceCollection services)
        {
            services.AddTransient<ProductManagement>();
            services.AddTransient<ProductManagementViewModel>();            
            services.AddTransient<IProductDataProvider, ProductDataProvider>();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var productManagement = _serviceProvider.GetService<ProductManagement>();

            productManagement?.Show();
        }        
    }

}
