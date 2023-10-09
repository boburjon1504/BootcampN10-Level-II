using ToDoList.Common;

namespace ToDoList.Models;

public class ToDos:Entity
{
    public Guid UserId { get; set; }
    public string Name { get; set; }
}
