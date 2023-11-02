using N63_HT_1.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<StorageFileService>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();
