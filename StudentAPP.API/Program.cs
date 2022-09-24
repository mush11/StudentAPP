using StudentAPP.Infrastructure;


IConfiguration Configuration;
var builder = WebApplication.CreateBuilder(args);
Configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddInfrastructure(Configuration);
builder.Services.AddControllers();


var app = builder.Build();

// Configure the HTTP request pipeline.


app.MapGet("/weatherforecast", () =>
{
    
});

app.Run();
