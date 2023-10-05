namespace OnlineMarket.Models;

public class Order:Entity
{
    public Guid UserId { get; set; }
    public DateTime OrderedDate { get; set; }
    public bool IsDeleted { get; set; }
}
