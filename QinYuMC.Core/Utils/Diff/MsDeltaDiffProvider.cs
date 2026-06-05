namespace QinYuMC.Core.Utils.Diff;

public class MsDeltaDiffProvider: IDiffProvider
{
    public delegate void DeltaArgumentFile(string old, string newData, string destination);

    public static DeltaArgumentFile? ApplyDeltaCallback;

    public static DeltaArgumentFile? CreateDeltaCallback;

    public bool IsSupportStream => false;
}