using ToDoList.DataAccess;
using ToDoList.Models;
using ToDoList.Services.Interfaces;

namespace ToDoList.Services;

public class UserService : IEntityBaseService<User>
{
    private readonly IDataContext _dataContext;
    public UserService(IDataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public async ValueTask<User> CreateAsync(User user)
    {
        await _dataContext.Users.AddAsync(user);
        await _dataContext.Users.SaveChangesAsync();
        return user;
    }

    public async ValueTask<User> DeleteAsync(Guid id)
    {
        var deletedUser = await GetByIdAsync(id);

        if (deletedUser is null)
            return null;

        await _dataContext.Users.RemoveAsync(deletedUser);

        await _dataContext.Users.SaveChangesAsync();

        return deletedUser;

    }

    public IQueryable<User> Get()=>
        _dataContext.Users.AsQueryable();

    public ValueTask<User> GetByIdAsync(Guid id) =>
        new ValueTask<User>(_dataContext.Users.FirstOrDefault(u => u.Id == id));

    public async ValueTask<User> UpdateAsync(User user)
    {
        var updatedUser = await GetByIdAsync(user.Id);

        updatedUser.FirstName = user.FirstName;
        updatedUser.LastName = user.LastName;

        await _dataContext.Users.SaveChangesAsync();

        return updatedUser;
    }
}
