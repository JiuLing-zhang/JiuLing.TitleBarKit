using JiuLing.TitleBarKit.Interfaces;
using JiuLing.TitleBarKit.Services;
using Microsoft.Extensions.DependencyInjection;

namespace JiuLing.TitleBarKit;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// 为 WPF 程序添加窗口标题栏服务
    /// </summary>
    public static IServiceCollection AddWpfTitleBar(this IServiceCollection services)
    {
        services.AddSingleton<ITitleBarController>(new WpfTitleBarController());
        services.AddSingleton<ITitleBarDraggable>(new WpfTitleBarDraggable());
        services.AddSingleton<TitleBarService>();
        return services;
    }

    /// <summary>
    /// 为 WinForms 程序添加窗口标题栏服务
    /// </summary>
    public static IServiceCollection AddWinFormsTitleBar(this IServiceCollection services)
    {
        services.AddSingleton<ITitleBarController>(new WinFormsTitleBarController());
        services.AddSingleton<ITitleBarDraggable>(new WinFormsTitleBarDraggable());

        services.AddSingleton<TitleBarService>();
        return services;
    }
}