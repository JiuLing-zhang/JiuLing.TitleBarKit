using System.Configuration;
using System.Data;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;

namespace JiuLing.TitleBarKit.Wpf.Test
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            // Initialize();
        }

        private void Initialize()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddWpfBlazorWebView();
            serviceCollection.AddWpfTitleBarKit();
            serviceCollection.AddSingleton<MainWindow>();
            var sp = serviceCollection.BuildServiceProvider();
            Resources.Add("services", sp);

            var mainWindow = sp.GetRequiredService<MainWindow>();
            Application.Current.MainWindow = mainWindow;
            mainWindow.Show();
        }
    }

}
