using N60_HT_1.FilterModels;

namespace N60_HT_1.Services;

public class FileService
{
    public IEnumerable<string> GetFiles(StorageFilterModel filter)
    {
        var path = @"D:\BootcampN10-Level-II";
        var files = Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories);
        var file = new FileInfo(files.FirstOrDefault(fl => new FileInfo(fl).Extension is not null )).Extension;
        var filteredFiles = files
            .Where(file=>new FileInfo(file).Extension.Equals($".{filter.Extension}",StringComparison.OrdinalIgnoreCase));
        return filteredFiles;
    }
}
