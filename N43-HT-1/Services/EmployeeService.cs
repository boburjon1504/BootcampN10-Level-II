
namespace N43_HT_1.Services;

public class EmployeeService
{
    private readonly UserService _userService;
    public EmployeeService(UserService userService) => _userService = userService;
    public async void CreatePerformanceRecordAsync(Guid id)
    {
        var user = await _userService.GetById(id);
        var mutex = new Mutex(false, "UserFile");
        await Task.Run(() =>
        {
            mutex.WaitOne();
           var file =  File.Create($"{user.FirstName}{user.LastName}.txt");
            file.Close();
            mutex.ReleaseMutex();
        });

    }
}
