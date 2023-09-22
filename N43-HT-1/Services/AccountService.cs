using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N43_HT_1.Services
{
    public class AccountService
    {
        private readonly UserService _userService;
        public AccountService(UserService userService)=>_userService = userService;
        public async ValueTask<FileStream> CreateReportAsync(Guid id)
        {
            var employeeService = new EmployeeService(_userService);
            var performanceService = new PerformanceService(employeeService);
            return await performanceService.ReportPerformanceAsync(id);
        }
    }
}
