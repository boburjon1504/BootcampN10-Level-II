using Mapster;
using N61_Task1.DTOs;
using N61_Task1.Entities;

namespace N61_Task1.Services;

public class UserService
{
    private readonly List<User> _users = new List<User>();

    public UserViewModel Create(UserForCreation user)
    {
        var newUser = _users.FirstOrDefault(us => us.Email.Equals(user.Email));
        if (newUser is not null)
        {
            Console.WriteLine("this user is already exists");
            return null;
        }
        var uss = user.Adapt<User>();
        uss.CreatedAt = DateTime.Now;


        return uss.Adapt<UserViewModel>();
    }
    public List<UserViewModel> GetUsers() =>
        _users.Adapt<List<UserViewModel>>();
}
