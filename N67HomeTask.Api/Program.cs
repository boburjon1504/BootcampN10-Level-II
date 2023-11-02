using Microsoft.EntityFrameworkCore;
using N67HomeTask.Application.Common.Services;
using N67HomeTask.Infrastructure.Common.Services;
using N67HomeTask.Persistence.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AppDataContext>(option =>
    option
    .UseNpgsql("Host=localhost;Port=5432;Database=AsakaCourse;Username=postgres;Password=boburjon6767")
);


builder.Services
    .AddScoped<IUserService, UserService>()
    .AddScoped<IRoleService, RoleService>()
    .AddScoped<ICourseService, CourseService>()
    .AddScoped<IStudentCourseService, StudentCourseService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();



app.MapControllers();

app.Run();
