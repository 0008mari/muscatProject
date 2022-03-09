using muscatApi.Services;
using muscatApi.Models;
using muscatApi.Controllers;

using Microsoft.EntityFrameworkCore;
// using 

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerGen();

builder.Services.AddControllersWithViews();
// adds support for mvc controllers

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddDbContext<muscatApiContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Connectionstring"));
});

builder.Services.AddTransient<IUserService, UserService>();

var app = builder.Build();

app.UseSwagger();

app.MapGet("/", () => "hello world!");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.UseSwaggerUI();

app.Run();
