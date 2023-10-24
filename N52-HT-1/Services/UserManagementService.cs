using N52_HT_1.Models;

namespace N52_HT_1.Services;

public class UserManagementService
{
    private readonly EmailSenderService _emailSenderService;
    private readonly UserService _userService;
    public UserManagementService(UserService userService, EmailSenderService emailSenderService)
    {
        _userService = userService;
        _emailSenderService = emailSenderService;
    }
    public List<User> Get() => _userService.Get();
    public string Create(User user)
    {
        _userService.Create(user);
        return _emailSenderService.Send(user);
    }
    public User? GetById(Guid id) => _userService.GetById(id);
    public User Update(User user)
    {
        _userService.Update(user);
        return user;
    }
    public User? Delete(Guid id)
    {
        return _userService.Delete(id);

    }
}

