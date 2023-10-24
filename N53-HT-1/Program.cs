using N53_HT_1.Event;
using N53_HT_1.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<UserService>()
    .AddScoped<OrderService>()
    .AddSingleton<BonusService>()
    .AddSingleton<BonusEventStore>()
    .AddSingleton<OrderEventStore>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

var bonusService = app.Services.GetRequiredService<BonusService>();
var bonus = bonusService.Create(new N53_HT_1.Models.Bonus
{
    Id = Guid.NewGuid(),
    Amount = 100
});
var service = app.Services.GetRequiredService<UserService>();
service.Create(new N53_HT_1.Models.User
{
    FirstName = "Bobur",
    LastName = "Joraboyev",
    Id = 1,
    BonusId = bonus.Id

}) ;

app.Run();
