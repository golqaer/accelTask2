using Microsoft.EntityFrameworkCore;
using Task2.Models.Db;
using System.Linq;
using System.IO;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<Context>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

#region folderInit
//FolderInit
var storageSection = builder.Configuration.GetSection("Storage");
var rootPath = storageSection.GetSection("Root").Value;
var bookCoversPath = Path.Combine(rootPath, storageSection.GetSection("BookCovers").Value);

if (!Directory.Exists(rootPath)) Directory.CreateDirectory(rootPath);
if (!Directory.Exists(bookCoversPath)) 
    Directory.CreateDirectory(bookCoversPath);
#endregion

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

