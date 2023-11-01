using N66_HT_1.Persistence.DataAccess;
using N66_HT_1.Services;
using N66_HT_1.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddScoped<IAuthorService, AuthorService>()
    .AddScoped<IBookService, BookService>()
    .AddDbContext<AppDataContext>();

builder.Services.AddControllers();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();



app.MapControllers();

app.Run();
