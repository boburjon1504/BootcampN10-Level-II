namespace N54_HT_1;

public class FileService
{
    public string GetCurrentDirectory() => Directory.GetCurrentDirectory();
    public IEnumerable<string> GetFiles() => Directory.EnumerateFiles(GetCurrentDirectory(), "*",SearchOption.AllDirectories);
    public string GetMaxFileSize()
    {
        var allSize = GetFiles().Sum(fl =>
        {
            return new FileInfo(fl).Length;
        });
        var maxFileSize = GetFiles().Max(file =>
        {
            return new FileInfo(file).Length;
        });
        var maxFileName = Path.GetFileName(GetFiles().MaxBy(file =>
        {
            return new FileInfo(file).Length;
        }));
        return $"Current Directory : {GetCurrentDirectory()}\n" +
            $"Files count: {GetFiles().Count()}\n" +
            $"Files total size: {allSize} bayt\n" +
            $"Max file name: {maxFileName},\n" +
            $"Max file  size: {maxFileSize} ";
    }
}
