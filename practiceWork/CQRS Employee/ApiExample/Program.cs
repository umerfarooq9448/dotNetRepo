using CQRS_Employee.Data_Access;
using CQRS_Employee.Models;
using CQRS_Employee.Repositories;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddTransient<IEmployee, EmployeeRepository>();
////builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
//builder.Services.AddDbContext<EmployeeContext>();
//builder.Services.AddIdentity<IdentityUser, IdentityRole>()                
//                .AddDefaultTokenProviders();
builder.Services.AddDbContext<EmployeeContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConn")));
builder.Services.AddScoped<IEmployee, EmployeeRepository>();
builder.Services.AddMediatR(typeof(EmployeeRepository).Assembly);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
