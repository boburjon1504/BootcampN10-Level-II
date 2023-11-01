using N66_HT_1.Models.Entities;

namespace N66_HT_1.Services.Interfaces;

public interface IAuthorService
{
    IQueryable<Author> Get();
    ValueTask<Author> GetByIdAsync(Guid id);
    ValueTask<Author> CreatAsync(Author userForCreation);
    ValueTask<Author> UpdateAsync(Author user);
    ValueTask<Author> DeleteAsync(Guid id);
}
