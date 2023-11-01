using N66_HT_1.Models.Entities;

namespace N66_HT_1.Services.Interfaces;

public interface IBookService
{
    IQueryable<Book> Get();
    ValueTask<Book> GetByIdAsync(Guid id);
    ValueTask<IEnumerable<Book>> GetByAuthorIdAsync(Guid authorId);
    ValueTask<Book> CreatAsync(Book book);
    ValueTask<Book> UpdateAsync(Book book);
    ValueTask<Book> DeleteAsync(Guid id);
}
