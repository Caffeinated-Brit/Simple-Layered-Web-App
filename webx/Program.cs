
using MathService;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/", () => "Here is the Factorial of 10: " + FactorialService.CalculateFactorial(10));
app.Run();