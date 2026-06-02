using System.Collections.Concurrent;

namespace QinYuMC.Core.Logger;

public class Logger: ILogger
{


    public Logger(LogConfig config)
    {
        AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
        {
            if (args.IsTerminating)
                Fatal(
                    (Exception?)args.ExceptionObject,
                    "System", "引发了未经处理的异常");
            else
            {
                Error((Exception ?)args.ExceptionObject,
                "System", "引发了未经处理的异常");
            }
        };
        TaskScheduler.UnobservedTaskException += (sender, args) =>
        {
            Error(args.Exception, "System", "引发了未经处理的异步任务异常");
            args.SetObserved();
        };
    }

    #if NET8_0_OR_GREATER
    
    #endif

    private ConcurrentQueue<string> _log = new();

    private void _Log(string message) => _log.Enqueue(message);

    private void _Log(LogLevel level, string module, string message) => _Log(
        $"[{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff")}]"
        + $"[{level switch {
            LogLevel.Trace => "TRE",
            LogLevel.Debug => "DBG",
            LogLevel.Info => "INFO",
            LogLevel.Warning => "WARN",
            LogLevel.Error => "ERR!",
            LogLevel.Fatal => "FTL!",
            _ => "UKN!"
        }}]: <{module}> {message}");

    private void _Log(Exception? ex, LogLevel level, string module, string message) =>
        _Log(
            level,
            module,
            $"{message} : {ex}");

    public void Trace(string module, string message) => _Log(LogLevel.Trace, module, message);
    public void Trace(Exception? ex, string module, string message) => _Log(ex, LogLevel.Trace, module, message);

    public void Debug(string module, string message) => _Log(LogLevel.Debug, module, message);
    public void Debug(Exception? ex, string module, string message) => _Log(ex, LogLevel.Debug, module, message);

    public void Info(string module, string message) => _Log(LogLevel.Info, module, message);
    public void Info(Exception? ex, string module, string message) => _Log(ex, LogLevel.Info, module, message);

    public void Warning(string module, string message) => _Log(LogLevel.Warning, module, message);
    public void Warning(Exception? ex, string module, string message) => _Log(ex, LogLevel.Warning, module, message);

    public void Error(string module, string message) => _Log(LogLevel.Error, module, message);
    public void Error(Exception? ex, string module, string message) => _Log(ex, LogLevel.Error, module, message);

    public void Fatal(string module, string message) => _Log(LogLevel.Fatal, module, message);
    public void Fatal(Exception? ex, string module, string message) => _Log(ex, LogLevel.Fatal, module, message);
}
