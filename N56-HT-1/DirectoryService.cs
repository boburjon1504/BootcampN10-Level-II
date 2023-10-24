using System.Security.Cryptography.X509Certificates;

namespace N56_HT_1;

public class DirectoryService
{

    private readonly UserService _userService;
    public DirectoryService(UserService userService)
    {
        _userService = userService;
    }
    public string GetRootPath() {
      var storage = Directory.CreateDirectory("Storage").FullName;
        return Directory.CreateDirectory(Path.Combine(storage, "User")).FullName;
    }
    public void CreateDirectories()
    {
        var users = _userService.Get();
        foreach(var user in users)
        {
            var userDirectory = Path.Combine(GetRootPath(), user.Id.ToString());
            Directory.CreateDirectory(userDirectory);
            Directory.CreateDirectory(Path.Combine(userDirectory, "Profile"));
            Directory.CreateDirectory(Path.Combine(userDirectory, "Resume"));
        }
    }

}
