using N53_HT_1.Models;

namespace N53_HT_1.Event;

public class BonusEventStore
{
    public event Func<User, string, string> OnBonusCreated;
    public string CreateEvent(User user,string body)
    {
        if(OnBonusCreated != null)
            return OnBonusCreated(user,body);
        return "the message did not send";
    }
    
}
