namespace N56_HT_1;

public class CleanUpService
{
    private readonly DirectoryService _directoryService;
    public CleanUpService(DirectoryService directoryService)
    {
        _directoryService = directoryService;
    }

    public void CLean()
    {
        var files = Directory.GetFiles(_directoryService.GetRootPath(), "*", SearchOption.AllDirectories);
        foreach (var file in files)
        {
            var fl = new FileInfo(file);
            if (fl.Length < 6 * 1024)
            {
                File.Delete(file);
            }
        }
    }
}
