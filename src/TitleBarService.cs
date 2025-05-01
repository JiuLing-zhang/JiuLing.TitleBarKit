using JiuLing.TitleBarKit.Interfaces;

namespace JiuLing.TitleBarKit;

/// <summary>
/// 窗口标题栏聚合服务
/// </summary>
public class TitleBarService
{
    /// <summary>
    /// 窗口标题栏控制器
    /// </summary>
    [Obsolete("TitleBar 已弃用，请使用 Controller。", error: true)]
    public ITitleBarController TitleBar { get; } = null!;

    /// <summary>
    /// 窗口拖动接口
    /// </summary>

    [Obsolete("Draggable 已弃用，请使用 DragHandler。", error: true)]
    public ITitleBarDraggable Draggable { get; } = null!;

    /// <summary>
    /// 窗口标题栏控制器
    /// </summary>
    public ITitleBarController Controller { get; }

    /// <summary>
    /// 窗口拖动接口
    /// </summary>
    public ITitleBarDragHandler DragHandler { get; }

    /// <summary>
    /// 服务注入
    /// </summary>
    public TitleBarService(ITitleBarController controller, ITitleBarDragHandler dragHandler)
    {
        Controller = controller;
        DragHandler = dragHandler;
    }
}