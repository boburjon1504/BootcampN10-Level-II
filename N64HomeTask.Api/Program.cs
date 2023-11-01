using N64HomeTask.Application.Common.Identity.Services;
using N64HomeTask.Infrastructure.Common.Identity.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<IUserService, UserService>()
    .AddScoped<ITokenGeneratorService, TokenGeneratorService>()
    .AddScoped<IAuthService, AuthService>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();


app.MapControllers();

app.Run();
