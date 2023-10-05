using OnlineMarket_50.Models;

namespace OnlineMarket_50.Services.Interfaces;

public interface IOrderService
{
    Order Create(Order user);
    Order Update(Order user);
    Order GetById(Guid id);
    List<Order> GetAll();
    Order Delete(Guid id);
}
