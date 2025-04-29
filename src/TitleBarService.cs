using JiuLing.TitleBarKit.Interfaces;

namespace JiuLing.TitleBarKit;

public class TitleBarService
{
    public ITitleBarController TitleBar { get; }
    public ITitleBarDraggable Draggable { get; }

    public TitleBarService(ITitleBarController titleBar, ITitleBarDraggable draggable)
    {
        TitleBar = titleBar;
        Draggable = draggable;
    }
}