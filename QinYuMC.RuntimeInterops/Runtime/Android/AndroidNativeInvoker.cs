using QinYuMC.RuntimeInterops.Runtime.Abstractions;

namespace QinYuMC.RuntimeInterops.Runtime.Android;

public class AndroidNativeInvoker: INativeInvoker
{
    public static AndroidNativeInvoker Instance = new();
    public bool TryGetOSVersion(out Version version)
    {
        throw new NotImplementedException();
    }
}