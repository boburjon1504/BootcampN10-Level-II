using N63_HT_1.Models;

namespace N63_HT_1.Services;

public class StorageFileService
{
    public string UploadFile(StorageFile file)
    {
        var extension = new FileInfo(file.FormFile.FileName).Extension;
        var directory = Path.Combine(Directory.GetCurrentDirectory(), "UploadingFiles");
        Directory.CreateDirectory(directory);
        var fileName = Path.Combine(directory,$"IMG_{Guid.NewGuid()}{file.FormFile}.{extension}");
        var newFile = File.Open(fileName, FileMode.OpenOrCreate, FileAccess.Write);
        file.FormFile.CopyTo(newFile);
        return fileName;
    }
}
