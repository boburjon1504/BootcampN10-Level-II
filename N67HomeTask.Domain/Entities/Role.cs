namespace N67HomeTask.Domain.Entities;

public class Role
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string Name { get; set; } = default!;
}
