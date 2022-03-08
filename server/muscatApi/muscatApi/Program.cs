using muscatApi.Services;
using muscatApi.Models;

// using ĭ

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerGen();

builder.Services.AddControllersWithViews();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UseRouting();




app.Run();
