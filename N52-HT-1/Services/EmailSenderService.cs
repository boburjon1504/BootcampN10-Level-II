using N52_HT_1.Models;

namespace N52_HT_1.Services
{
    public class EmailSenderService
    {
        private readonly AccountEventStore _accountEventStore;
        public EmailSenderService(AccountEventStore accountEventStore)
        {
            _accountEventStore = accountEventStore;
            _accountEventStore.OnUserCreated += Send;
        }

        public string Send(User user)
        {
            return $"Dear {user.FirstName} {user.LastName},\nYou have successfully registerated";
        }
    }
}
