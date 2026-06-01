using QinYuMC.RuntimeInterops.Runtime.Abstractions;

namespace QinYuMC.RuntimeInterops.Runtime.Windows;

public class WindowsNativeInvoker: INativeInvoker
{
    public static WindowsNativeInvoker Instance = new();

    public bool TryGetOSVersion(out Version? version)
    {
        version = null;
        try
        {
            Ntdll.RtlGetNtVersionNumbers(out var major,out var minor,out var build);
            version = new Version($"{major}.{minor}.{build}");
            return true;
        }
        catch
        {
            // ignore exception
        }
        return false;
    }
}