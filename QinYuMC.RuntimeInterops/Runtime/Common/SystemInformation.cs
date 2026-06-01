using System.Runtime.InteropServices;
using QinYuMC.RuntimeInterops.Runtime.Abstractions;
using QinYuMC.RuntimeInterops.Runtime.Android;
using QinYuMC.RuntimeInterops.Runtime.Linux;
using QinYuMC.RuntimeInterops.Runtime.MacOs;
using QinYuMC.RuntimeInterops.Runtime.Windows;

namespace QinYuMC.RuntimeInterops.Runtime.Commom;

public static class SystemInformation
{
    private static INativeInvoker? _invoker;

    public static void Initiaize()
    {
        if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) 
            _invoker = WindowsNativeInvoker.Instance;
        else if(RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            _invoker = LinuxNativeInvoker.Instance;
        else if(RuntimeInformation.IsOSPlatform(OSPlatform.Create("Android"))) 
            _invoker = AndroidNativeInvoker.Instance;
        else if(RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            _invoker = MacOsNativeInvoker.Instance;

    }

    public static bool TryGetOSVersion(out Version? version) => _invoker!.TryGetOSVersion(out version); 
}