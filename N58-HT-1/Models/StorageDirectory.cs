using N58_HT_1.Enums;

namespace N58_HT_1.Models;

public class StorageDirectory: IStorageInfo
{
    public string Name { get; set; }
    public string Path { get; set; }
    public int ItemsCount { get; set; }
    public StorageType Type { get; set; } = StorageType.Directory;



}
