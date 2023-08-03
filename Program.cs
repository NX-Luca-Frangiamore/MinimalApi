using Microsoft.EntityFrameworkCore;

using MinimalApi.Model;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSqlite<Context>("Data Source=Context.db");
builder.Services.AddDbContext<Context>(options =>options.UseSqlite(builder.Configuration.GetConnectionString("Context")));
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
