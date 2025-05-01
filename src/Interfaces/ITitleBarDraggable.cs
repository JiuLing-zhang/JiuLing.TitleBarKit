namespace JiuLing.TitleBarKit.Interfaces;

/// <summary>
/// 窗口拖动接口
/// </summary>
[Obsolete("ITitleBarDraggable 已弃用，请使用 ITitleBarDragHandler。", error: true)]
public interface ITitleBarDraggable
{
    /// <summary>
    /// 开始拖动窗口
    /// </summary>
    void DragMove();
}