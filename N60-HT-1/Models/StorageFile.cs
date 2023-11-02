using N60_HT_1.Enum;

namespace N60_HT_1.Models;

public class StorageFile : IStorageInfo
{
    public string Name { get; set; } = default!;
    public string Path { get; set; } = default!;
    public string Extension { get; set; } = default!;
    public string Directory { get; set; } = default!;
    public long Size { get; set; }
    public StorageType Type { get; set; } = StorageType.File;
    
}
