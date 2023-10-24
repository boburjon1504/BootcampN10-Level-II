using Mapster;
using N62_Task1.DTOs;
using N62_Task1.Model;
using System.Reflection.Metadata;

namespace N62_Task1.Service;

public class UserService
{
    private readonly List<User> _users = new List<User>();

    public User Create(User user)
    {
        _users.Add(user);
        return user;
    }
    public List<User> Get() => _users;

}
