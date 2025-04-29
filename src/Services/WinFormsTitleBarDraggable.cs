namespace JiuLing.TitleBarKit.Services;
internal class WinFormsTitleBarDraggable : TitleBarDraggableBase
{
    private static IntPtr _handle = IntPtr.Zero;

    protected override IntPtr GetWindowHandle()
    {
        if (_handle != IntPtr.Zero)
        {
            return _handle;
        }

        var form = Form.ActiveForm ?? throw new InvalidOperationException("主窗口获取失败");
        _handle = form.Handle;

        if (_handle == IntPtr.Zero)
        {
            throw new InvalidOperationException("主窗口句柄获取失败");
        }

        return _handle;
    }
}