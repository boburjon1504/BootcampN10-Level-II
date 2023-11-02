using N60_HT_1.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<FileService>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();


app.MapControllers();

app.Run();
