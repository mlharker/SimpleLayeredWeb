using MathService;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

FactorialService fs = new FactorialService();
app.MapGet("/", (int value) => "Hello CS420! Here is Factorial(" + value + ")=" + fs.Factorial(value));

app.Run();
