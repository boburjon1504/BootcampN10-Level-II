using FileBaseContext.Context.Models.Configurations;
using OnlineMarket.DataContext;
using OnlineMarket.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<OrderService>();
builder.Services.AddScoped<IDataContext, AppDataContext>(_ =>
{
    var contextOptions = new FileContextOptions<AppDataContext>{
        StorageRootPath = Path.Combine(builder.Environment.ContentRootPath, "Data", "DataStorage") 
    };
    var context = new AppDataContext(contextOptions);
    context.FetchAsync().AsTask().Wait();

    return context;
});


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

app.Run();
