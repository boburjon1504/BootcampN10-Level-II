
using N41_Task2.Models;

namespace N41_Task2.Services;

public class AccountService
{
    private readonly EmployeeService _employeeService;

    public AccountService(EmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    public ValueTask RegisterAsync(string emailAddress)
    {
        lock (this)
        {
            var foundEmployee = _employeeService.GetByEmail(emailAddress);

            if (foundEmployee is not null)
            {
                Console.WriteLine("duplicate entry");
                return new ValueTask(Task.CompletedTask);
                // throw new DuplicateEntryException($"{nameof(Employee)} with this email address already exits.");
            }


            var employee = new Employee
            {
                EmailAddress = emailAddress
            };
            _employeeService.Add(employee);
        }

        return new ValueTask(Task.CompletedTask);
    }
}