using FileBaseContext.Abstractions.Models.FileSet;
using ToDoList.Models;

namespace ToDoList.DataAccess
{
    public interface IDataContext:IAsyncDisposable
    {
        IFileSet<User,Guid> Users { get; }
        IFileSet<ToDos,Guid> ToDoss { get; }
    }
}
