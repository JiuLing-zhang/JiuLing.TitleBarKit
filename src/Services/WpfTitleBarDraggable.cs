using System.Windows.Interop;
using Application = System.Windows.Application;

namespace JiuLing.TitleBarKit.Services;

internal class WpfTitleBarDraggable : TitleBarDraggableBase
{
    private static IntPtr _handle = IntPtr.Zero;

    protected override IntPtr GetWindowHandle()
    {
        if (_handle != IntPtr.Zero)
        {
            return _handle;
        }

        var window = Application.Current?.MainWindow ?? throw new InvalidOperationException("主窗口获取失败");
        _handle = new WindowInteropHelper(window).Handle;

        if (_handle == IntPtr.Zero)
        {
            throw new InvalidOperationException("主窗口句柄获取失败");
        }

        return _handle;
    }
}