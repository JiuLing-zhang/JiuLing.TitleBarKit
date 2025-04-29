using System.Windows;
using JiuLing.TitleBarKit.Interfaces;
using Application = System.Windows.Application;

namespace JiuLing.TitleBarKit.Services;

internal class WpfTitleBarController : ITitleBarController
{
    private static Window? _mainWindow;

    public bool IsMaximized => GetMainWindow().WindowState == WindowState.Maximized;

    public void Minimize() => GetMainWindow().WindowState = WindowState.Minimized;

    public void Maximize() => GetMainWindow().WindowState = WindowState.Maximized;

    public void Restore() => GetMainWindow().WindowState = WindowState.Normal;

    public void ToggleMaximize()
    {
        GetMainWindow().WindowState = IsMaximized ? WindowState.Normal : WindowState.Maximized;
    }

    public void Close() => GetMainWindow().Close();

    private static Window GetMainWindow()
    {
        if (_mainWindow != null)
        {
            return _mainWindow;
        }
        _mainWindow = Application.Current?.MainWindow;
        if (_mainWindow == null)
        {
            throw new InvalidOperationException("主窗口获取失败");
        }
        return _mainWindow;
    }
}