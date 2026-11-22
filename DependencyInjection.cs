using MyWebApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

//https://localhost:7035/swagger/index.html
// Добавляем сервисы для Swagger

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Региструем сервис
builder.Services.AddTransient<IGreetingService, GreetingService>();//Transient сервис

var app = builder.Build();

// Включаем Swagger в режиме разработки
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();

///////////////////////////////////////////////
namespace MyWebApi.Services
{
    public interface IGreetingService
    {
        string GetGreeting(string name);
    }
}
//////////////////////////////////////////////
namespace MyWebApi.Services
{
    public class GreetingService : IGreetingService
    {
        public string GetGreeting(string name)
        {
            return $"Привет, {name}! Время: {DateTime.Now:T}";
        }
    }
}
//////////////////////////////////////////////
using Microsoft.AspNetCore.Mvc;
using MyWebApi.Services;

namespace MyWebApi.Controllers;
[ApiController]
[Route("api/[controller]")]
    public class GreetingController : ControllerBase
    {
    private readonly IGreetingService _greetingService;

    //Внедрение зависимости через конструктор
    public GreetingController(IGreetingService greetingService)
    {
        _greetingService = greetingService;
    }

    [HttpGet("{name}")]
    public IActionResult SayHello(string name)
    {
        var message = _greetingService.GetGreeting(name);
        return Ok(message); // Возвращаем HTTP 200 с текстом
    }
}
