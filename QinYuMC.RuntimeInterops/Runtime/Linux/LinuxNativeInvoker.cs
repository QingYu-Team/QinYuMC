using QinYuMC.RuntimeInterops.Runtime.Abstractions;

namespace QinYuMC.RuntimeInterops.Runtime.Linux;

public class LinuxNativeInvoker: INativeInvoker
{
    public static LinuxNativeInvoker Instance = new();
    public bool TryGetOSVersion(out Version version)
    {
        throw new NotImplementedException();
    }
}