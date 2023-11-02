using N67HomeTask.Application.Common.Services;
using N67HomeTask.Domain.Entities;
using N67HomeTask.Persistence.DataAccess;

namespace N67HomeTask.Infrastructure.Common.Services;


public class UserService:IUserService
{
    private readonly AppDataContext _dbContext;

    public UserService(AppDataContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async ValueTask<User> Create(User user)
    {
        await _dbContext.AddAsync(user);

        await _dbContext.SaveChangesAsync();

        return user;
    }

    public IQueryable<User> Get()
    {
        return _dbContext.Users;
    }

    public IQueryable<User> Get(IEnumerable<Guid> ids)
    {
        return _dbContext.Users.Where(user => ids.Contains(user.Id));
    }

    public ValueTask<User> GetById(Guid id)
    {
        return new(_dbContext.Users.FirstOrDefault(x => x.Id == id));
    }
}
