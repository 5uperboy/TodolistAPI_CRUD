using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TodolistAPI_CRUD.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TodolistAPI_CRUDContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TodolistAPI_CRUDContext") ?? throw new InvalidOperationException("Connection string 'TodolistAPI_CRUDContext' not found.")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors(builder =>
{
    builder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader();
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
