using N58_HT_1.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<WebBroker>();

builder.Services.AddControllers().AddNewtonsoftJson();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();



app.MapControllers();

app.Run();
