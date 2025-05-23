using Ordering.API;
using Ordering.Application;
using Ordering.Infrastructure;
using Ordering.Infrastructure.Data.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services
       .AddApplicationSerivces(builder.Configuration)
       .AddInfrastructureServices(builder.Configuration)
       .AddApiSerivces(builder.Configuration);


var app = builder.Build();


// Configure the HTTP request pipeline.
app.UseApiSerivces();

if (app.Environment.IsDevelopment())
{
    await app.InitialiseDatabaseAsync();
}


app.Run();
