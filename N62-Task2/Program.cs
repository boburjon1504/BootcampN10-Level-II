using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);



//builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


app.Use(async (context, next) =>
{
    var message = $"{DateTimeOffset.Now} {context.Request}";
    await using var fileStream = File.Open("log.txt",FileMode.Append,FileAccess.Write);
    await using var filestream = new StreamWriter(fileStream);
    await filestream.WriteAsync(message);
    await next();
});
//app.UseSwagger();
//app.UseSwaggerUI();

app.MapGet("/", () => "Hello world");

//app.MapControllers();

app.Run();
