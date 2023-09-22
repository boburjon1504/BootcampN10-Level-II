
using System.Text;

namespace N43_HT_1.Services;

public class PerformanceService
{
    private readonly EmployeeService _employeeService;
    public PerformanceService(EmployeeService employeeService) => _employeeService = employeeService;
    public async ValueTask<FileStream> ReportPerformanceAsync(Guid id)
    {
        var file = await _employeeService.CreatePerformanceRecordAsync(id);
        var mutex = new Mutex(false, "UserFile");
        return await Task.Run(() =>
        {
            mutex.WaitOne();
            file.Write(Encoding.UTF8.GetBytes("Hello you are so good"));
            file.Close();
            mutex.ReleaseMutex();
            return file;
        });
    }
}
