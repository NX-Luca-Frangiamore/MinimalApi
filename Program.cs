using Microsoft.EntityFrameworkCore;
using MinimalApi;
using MinimalApi.Model;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSqlite<Context>("Data Source=Context.db");
builder.Services.AddDbContext<Context>(options =>options.UseSqlite(builder.Configuration.GetConnectionString("Context")));
builder.Services.AddScoped<AccessData, AccessMysqlite>();
builder.Services.AddControllers();
var app = builder.Build();

app.MapGet("/Prova", () => "Hello World!");
app.MapControllers();

app.Run();
