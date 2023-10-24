using N53_HT_1.Event;
using N53_HT_1.Models;

namespace N53_HT_1.Services;

public class BonusService
{

    private readonly OrderEventStore _orderEventStore;
    private readonly UserService _userService;
    private readonly List<Bonus> _bonus = new List<Bonus>();
    private readonly BonusEventStore _bonusEventStore;
    public BonusService(OrderEventStore orderEventStore, BonusEventStore bonusEventStore, UserService? userService)
    {
        _userService = userService;
        _orderEventStore = orderEventStore;
        _bonusEventStore = bonusEventStore;
        _orderEventStore.OnOrderCreated += Notify;
        _bonusEventStore.OnBonusCreated += Notify;
    }
    public string SaveBonus(Order order)
    {
        var user = _userService.GetById(order.UserId);
        if (user is null)
            return "there is no such user";
        var existsBonus = GetById(user.BonusId);
        if (existsBonus is null)
        {
            var newBonus = Create(new Bonus
            {
                Amount = order.Amount * 0.5,
                Id = Guid.NewGuid(),
            });
            return _bonusEventStore.CreateEvent(user, $"Dear {user.FirstName} {user.LastName},\nYou have obtained {newBonus.Amount}$ bonus");
        }
        else
        {
            var oldCount = CountDigits(existsBonus.Amount.ToString());
            existsBonus.Amount += order.Amount * 0.5;
            if (oldCount == CountDigits(existsBonus.Amount.ToString()))
                return _orderEventStore.CreateEvent(user, $"Dear {user.FirstName} {user.LastName},\nYou have got {existsBonus.Amount}$ bonus." +
                    $"Till {GetNextBonus(existsBonus.Amount, oldCount)}" +
                    $", you have to earn {GetNextBonus(existsBonus.Amount, oldCount) - existsBonus.Amount}\n ");
            else
                return _bonusEventStore.CreateEvent(user, $"Dear {user.FirstName} {user.LastName},\n" +
                    $"You hava gathered {order.Amount * 0.5}$, now your bonus grow from {existsBonus.Amount - order.Amount * 0.5} to" +
                    $"{existsBonus}, you have great");
        }
    }
    public string Notify(User user, string body)
    {
        return body;
    }
    private double GetNextBonus(double amount, int countOfDigits) =>
        ((int)(amount / Math.Pow(10, countOfDigits - 1) + 1)) * Math.Pow(10, countOfDigits - 1);

    public Bonus GetById(Guid id) =>
        _bonus.FirstOrDefault(bonus => bonus.Id == id);
    
    public Bonus Create(Bonus bonus)
    {
        _bonus.Add(bonus);
        return bonus;
    }
    
    private int CountDigits(string amount)
    {
        if (amount.Contains('.'))
            return amount.Split('.')[0].Length;
        return amount.Length;
    }

}
