using Microsoft.Extensions.DependencyInjection;
using N66_Task1.Persistance.DataContexts;
using N66_Task1.Domain;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

var services = new ServiceCollection();

services.AddDbContext<AppDataContext>();

var serviceProvider = services.BuildServiceProvider();

var appDbContext = serviceProvider.GetService<AppDataContext>();

appDbContext.Authors.AddRange(new Author
{
    FirstName = "Bobur",
    LastName = "Joraboyev"
});
var changedRowsCount = await appDbContext.SaveChangesAsync();
appDbContext.Books.AddRange(new Book
{
    Title = "Otamdan qolgan dalalar",
    AuthorId = appDbContext.Authors.First().Id
});
await appDbContext.SaveChangesAsync();
Console.WriteLine(JsonSerializer.Serialize(appDbContext.Authors));
Console.ReadLine();