using Carter;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCarter();
// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapCarter();
app.Run();
