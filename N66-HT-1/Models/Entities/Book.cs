namespace N66_HT_1.Models.Entities;

public class Book
{
    public Guid Id { get; set; }
    public Guid AuthorId { get; set; }
    public string Title { get; set; } = default!;
    public string Description { get; set; } = default!;
}
