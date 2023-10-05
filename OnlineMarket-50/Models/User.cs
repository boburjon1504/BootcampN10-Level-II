namespace OnlineMarket_50.Models;

public class User
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public bool IsDeleted { get; set; }

    public User(string name)
    {
        Name = name;
        Id = Guid.NewGuid();
    }
}
