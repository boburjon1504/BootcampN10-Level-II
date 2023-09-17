using N40_Task2.Model;
namespace N40_Task2.Service;

public class AccountService
{
    private List<User> _users = new();
    private List<Email> _emails = new();

    public void Register(string emailAddress, string password)
    {
        if (!IsValid(emailAddress))
            throw new ArgumentException($"Invalid user info {nameof(emailAddress)}");
        if (!IsValid(password)) throw new ArgumentException("Password");
        if (!IsUnique(emailAddress)) throw new ArgumentException("This email already exists");
        var newUser = new User { Email = emailAddress, Password = password };
        _users.Add(newUser);
    }
    private bool IsValid(string emailAddress) => string.IsNullOrWhiteSpace(emailAddress);
    private bool IsUnique(string emailAddress) => !_users.Any(user => user.Email.Equals(emailAddress));

}