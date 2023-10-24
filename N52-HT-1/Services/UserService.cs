using N52_HT_1.Models;

namespace N52_HT_1.Services;

public class UserService
{
    private readonly List<User> _users = new List<User>();
    public List<User> Get() => _users;
    public User Create(User user)
    {
        _users.Add(user);
        return user;
    }
    public User? GetById(Guid id) => _users.FirstOrDefault(us => us.Id == id);
    public User Update(User user)
    {
        var foundUser = _users.FirstOrDefault(us => us.Id == user.Id);
        if (foundUser is null)
            return null;
        foundUser.FirstName = user.FirstName;
        foundUser.LastName = user.LastName;
        foundUser.Email = user.Email;
        return foundUser;
    }
    public User? Delete(Guid id)
    {
        var user = GetById(id);
        if (user is null)
            return null;
        _users.Remove(user);
        return user;

    }
    
}
