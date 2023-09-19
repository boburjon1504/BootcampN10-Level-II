
using N41_Task2.Models;

namespace N41_Task2.Services;

public class EmployeeService
{
    public readonly List<Employee> Employees = new();

    public Employee? GetByEmail(string emailAddress)
    {
        Thread.Sleep(5000);
        return Employees.FirstOrDefault(employee => employee.EmailAddress == emailAddress);
    }

    public void Add(Employee employee)
    {

            Employees.Add(employee);
        
    }
}
