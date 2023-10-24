using N62_Task1.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<UserService>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

var userService = app.Services.GetRequiredService<UserService>();
userService.Create(new N62_Task1.Model.User
{
    Id = Guid.NewGuid(),
    FirstName = "Hello",
    LastName = "Hello",
    UserName = "What's up",
    Email = "hellowrold@gmail.com",
    Password = "password",
    CreatedAt = DateTime.Now,
    UpdatedAt = DateTime.Now,    

});
userService.Create(new N62_Task1.Model.User
{
    Id = Guid.NewGuid(),
    FirstName = "Gani",
    LastName = "Boltavoy",
    UserName = "tesha",
    Email = "ketmon@gmail.com",
    Password = "lapatki",
    CreatedAt = DateTime.Now,
    UpdatedAt = DateTime.Now,

});
app.Run();
