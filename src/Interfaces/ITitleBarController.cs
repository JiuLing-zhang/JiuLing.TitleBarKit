namespace JiuLing.TitleBarKit.Interfaces;

/// <summary>
/// 窗口标题栏接口
/// </summary>
public interface ITitleBarController
{
    /// <summary>
    /// 获取窗口是否最大化
    /// </summary>
    bool IsMaximized { get; }

    /// <summary>
    /// 最小化窗口
    /// </summary>
    void Minimize();

    /// <summary>
    /// 最大化窗口
    /// </summary>
    void Maximize();

    /// <summary>
    /// 还原窗口
    /// </summary>
    void Restore();

    /// <summary>
    /// 切换最大化状态
    /// </summary>
    void ToggleMaximize();

    /// <summary>
    /// 关闭窗口
    /// </summary>
    void Close();
}