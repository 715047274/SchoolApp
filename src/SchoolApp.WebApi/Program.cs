using Microsoft.EntityFrameworkCore;
using SchoolApp.WebApi.Configurations;
using SchoolApp.WebApi.Repositories;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddDbContext<SchoolAppContext>(options => options.UseSqlite("Data Source=SchoolApp.db"));
builder.Services.AddDbContext<SchoolAppContext>(options => options.UseSqlite(
    builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddTransient<StudentRepository>();


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
