namespace QinYuMC.Core.Logger;

public enum ConsoleOutputRules
{
    /// <summary>
    /// 默认
    /// </summary>
    Default,
    /// <summary>
    /// 重定向到标准输出
    /// </summary>
    RedirectToStandardOutput,
    /// <summary>
    /// 重定向到标准错误
    /// </summary>
    RedirectToStandardError,
    /// <summary>
    /// 忽略控制台输出
    /// </summary>
    Ignore
}