using Microsoft.AspNetCore.Identity;
using OnlineMarket_50.Models;
using OnlineMarket_50.Services.Interfaces;

namespace OnlineMarket_50.Services;

public class UserService : IUserService
{
    private readonly List<User> _users;

    public UserService(List<User> users)
    {
        _users = users;
    }

    public User Create(User user)
    {
        _users.Add(user);
        return user;
    }

    public User Delete(Guid id)
    {
        var user = GetById(id);

        if (user is null)
            return null;

        _users.Remove(user);

        return user;
    }

    public List<User> GetAll() => _users;

    public User GetById(Guid id) =>
        _users.FirstOrDefault(user => user.Id == id);


    public User Update(User user)
    {
        var userr = GetById(user.Id);
        userr.Name = user.Name;

        return userr;

    }

}
