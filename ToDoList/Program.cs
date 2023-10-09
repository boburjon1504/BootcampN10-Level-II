using FileBaseContext.Context.Models.Configurations;
using ToDoList.DataAccess;
using ToDoList.Models;
using ToDoList.Services;
using ToDoList.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IEntityBaseService<User>, UserService>();
builder.Services.AddScoped<IDataContext, AppFileContext>( _ =>
{
    var contextOptions = new FileContextOptions<AppFileContext>
    {
        StorageRootPath = Path.Combine(builder.Environment.ContentRootPath, "Data", "DataStorage")
    };
    var context = new AppFileContext(contextOptions);
    context.FetchAsync().AsTask().Wait();

    return context;
});
//builder.Services.AddScoped<IEntityBaseService<User>, UserService>();
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
