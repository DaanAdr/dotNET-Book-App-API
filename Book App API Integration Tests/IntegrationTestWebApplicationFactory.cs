using Book_App_API.Infrastructure.Database;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Testcontainers.MsSql;

namespace Book_App_API_Integration_Tests
{
    public class IntegrationTestWebApplicationFactory : WebApplicationFactory<Program>, IAsyncLifetime
    {
        private readonly MsSqlContainer _databaseContainer = new MsSqlBuilder()
            //.WithImage("mcr.microsoft.com/mssql/server:2022-CU10-ubuntu-22.04")
            .WithName("int_test_db")
            .Build();

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(x =>
            {
                // Remove the default database connection established in Program.cs
                x.Remove(x.Single(a => a.ServiceType == typeof(DbContextOptions<AppDbContext>)));

                // Add a new database for integration tests
                x.AddDbContext<AppDbContext>(a =>
                {
                    var constring = _databaseContainer.GetConnectionString();
                    a.UseSqlServer(constring);
                });
            });
        }

        public async Task InitializeAsync()
        {
            await _databaseContainer.StartAsync();

            // Apply migrations along which is seed data
            using (var scope = Services.CreateScope())
            {
                var scopedServices = scope.ServiceProvider;
                var db = scopedServices.GetRequiredService<AppDbContext>();

                await db.Database.MigrateAsync();
            }
        }

        async Task IAsyncLifetime.DisposeAsync()
        {
            await _databaseContainer.StopAsync();
        }
    }
}
