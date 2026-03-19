var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/products", () =>
{
    return new[] {
        new { Id = 1, Name = "Laptop" },
        new { Id = 2, Name = "Phone" }
    };
});

app.Run();
