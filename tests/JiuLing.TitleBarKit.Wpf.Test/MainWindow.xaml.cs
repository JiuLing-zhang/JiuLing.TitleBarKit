using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Extensions.DependencyInjection;

namespace JiuLing.TitleBarKit.Wpf.Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly TitleBarService _windowControl;
        public MainWindow()
        {
            InitializeComponent();

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddWpfBlazorWebView();
            serviceCollection.AddBlazorWebViewDeveloperTools();
            serviceCollection.AddWpfTitleBar();
            serviceCollection.AddSingleton<MainWindow>();
            var sp = serviceCollection.BuildServiceProvider();
            Resources.Add("services", sp);

            _windowControl = sp.GetRequiredService<TitleBarService>();
        }

        private void TitleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                _windowControl.Draggable.DragMove();
            }
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            _windowControl.TitleBar.Minimize();
        }

        private void Maximize_Click(object sender, RoutedEventArgs e)
        {
            _windowControl.TitleBar.ToggleMaximize();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            _windowControl.TitleBar.Close();
        }

    }
}