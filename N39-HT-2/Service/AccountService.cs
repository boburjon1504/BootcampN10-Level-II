
using System.Text.RegularExpressions;

namespace N39_HT_2.Service;

public class AccountService
{
    private readonly EmailSenderService _emailSenderService;
    private readonly List<string> _emails;
    public AccountService()
    {
        _emailSenderService = new EmailSenderService();
        _emails = new List<string>();
    }
    public void Register(string email, string password)
    {
        if (IsValidEmail(email))
            throw new ArgumentException(nameof(email));
        if (IsUniqueEmail(email))
            throw new Exception(nameof(email));
        if(!_emailSenderService.SendEmail(email))
            throw new InvalidOperationException(nameof(email));
    }
    private bool IsValidEmail(string email) =>
        Regex.IsMatch(email, @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b");
    private bool IsUniqueEmail(string emailAddress) =>
        _emails.Any(email => email.Equals(emailAddress));
}
