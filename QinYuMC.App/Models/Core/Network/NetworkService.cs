namespace QinYuMC.App.Models.Core.Network;

[Flow.Scope("network")]
public partial class NetworkService
{
    [Flow.Task("initialize")]
    [Flow.Run(After = "logger:loading", Before = "update:check", Priority = 0)]
    public static partial void Initialize()
    {
        return;
    }
}