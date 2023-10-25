using N58_HT_1.Enums;

namespace N58_HT_1.Models;

public class StorageFile : IStorageInfo
{
    public string Name { get; set ; }
    public string Path { get; set ; }
    public string Extension { get; set ; }
    public long Size { get; set ; }
    public StorageType Type { get; set ; } = StorageType.File;

}
