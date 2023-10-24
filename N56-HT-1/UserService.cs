namespace N56_HT_1;

public class UserService
{
    private readonly List<User> _users = new List<User>();
    public List<User> Get() => _users;
    public User Create(User user)
    {
        _users.Add(user);
        return user;
    }
}
