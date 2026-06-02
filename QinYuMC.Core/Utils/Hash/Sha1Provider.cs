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
        token ??= CancellationToken.None;
        using var sha1 = SHA1.Create();
#if NET8_0_OR_GREATER
        return await sha1.ComputeHashAsync(stream, token).ConfigureAwait(false);
#else
        var data = new byte[16384];
        while (true)
        {
            token.Value.ThrowIfCancellationRequested();
            var readed = await stream.ReadAsync(data, 0, data.Length, token.Value).ConfigureAwait(false);
            if (readed == 0) break;
            sha1.TransformBlock(data, 0, readed, null, 0);

        }
        sha1.TransformFinalBlock(Array.Empty<byte>(), 0, 0);
        return sha1.Hash;
#endif
    }

    public async Task<byte[]> ComputeHashAsync(FileInfo info, CancellationToken? token = null)
    {
        using var stream = new FileStream(info.FullName, FileMode.Open, FileAccess.Read, FileShare.Read, 16384, true);
        return await ComputeHashAsync(stream, token).ConfigureAwait(false);
    }
}