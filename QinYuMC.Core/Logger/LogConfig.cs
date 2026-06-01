namespace QinYuMC.Core.Logger;

public class LogConfig
{
    #if NET10_0_OR_GREATER
    
    public required string LogBasePath { get; set; }

    public required bool AllowOutputToConsole { get; set; }

    #else

    public string LogBasePath { get; set; }

    public bool AllowOutputToConsole { get; set; }
    
    #endif
}