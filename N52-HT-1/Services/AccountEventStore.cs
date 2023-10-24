using N52_HT_1.Models;

namespace N52_HT_1.Services
{
    public class AccountEventStore
    {
        public event Func<User, string> OnUserCreated;
        public string CreateEvent(User user)
        {
            if (OnUserCreated != null)
                return OnUserCreated(user);
            return "The message was not sent";
        }
    }
}
