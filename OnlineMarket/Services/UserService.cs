using OnlineMarket.DataContext;
using OnlineMarket.Models;
using OnlineMarket.Services.Interfaces;

namespace OnlineMarket.Services;

public class UserService : IEntityService<User>
{
    private readonly IDataContext _appDataContext;
    public UserService(IDataContext appDataContext)
    {
        _appDataContext = appDataContext;
    }

    public async ValueTask<User> CreateAsync(User user)
    {
        await _appDataContext.Users.AddAsync(user);
 
        await _appDataContext.Users.SaveChangesAsync();

        return user;
    }

    public async ValueTask<User> DeleteAsync(Guid id)
    {
        var deletedUser = await GetByIdAsync(id);

        if (deletedUser is null)
            return null;
        
        deletedUser.IsDeleted = true;

        await _appDataContext.Users.SaveChangesAsync();

        return deletedUser;


    }

    public ValueTask<IEnumerable<User>> GetAsync() =>
        new ValueTask<IEnumerable<User>>(GetUndeletedUsers());

    public async ValueTask<User> GetByIdAsync(Guid id) =>
        _appDataContext.Users.FirstOrDefault(us => us.Id == id);

    public async ValueTask<User> UpdateAsync(User user)
    {
        var updatedUser = await GetByIdAsync(user.Id);

        if (user is null)
            return null;

        updatedUser.Name = user.Name;

        await _appDataContext.Users.SaveChangesAsync(); 

        return updatedUser;
    }
    private IQueryable<User> GetUndeletedUsers() =>
        _appDataContext.Users.Where(user => !user.IsDeleted).AsQueryable();

}
