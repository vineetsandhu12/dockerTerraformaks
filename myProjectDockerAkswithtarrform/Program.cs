var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () =>
{
    return "Hello from ASP.NET Core Docker!";
});

app.MapGet("/api/products", () =>
{
    return new[]
    {
        new { Id = 1, Name = "Laptop", Price = 50000 },
        new { Id = 2, Name = "Mouse", Price = 1000 }
    };
});

app.Run();