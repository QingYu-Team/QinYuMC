namespace QinYuMC.Core.Instance;

public record AssemblyInfo
{
    #if NET10_0_OR_GREATER
    
    public required string Name { get; set; }

    public required Version AssemblyVersion { get; set; }

    #else
    public string Name { get; set; }
    #endif
}