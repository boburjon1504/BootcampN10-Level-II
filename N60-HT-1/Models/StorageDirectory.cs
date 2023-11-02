using N60_HT_1.Enum;

namespace N60_HT_1.Models;

public class StorageDirectory : IStorageInfo
{
    public string Name { get; set; } = default!;
    public string Path { get; set; } = default!;
    public int ItemsCount { get; set; }
    public StorageType Type { get; set; } = StorageType.Directory;
}
