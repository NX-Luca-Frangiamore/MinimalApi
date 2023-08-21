using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MinimalApi.Controllers;
using MinimalApi.Model;
using MinimalApi.Services;
using System.Reflection.Metadata.Ecma335;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSqlite<Context>("Data Source=Context.db");
builder.Services.AddDbContext<Context>(options => options.UseLazyLoadingProxies().UseSqlite(builder.Configuration.GetConnectionString("Context")));
builder.Services.AddScoped<IAccessData, AccessMysqlite>();
builder.Services.AddControllers();

builder.Services.AddControllersWithViews();
builder.Services.AddAuthentication("BasicAuthentication").
            AddScheme<AuthenticationSchemeOptions, Autenticazione>
            ("BasicAuthentication", null);

var app = builder.Build();

app.MapControllers();

app.UseAuthorization();
app.Run();
