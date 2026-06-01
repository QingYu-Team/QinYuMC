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
    public void Unregister(string path);

    
}