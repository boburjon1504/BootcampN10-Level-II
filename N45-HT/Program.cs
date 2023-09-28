using System.Diagnostics;
using System.Xml.Linq;

var users = new List<User>()
{
    new (1,"Bob"),
    new (2,"Bob"),
    new (3,"Bob"),
    new (4,"Bob")
};
var orders = new List<Order>
{
    new Order(1,10,2),
    new Order(1,10,1),
    new Order(1,10,1),
};
var products = new List<Product>
{
    new Product(1,"Coca Cola",12000),
    new Product(1,"Coca Cola",12000),
    new Product(1,"Coca Cola",12000),
};
var orderedProduct = new List<OrderProduct>
{
    new OrderProduct(1,1,2,10),
    new OrderProduct(1,1,1,10),
    new OrderProduct(1,1,1,10),
};
var query =
    from user in users
    join order in orders on user.Id equals order.UserId
    select (user, order);

public record User(int Id, string firstName);
public record Order(int Id, decimal amount, int UserId);
public record OrderProduct(int Id, int ProductId, int OrderId, int Count);
public record Product(int Id, string Name, decimal Price);
