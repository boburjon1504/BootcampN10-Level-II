using N58_HT_1.Enums;
using N58_HT_1.Models;

namespace N58_HT_1.Service;

public class WebBroker
{
    private readonly IWebHostEnvironment _environtment;

    public WebBroker(IWebHostEnvironment environment)
    {
        _environtment = environment;
    }
    public IEnumerable<StorageFile> GetFiles()
    {
        var path = _environtment.WebRootPath;
        return Directory.EnumerateFiles(path,"*", SearchOption.AllDirectories)
            .Select(fl=>
            {
                return new FileInfo(fl);
            }).Select(fl=>new StorageFile
            {
                Name = fl.Name,
                Path = fl.FullName,
                Size = fl.Length,
                Extension = fl.Extension,
                Type = StorageType.File,
            });
    }
    public IEnumerable<StorageDirectory> GetDirectories()
    {
        var path = _environtment.WebRootPath;
        return Directory.EnumerateDirectories(path)
            .Select(fl =>
            {
                return new DirectoryInfo(fl);
            }).Select(fl => new StorageDirectory
            {
                Name = fl.Name,
                Path = fl.FullName,
                ItemsCount = fl.EnumerateFileSystemInfos().Count(),
                Type = StorageType.File,
            }) ;
    }
}
