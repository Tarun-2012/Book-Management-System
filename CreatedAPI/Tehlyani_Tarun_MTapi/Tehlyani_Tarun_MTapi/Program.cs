using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.Extensions.DependencyInjection;
using Tehlyani_Tarun_MTapi.Data;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Tehlyani_Tarun_MTapiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Tehlyani_Tarun_MTapiContext") ?? throw new InvalidOperationException("Connection string 'Tehlyani_Tarun_MTapiContext' not found.")));



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
