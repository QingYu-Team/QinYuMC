namespace QinYuMC.App.Models.Core.Runtime;

[Flow.Scope("dependency")]
public class DependencyInjectionService
{
    [Flow.Run(After = "app:init", Before = "*:loading")]
    [Flow.Task("initialize")]
    public static partial void Initialize()
    {
        
    }
}