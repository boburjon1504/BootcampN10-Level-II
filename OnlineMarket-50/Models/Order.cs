namespace OnlineMarket_50.Models;

public class Order
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public DateTime OrderDate { get; set; }
    public Order(Guid userId)
    {
        Id = Guid.NewGuid();
        UserId = userId;
        OrderDate = DateTime.Now;
    }
}
