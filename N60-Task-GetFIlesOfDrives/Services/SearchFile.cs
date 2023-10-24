namespace N60_Task_GetFIlesOfDrives.Services;

public class SearchFile
{
    public string Search(string path,string fileName)
    {
        var directories = Directory.GetDirectories(path,"*",SearchOption.TopDirectoryOnly);
        for(var i=0;i<directories.Length;i++)
        {
            if (!directories[i].Equals("D:\\System Volume Information") ||
                !directories[i].Equals("'C:\\Documents and Settings"))
            {
                var fileNamee = SearchFilee(directories[i], fileName);
                if (fileNamee is not null)
                    return fileNamee;
            }
        }
        return $"There is no such file with name {fileName}";
    }
    public string SearchFilee(string path,string fileName)
    {
        var files = Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories);
        var needFile = files
            .FirstOrDefault(fl => Path.GetFileName(fl).Equals(fileName, StringComparison.OrdinalIgnoreCase));
        return needFile;
    }
}
