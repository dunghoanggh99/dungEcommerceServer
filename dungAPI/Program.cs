using dungAPI.DAL.Context;
using dungEcommerce.BLL.IRepositories;
using dungEcommerce.BLL.Repositories;
using dungEcommerceAPI.Builder;
using dungEcommerceAPI.ServiceRegister;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDungServiceRegister(builder.Configuration);

var app = builder.Build();

app.UseDungBuilder(app.Environment.IsDevelopment());

app.MapControllers();

app.Run();
