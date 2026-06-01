using System.Security.Cryptography;
using QinYuMC.Core.Utils.Exts;

namespace QinYuMC.Core.Utils.Hash;

public class Sha1Provider: IHashProvider
{
    public static Sha1Provider Instance = new();

    public byte[] ComputeHash(string text)
    {
        return ComputeHash(text.GetBytes());
    }

    public byte[] ComputeHash(byte[] data)
    {
        using var sha1 = SHA1.Create();
        return sha1.ComputeHash(data);
    }

    public byte[] ComputeHash(Stream stream)
    {
        using var sha1 = SHA1.Create();
        return sha1.ComputeHash(stream);
    }

    public byte[] ComputeHash(FileInfo info)
    {
        using var stream = new FileStream(info.FullName, FileMode.Open, FileAccess.Read, FileShare.Read, 16384, true);
        return ComputeHash(stream);
    }

    public async Task<byte[]> ComputeHashAsync(Stream stream, CancellationToken? token = null)
    {
        using var sha1 = SHA1.Create();
        return await sha1.ComputeHashAsync(stream, token ?? CancellationToken.None);
    }

    public Task<byte[]> ComputeHashAsync(FileInfo info, CancellationToken? token = null)
    {
        using var stream = new FileStream(info.FullName, FileMode.Open, FileAccess.Read, FileShare.Read, 16384, true);
        return ComputeHashAsync(stream, token);
    }
}