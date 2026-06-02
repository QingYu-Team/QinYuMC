using QinYuMC.Core.Utils;

namespace QinYuMC.Core.Instance.Assembly;

public interface IAssemblyHandler
{
    /// <summary>
    /// 获取该附加组件的文件列表
    /// </summary>
    /// <returns></returns>
    public IEnumerable<FileData> GetAssemblyFiles();
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public object GetAssemblyInformation();
}