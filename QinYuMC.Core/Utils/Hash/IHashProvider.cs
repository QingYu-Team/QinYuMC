using QinYuMC.Core.Utils.Exts;

namespace QinYuMC.Core.Utils.Hash;

public interface IHashProvider
{
    /// <summary>
    /// 对给定文本同步计算 Hash
    /// </summary>
    /// <param name="text">文本</param>
    /// <returns>Hash</returns>
    public byte[] ComputeHash(string text);
    /// <summary>
    /// 对给定字节数组计算 Hash
    /// </summary>
    /// <param name="data">字节数组</param>
    /// <returns>Hash</returns>
    public byte[] ComputeHash(byte[] data);
    /// <summary>
    /// 对给定流同步计算 Hash
    /// </summary>
    /// <param name="stream">流</param>
    /// <returns></returns>
    public byte[] ComputeHash(Stream stream);
    /// <summary>
    /// 对给定文件同步计算 Hash
    /// </summary>
    /// <param name="info">文件</param>
    /// <returns>Hash</returns>
    public byte[] ComputeHash(FileInfo info);
    /// <summary>
    /// 对给定流异步计算 Hash
    /// </summary>
    /// <param name="stream">流</param>
    /// <param name="token">取消令牌</param>
    /// <returns></returns>
    public Task<byte[]> ComputeHashAsync(Stream stream, CancellationToken? token = null);
    /// <summary>
    /// 对给定文件异步计算 Hash
    /// </summary>
    /// <param name="info">文件</param>
    /// <param name="token">取消令牌</param>
    /// <returns>Hash</returns>
    public Task<byte[]> ComputeHashAsync(FileInfo info, CancellationToken? token = null);
}