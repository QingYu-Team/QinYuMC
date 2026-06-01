using System;
using System.Diagnostics.CodeAnalysis;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using QinYuMC.App.ViewModels;

namespace QinYuMC.App;

/// <summary>
/// Given a view model, returns the corresponding view if possible.
/// </summary>
#if NET10_0_OR_GREATER
[RequiresUnreferencedCode(
    "Default implementation of ViewLocator involves reflection which may be trimmed away.",
    Url = "https://docs.avaloniaui.net/docs/concepts/view-locator")]
#endif
public class ViewLocator : IDataTemplate
{
    public Control? Build(object? param)
    {
        if (param is null)
            return null;
        #if NET10_0_OR_GREATER
        var name = param.GetType().FullName!.Replace("ViewModel", "View", StringComparison.Ordinal);
        #else
        var name = param.GetType().FullName!.Replace("ViewModel", "View");
        #endif
        var type = Type.GetType(name);

        if (type != null)
        {
            return (Control)Activator.CreateInstance(type)!;
        }
        
        return new TextBlock { Text = "Not Found: " + name };
    }

    public bool Match(object? data)
    {
        return data is ViewModelBase;
    }
}
