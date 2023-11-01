using Microsoft.AspNetCore.Authorization;
using N66_HT_1.Models.Entities;
using N66_HT_1.Persistence.DataAccess;
using N66_HT_1.Services.Interfaces;

namespace N66_HT_1.Services;

public class AuthorService : IAuthorService
{
    private readonly AppDataContext _dbContext;

    public AuthorService(AppDataContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IQueryable<Author> Get() => _dbContext.Authors;

    public ValueTask<Author> GetByIdAsync(Guid id) => 
        new ValueTask<Author>(_dbContext.Authors.FirstOrDefault(author => author.Id == id));
   
    public async ValueTask<Author> CreatAsync(Author author)
    {
        await _dbContext.Authors.AddAsync(author);

        await _dbContext.SaveChangesAsync();

        return author;
    }
    public async ValueTask<Author> UpdateAsync(Author author)
    {
        var updatingAuthor = await GetByIdAsync(author.Id);
        if (updatingAuthor is null)
            return null;
        updatingAuthor.FirstName = author.FirstName;
        updatingAuthor.LastName = author.LastName;

        await _dbContext.SaveChangesAsync();

        return updatingAuthor;
    }
    public async ValueTask<Author> DeleteAsync(Guid id)
    {
        var deletingAuthor = await GetByIdAsync(id);

        if (deletingAuthor is null)
            return null;
        _dbContext.Authors.Remove(deletingAuthor);

        await _dbContext.SaveChangesAsync();

        return deletingAuthor;
    }
}
