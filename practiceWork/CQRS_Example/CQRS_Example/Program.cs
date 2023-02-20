using CQRS_Example.Data_Access;
using CQRS_Example.Models;
using CQRS_Example.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ProductDatabaseContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConn")));

builder.Services.AddScoped<IProduct, ProductRepositories>();
builder.Services.AddMediatR(typeof(ProductRepositories).Assembly);
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
