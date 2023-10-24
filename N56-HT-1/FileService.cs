using System.Text.Json;

namespace N56_HT_1;

public class FileService
{
    private readonly UserService _userService;
    private readonly DirectoryService _directoryService;
    public FileService(UserService userService, DirectoryService directoryService)
    {
        _userService = userService;
        _directoryService = directoryService;
    }
    public void CreateUserProfileJson()
    {
        var rootPath = _directoryService.GetRootPath();
        
        var folders = Directory.EnumerateDirectories(rootPath,"*",SearchOption.AllDirectories);
        
        foreach (var user in _userService.Get())
        {
            var userFolder = folders
                .Where(folder => folder.Contains(user.Id.ToString()));

            var profile = userFolder.FirstOrDefault(fl => fl.Contains("profile", StringComparison.OrdinalIgnoreCase));
            var resume = userFolder.FirstOrDefault(fl => fl.Contains("resume", StringComparison.OrdinalIgnoreCase));
            if (profile is not null)
            {
                File.WriteAllText(Path.Combine(profile, $"{user.FirstName}{user.LastName}.json"),JsonSerializer.Serialize(user));
            }
            if(resume is not null)
            {
                File.WriteAllText(Path.Combine(resume, $"{user.FirstName}.txt"), $"Hello, my name is {user.FirstName}.\nI am good at computer science");

            }

        }
    }
}
