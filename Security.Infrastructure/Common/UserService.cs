using Mapster;
using Security.Application.Common.Services;
using Security.Domain.Dtos;
using Security.Domain.Entities;
using Security.Persistance.DataAccess;

namespace Security.Infrastructure.Common;

public class UserService : IUserService
{
    private readonly AppDbContext _dbContext;

    public UserService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IQueryable<User> Get() => _dbContext.Users.AsQueryable();

    public ValueTask<User> GetByIdAsync(Guid id) =>
        new ( _dbContext.Users.FirstOrDefault(user=>user.Id == id));
    public async ValueTask<User> CreateAsync(RegistrationDetails user)
    {
        var newUser = user.Adapt<User>();

        newUser.CreatedAt = DateTime.Now;
        newUser.ModifiedAt = DateTime.Now;
    
        await _dbContext.Users.AddAsync(newUser);

        await _dbContext.SaveChangesAsync();

        return newUser;
        
    }
    public ValueTask<User> UpdateAsync(RegistrationDetails user)
    {
        throw new NotImplementedException();
    }
    public async ValueTask<User> DeleteAsync(Guid id)
    {
        var deletingUser = await GetByIdAsync(id);

        if (deletingUser is null)
            throw new ArgumentNullException("Ther is no such user");

        _dbContext.Users.Remove(deletingUser);

    }


}
