namespace QinYuMC.Core.Utils.Exts;

public static class ByteExtension
{
    public static string ToHexString(this byte[] data) => Convert.ToHexString(data);
}