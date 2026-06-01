using QinYuMC.RuntimeInterops.Runtime.Abstractions;

namespace QinYuMC.RuntimeInterops.Runtime.MacOs;

public class MacOsNativeInvoker: INativeInvoker
{
    public static MacOsNativeInvoker Instance = new();
    public bool TryGetOSVersion(out Version version)
    {
        throw new NotImplementedException();
    }
}