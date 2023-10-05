using OnlineMarket_50.Models;
using OnlineMarket_50.Services;
using OnlineMarket_50.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var users = new List<User>
{
    new User("Bob"),
    new User("John"),
    new User("Wick"),
    new User("Garry"),
};

var orders = new List<Order>
{
    new Order(users[0].Id),
    new Order(users[1].Id),
    new Order(users[0].Id),
    new Order(users[2].Id),
};

var userService = new UserService(users);
var orderService = new OrderService(orders);
builder.Services.AddControllers();
builder.Services.AddScoped<IUserService, UserService>(_ => userService);
builder.Services.AddScoped<IOrderService, OrderService>(_=>orderService);
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

app.Run();


/*
 * empty web api project yarating
- projectga UserService, 
OrderService va UserOrderService larini qo'shing
- ma'lumotlarni saqlash uchun data context shartmas, shunchaki list service lar ichida da saqlang
- user va orderlari uchun ma'lumot qo'shing ( o'sha list ichiga )
- UserOrderService da user va uni orderlarini yig'ib, qaytaradigan GetUserOrdersByUserId methodini yarating
- OrdersControllerini qo'shing unda 

api/orders/by-user/:userId endpoint bo'lsin

bunda :userId - bu route parameter

- Program.cs da barcha servicelarni registratsiya qiling ( dependency injection uchun ) 
- controllerni ham qo'shing va swagger o'rnating, dasturni run qilib tekshirib ko'ring

 */
