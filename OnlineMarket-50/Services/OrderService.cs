using OnlineMarket_50.Models;
using OnlineMarket_50.Services.Interfaces;

namespace OnlineMarket_50.Services
{
    public class OrderService : IOrderService
    {
        private readonly List<Order> _orders;

        public OrderService(List<Order> orders)
        {
            _orders = orders;
        }

        public Order Create(Order order)
        {
            _orders.Add(order);
            return order;
        }

        public Order Delete(Guid id)
        {
            var order = _orders.FirstOrDefault(o => o.Id == id);
            _orders.Remove(order);
            return order;
        }

        public List<Order> GetAll() => _orders;

        public Order GetById(Guid id) => _orders.FirstOrDefault(orde => orde.Id == id);

        public Order Update(Order order)
        {
            var orderr = GetById(order.Id);
            orderr.Id = order.Id;
            orderr.UserId = order.UserId;
            return order;

        }
    }
}
