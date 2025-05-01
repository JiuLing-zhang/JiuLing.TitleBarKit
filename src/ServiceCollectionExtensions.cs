using JiuLing.TitleBarKit.Interfaces;
using JiuLing.TitleBarKit.Services;
using Microsoft.Extensions.DependencyInjection;

namespace JiuLing.TitleBarKit;

/// <summary>
/// 服务注入扩展
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// 为 WPF 程序添加窗口标题栏服务
    /// </summary>
    public static IServiceCollection AddWpfTitleBarKit(this IServiceCollection services)
    {
        services.AddSingleton<ITitleBarController>(new WpfTitleBarController());
        services.AddSingleton<ITitleBarDragHandler>(new WpfTitleBarDragHandler());
        services.AddSingleton<TitleBarService>();
        return services;
    }

    /// <summary>
    /// 为 WinForms 程序添加窗口标题栏服务
    /// </summary>
    public static IServiceCollection AddWinFormsTitleBarKit(this IServiceCollection services)
    {
        services.AddSingleton<ITitleBarController>(new WinFormsTitleBarController());
        services.AddSingleton<ITitleBarDragHandler>(new WinFormsTitleBarDragHandler());

        services.AddSingleton<TitleBarService>();
        return services;
    }

    /// <summary>
    /// 为 WPF 程序添加窗口标题栏服务
    /// </summary>
    [Obsolete("AddWpfTitleBar 已弃用，请使用 AddWpfTitleBarKit。", error: true)]
    public static IServiceCollection AddWpfTitleBar(this IServiceCollection services)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// 为 WinForms 程序添加窗口标题栏服务
    /// </summary>
    [Obsolete("AddWinFormsTitleBar 已弃用，请使用 AddWinFormsTitleBarKit。", error: true)]
    public static IServiceCollection AddWinFormsTitleBar(this IServiceCollection services)
    {
        throw new NotImplementedException();
    }
}