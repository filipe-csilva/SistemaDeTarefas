using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ApiDeTarefas.Data;
using ApiDeTarefas.Repository;
using ApiDeTarefas.Repository.Interfaces;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddEntityFrameworkSqlServer().AddDbContext<SystemContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("AllConnection")));

//teste de conexao
//Debug.WriteLine(builder.Configuration.GetConnectionString("AllConnection");
builder.Services.AddDbContext<SystemContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("AllConnection")));

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ITaskRepository, TaskRepository>();

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
