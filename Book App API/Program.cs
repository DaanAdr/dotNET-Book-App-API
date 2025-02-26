using Book_App_API.Business.Logic;
using Book_App_API.Infrastructure.Database;
using Book_App_API.Infrastructure.Database.DatabaseLogic;
using Book_App_API.Infrastructure.Database.Logic;
using Microsoft.EntityFrameworkCore;

public class Program
{
    private static void Main(string[] args)
    {
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

        builder.Services.AddScoped<GenreRepository>();
        builder.Services.AddScoped<GenreLogic>();

        builder.Services.AddScoped<AuthorRepository>();
        builder.Services.AddScoped<AuthorLogic>();

        builder.Services.AddScoped<ReaderAgeRepository>();
        builder.Services.AddScoped<ReaderAgeLogic>();

        builder.Services.AddScoped<BookRepository>();
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
    }
}