using FileBaseContext.Abstractions.Models.FileSet;
using OnlineMarket.Models;

namespace OnlineMarket.DataContext;

public interface IDataContext:IAsyncDisposable
{
    IFileSet<User,Guid> Users { get; }
    IFileSet<Order,Guid> Orders { get; }
}
