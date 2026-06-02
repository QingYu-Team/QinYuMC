namespace QinYuMC.Core.Instance;

public interface IInstanceManage
{
    /// <summary>
    /// 注册一个游戏目录
    /// </summary>
    /// <param name="path"></param>
    public void RegisterFolder(string path);
    /// <summary>
    /// 取消注册一个游戏目录
    /// </summary>
    /// <param name="path"></param>
    public void UnregisterFolder(string path);
    /// <summary>
    /// 尝试创建一个实例，如果该实例已存在，则尝试加载信息
    /// </summary>
    public Task<InstanceInfo> CreateInstanceAsync();
    /// <summary>
    /// 检查是否存在同名实例
    /// </summary>
    /// <returns></returns>
    public bool Exist();

    /// <summary>
    /// 已注册的实例列表存在文件更改
    /// </summary>
    public event Action FolderFileChange;
    /// <summary>
    /// 删除一个实例
    /// </summary>
    /// <returns></returns>
    public Task DeleteAsync();
    
    public void LaunchAsync();
}