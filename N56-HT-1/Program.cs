using Bogus;
using N56_HT_1;

//Randomizer.Seed = new Random();
//var guids = new List<Guid>
//{
//    Guid.NewGuid(),
//    Guid.NewGuid(),
//    Guid.NewGuid(),
//    Guid.NewGuid(),
//    Guid.NewGuid(),
//    Guid.NewGuid(),
//    Guid.NewGuid(),
//    Guid.NewGuid(),
//    Guid.NewGuid(),
//    Guid.NewGuid(),
//};
//var ids = new Stack<Guid>(guids);

var userService = new UserService();

var users = new Faker<User>().
    RuleFor(user => user.Id, Guid.NewGuid)
    .RuleFor(user => user.FirstName, src => src.Person.FirstName)
    .RuleFor(user => user.LastName, src => src.Person.LastName);

var result = users.Generate(10);
foreach (var user in result)
{
    userService.Create(user);
}
var directory = new DirectoryService(userService);
var file = new FileService(userService, directory);
var cleanUpService = new CleanUpService(directory);

directory.CreateDirectories();
file.CreateUserProfileJson();

cleanUpService.CLean();




