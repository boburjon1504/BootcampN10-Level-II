using N52_HT_1.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddScoped<UserService>()
    .AddScoped<UserManagementService>()
    .AddScoped<EmailSenderService>()
    .AddSingleton<AccountEventStore>();


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();


app.MapControllers();

var eventt = app.Services.GetRequiredService<AccountEventStore>();

app.Run();
