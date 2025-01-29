using Book_App_API.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Book_App_API.Infrastructure.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }

        DbSet<Genre> Genres { get; set; }
    }
}
