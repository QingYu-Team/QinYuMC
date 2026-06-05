namespace QinYuMC.Core.Utils.Diff;

public interface IDiffProvider
{
    public void Apply(Stream old, Stream newData, Stream destination);
    public void Apply(string old, string newData, string destination);
    public void Make(Stream old, Stream newData, Stream destination);
    public void Make(string old, string newData, string destination);

    public bool IsSupportStream { get; }
}