using N67HomeTask.Domain.Entities;

namespace N67HomeTask.Application.Common.Services;

public interface IUserService
{
    public IQueryable<User> Get();
    public IQueryable<User> Get(IEnumerable<Guid> ids);
    public ValueTask<User> GetById(Guid id);
    public ValueTask<User> Create(User user);

}
