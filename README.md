<div align="center">

![License Badge](https://img.shields.io/github/license/JiuLing-zhang/JiuLing.TitleBarKit)
[![NuGet Badge](https://img.shields.io/nuget/v/JiuLing.TitleBarKit)](https://www.nuget.org/packages/JiuLing.TitleBarKit/)
[![Releases Badge](https://img.shields.io/github/v/release/JiuLing-zhang/JiuLing.TitleBarKit)](https://github.com/JiuLing-zhang/JiuLing.TitleBarKit/releases)

</div>


# JiuLing.TitleBarKit

🌟 **WPF / WinForms / Blazor 混合应用中的标题栏工具集**  
🌟 **A title bar utility toolkit for WPF, WinForms, and Blazor hybrid applications**

---

## 📌 简介 | Introduction

本组件旨在解决隐藏系统标题栏后窗口无法拖动、关闭、最大化、最小化等问题，适用于 WPF、WinForms、BlazorHybrid 混合架构。  
This library solves title bar interaction problems after hiding native system borders in WPF, WinForms, or BlazorHybrid apps.

---

## ✨ 特性 | Features

- 支持窗口拖动  
  Window drag support  
- 支持关闭、最小化、最大化、还原  
  Supports close, minimize, maximize, restore  
- 自动适配 WPF / WinForms 宿主  
  Auto-detects WPF / WinForms hosts  
- 与 Blazor 页面自然集成  
  Seamless Blazor integration  
- 可与自定义标题栏配合使用  
  Ideal for custom title bar UIs

---

## 📦 安装 | Installation

使用 NuGet：

```bash
dotnet add package JiuLing.TitleBarKit
```

## ⚙️ 快速使用 | Quick Start

### 注册服务
```c#
// WinForms
serviceCollection.AddWinFormsTitleBar();
// WPF
serviceCollection.AddWpfTitleBar();
```

### 注入服务
* `Blazor` 程序
```razor
@inject TitleBarService TitleBarService
```

* 原生 `Windows` 程序
```c#
public MyComponent(TitleBarService titleBarService)
{
    _titleBarService = titleBarService;
}
```

### 调用功能
```c#
TitleBarService.Draggable.DragMove();

TitleBarService.TitleBar.Minimize();
TitleBarService.TitleBar.Maximize();
TitleBarService.TitleBar.Restore();
TitleBarService.TitleBar.ToggleMaximize();
TitleBarService.TitleBar.Close();
```

## 💡 示例 | Example (Blazor)
```razor
<div class="custom-title-bar">
    <div class="title-content" @onmousedown="() => TitleBarService.Draggable.DragMove()">
        <span class="title-text">WPF Blazor Web 组件</span>
    </div>
    <div class="title-buttons">
        <button @onclick="() => TitleBarService.TitleBar.Minimize()" class="btn">_</button>
        <button @onclick="() => TitleBarService.TitleBar.ToggleMaximize()" class="btn">🗖</button>
        <button @onclick="() => TitleBarService.TitleBar.Close()" class="btn">X</button>
    </div>
</div>
```

## 💻 支持平台 | Supported Platforms

| 平台 Platform | 支持 Supported |
|---------------|----------------|
| WPF           | ✅             |
| WinForms      | ✅             |
| BlazorHybrid  | ✅             |