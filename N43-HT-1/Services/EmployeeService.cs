
namespace N43_HT_1.Services;

public class EmployeeService
{
    private readonly UserService _userService;
    public EmployeeService(UserService userService) => _userService = userService;
    public async ValueTask<FileStream> CreatePerformanceRecordAsync(Guid id)
    {
        var user = await _userService.GetById(id);
        var mutex = new Mutex(false, "UserFile");
        return await Task.Run(() =>
        {
            var file =  File.Open($"{user.FirstName}{user.LastName}.txt",FileMode.OpenOrCreate);
            return file;
        });

    }
}
