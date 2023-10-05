using OnlineMarket_50.Models;

namespace OnlineMarket_50.Services.Interfaces;

public interface IUserService
{
    User Create(User user);
    User Update(User user);
    User GetById(Guid id);
    List<User> GetAll();
    User Delete(Guid id);
}
