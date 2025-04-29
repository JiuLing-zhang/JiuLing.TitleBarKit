using System.Diagnostics.Metrics;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;

namespace JiuLing.TitleBarKit.WinForms.Test
{
    public partial class FmMain : Form
    {
        private readonly TitleBarService _windowControl;
        public FmMain()
        {
            InitializeComponent();

            var services = new ServiceCollection();
            services.AddWindowsFormsBlazorWebView();
            services.AddWinFormsTitleBar();
            services.AddBlazorWebViewDeveloperTools();
            var sp = services.BuildServiceProvider();
            blazorWebView1.HostPage = "wwwroot\\index.html";
            blazorWebView1.Services = sp;
            blazorWebView1.RootComponents.Add<Test>("#app");

            _windowControl = sp.GetRequiredService<TitleBarService>();
        }

        private void FmMain_Load(object sender, EventArgs e)
        {

        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            _windowControl.TitleBar.Minimize();
        }

        private void BtnToggleMaximize_Click(object sender, EventArgs e)
        {
            _windowControl.TitleBar.ToggleMaximize();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            _windowControl.TitleBar.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _windowControl.Draggable.DragMove();
        }
    }
}
