using System.Diagnostics.CodeAnalysis;

namespace QinYuMC.RuntimeInterops.Runtime.Abstractions;

public interface INativeInvoker
{
    #if NET10_0_OR_GREATER
    public bool TryGetOSVersion([NotNullWhen(true)] out Version? version);
    #else
    public bool TryGetOSVersion(out Version? version);
    #endif
}