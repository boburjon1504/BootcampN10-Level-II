using OnlineMarket.DataContext;
using OnlineMarket.Models;
using OnlineMarket.Services.Interfaces;
using System.Runtime.CompilerServices;

namespace OnlineMarket.Services;

public class OrderService : IEntityService<Order>
{
    private readonly IDataContext _appDataContext;

    public OrderService(IDataContext appDataContext)
    {
        _appDataContext = appDataContext;
    }

    public async ValueTask<Order> CreateAsync(Order order)
    {
        await _appDataContext.Orders.AddAsync(order);

        return order;
    }

    public async ValueTask<Order> DeleteAsync(Guid id)
    {
        var deletedOrder = await GetByIdAsync(id);

        if (deletedOrder is null)
            return null;

        deletedOrder.IsDeleted = true;

        await _appDataContext.Orders.SaveChangesAsync();

        return deletedOrder;

    }

    public ValueTask<IEnumerable<Order>> GetAsync() => 
        new ValueTask<IEnumerable<Order>>(GetUndeletedOrders());

    public ValueTask<Order> GetByIdAsync(Guid id) =>
        new ValueTask<Order>(GetUndeletedOrders().FirstOrDefault(order => order.Id == id));

    public async ValueTask<Order> UpdateAsync(Order order)
    {
        var updatedOrder = await GetByIdAsync(order.Id);

        if (updatedOrder is null)
            return null;

        updatedOrder.UserId = order.UserId;
        updatedOrder.OrderedDate = order.OrderedDate;

        return updatedOrder;
    }

    private IQueryable<Order> GetUndeletedOrders() =>
        _appDataContext.Orders.Where(order => !order.IsDeleted).AsQueryable();
}
