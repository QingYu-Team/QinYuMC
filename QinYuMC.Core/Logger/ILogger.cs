namespace QinYuMC.Core.Logger;

public interface ILogger
{

    public event Action<string> OnLog;
    public event Action FatalTriggered;

    public void Trace(string module, string message);
    public void Trace(Exception? ex, string module, string message);

    public void Debug(string module, string message);
    public void Debug(Exception? ex, string module, string message);

    public void Info(string module, string message);
    public void Info(Exception? ex, string module, string message);

    public void Warning(string module, string message);
    public void Warning(Exception? ex, string module, string message);

    public void Error(string module, string message);
    public void Error(Exception? ex, string module, string message);

    public void Fatal(string module, string message);
    public void Fatal(Exception? ex, string module, string message);
}