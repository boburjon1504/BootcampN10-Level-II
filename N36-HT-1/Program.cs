/* Person
- Employee
- Manager
 */

public record Person(string FirstName, string LastName, string MiddleName, string Age);

public record Employee(string FirstName, string LastName, string MiddleName, string Age, decimal Salary) : Person(FirstName, LastName, MiddleName, Age);
public record Manager(string FirstName, string LastName, string MiddleName, string Age, decimal Salary) : Person(FirstName, LastName, MiddleName, Age);