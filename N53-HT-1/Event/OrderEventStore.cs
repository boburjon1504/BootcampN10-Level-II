using N53_HT_1.Models;

namespace N53_HT_1.Event;

public class OrderEventStore
{
    public event Func<User,string, string> OnOrderCreated;
    public string CreateEvent(User user,string body)
    {
        if (OnOrderCreated != null)
            return OnOrderCreated(user, body);
        return "The message did not send ";
    }
}
