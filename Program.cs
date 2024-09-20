using Microsoft.EntityFrameworkCore;
using WebAPIProducto.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Obtener la cadena de conexión desde appsettings.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Configurar DbContext con SQLite
builder.Services.AddDbContext<dataContext>(
    options => options.UseSqlite(connectionString)
);

builder.Services.AddControllers();

// Swagger configuration
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
