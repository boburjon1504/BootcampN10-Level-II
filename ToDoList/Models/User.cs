using FileBaseContext.Abstractions.Models.Entity;
using FileBaseContext.Abstractions.Models.FileSet;
using ToDoList.Common;

namespace ToDoList.Models;

public class User:Entity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

}
