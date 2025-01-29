using Microsoft.EntityFrameworkCore;

namespace Book_App_API.Infrastructure.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }
    }
}
