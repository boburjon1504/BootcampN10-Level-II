using FileBaseContext.Abstractions.Models.FileEntry;
using FileBaseContext.Abstractions.Models.FileSet;

namespace OnlineMarket.Models;

public class User : Entity
{
    public string Name { get; set; }
    public bool IsDeleted { get; set; }

}
