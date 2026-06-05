using Avalonia;
using Avalonia.Threading;
using System;

namespace QinYuMC.App;

[Flow.Scope("app")]
sealed partial class Program
{
    public static string CurrentFolder { get; private set;} = null!;
    [Flow.Task("init")]
    public static void StartLoading()
    {
        CurrentFolder = Environment.CurrentDirectory;
    }


    public static void Main(string[] args)
    {
        Task.Run(async () =>
        {
            await FlowInterops.Initialize("app:init");
        });
        StartApplication(args);
    }

    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
    // yet and stuff might break.
    [STAThread]
    public static void StartApplication(string[] args) => BuildAvaloniaApp()
        .StartWithClassicDesktopLifetime(args);

    // Avalonia configuration, don't remove; also used by visual designer.
    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
#if DEBUG
            //.WithDeveloperTools()
#endif
            .WithInterFont()
            .LogToTrace();

}
