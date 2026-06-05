namespace QinYuMC.Core.Logger;

public class LogConfig
{
#if NET8_0_OR_GREATER
    
    public required string LogBasePath { get; set; }
    
#else

    public string LogBasePath { get; set; }

    public long MaxWritePreFile { get; set; }

    public 

    public DateTime OutdateAt { get; set; }


#endif
    
#if DEBUG
    public ConsoleOutputRules Rules = ConsoleOutputRules.Default;
#else
    public ConsoleOutputRules Rules = ConsoleOutputRules.Ignore;
#endif
}