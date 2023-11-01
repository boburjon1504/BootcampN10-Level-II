namespace N66_HT_1.Models;

public class BookForCreation
{
    public Guid AuthorId { get; set; }
    public string Title { get; set; } = default!;
    public string Description { get; set; } = default!;
}
