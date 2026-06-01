using System.Runtime.InteropServices;

namespace QinYuMC.RuntimeInterops.Runtime.Windows;

public static class Ntdll
{
    [DllImport("ntdll.dll", CharSet = CharSet.Auto)]
    internal static extern void RtlGetNtVersionNumbers(
        out uint major,
        out uint minor,
        out uint build
    );
}