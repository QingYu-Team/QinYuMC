using System.Text;

namespace QinYuMC.Core.Utils.Exts;

public static class StringExtension
{
    public static byte[] GetBytes(this string str, Encoding? encode = null) => 
        (encode ?? Encoding.UTF8).GetBytes(str);
    
    #if NET10_0_OR_GREATER

    public static void GetBytes(this string str, Span<byte> space, Encoding? encode) =>
        (encode ?? Encoding.UTF8).GetBytes(str, space);
    #endif
}