using JiuLing.TitleBarKit.Interfaces;
using JiuLing.TitleBarKit.Native;

namespace JiuLing.TitleBarKit.Services;
internal abstract class TitleBarDragHandlerBase : ITitleBarDragHandler
{
    public void DragMove()
    {
        var handle = GetWindowHandle();
        User32Methods.ReleaseCapture();
        User32Methods.SendMessage(handle, User32Methods.WM_NCLBUTTONDOWN, User32Methods.HTCAPTION, 0);
    }

    protected abstract IntPtr GetWindowHandle();
}