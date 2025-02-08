using Book_App_API.Infrastructure.Database;
using Book_App_API.Infrastructure.Database.DatabaseLogic;
using Book_App_API.Infrastructure.Database.Interfaces;
using Book_App_API.Infrastructure.Database.Logic;
using Book_App_API.Logic;
using Book_App_API.Logic.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(optionsBuilder =>
{
    optionsBuilder.UseSqlServer(builder.Configuration["DBConnectionString"]!);
});

builder.Services.AddScoped<GenreDatabaseLogic>();
builder.Services.AddScoped<GenreLogic>();

builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();
builder.Services.AddScoped<IAuthorLogic, AuthorLogic>();

builder.Services.AddScoped<ReaderAgeDatabaseLogic>();
builder.Services.AddScoped<ReaderAgeLogic>();

builder.Services.AddScoped<BookDatabaseLogic>();
builder.Services.AddScoped<BookLogic>();

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
