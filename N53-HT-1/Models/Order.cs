namespace N53_HT_1.Models;

public class Order
{
    public Guid Id { get; set; }
    public int UserId { get; set; }    
    public double Amount { get; set; }
}
