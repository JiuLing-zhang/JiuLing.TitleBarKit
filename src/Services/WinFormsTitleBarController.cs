using JiuLing.TitleBarKit.Interfaces;

namespace JiuLing.TitleBarKit.Services;

internal class WinFormsTitleBarController : ITitleBarController
{
    private static Form? _mainForm;

    public bool IsMaximized => GetMainForm().WindowState == FormWindowState.Maximized;

    public void Minimize()
    {
        GetMainForm().WindowState = FormWindowState.Minimized;
    }

    public void Maximize()
    {
        GetMainForm().WindowState = FormWindowState.Maximized;
    }

    public void Restore()
    {
        GetMainForm().WindowState = FormWindowState.Normal;
    }

    public void ToggleMaximize()
    {
        GetMainForm().WindowState = IsMaximized ? FormWindowState.Normal : FormWindowState.Maximized;
    }

    public void Close()
    {
        GetMainForm().Close();
    }

    private static Form GetMainForm()
    {
        if (_mainForm != null) return _mainForm;

        _mainForm = Form.ActiveForm;
        if (_mainForm == null)
        {
            throw new InvalidOperationException("主窗口获取失败");
        }

        return _mainForm;
    }
}