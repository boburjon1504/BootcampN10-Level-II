using FileBaseContext.Abstractions.Models.Entity;

namespace ToDoList.Common;

public class Entity : IFileSetEntity<Guid>
{
    public Guid Id { get; set; }
}
