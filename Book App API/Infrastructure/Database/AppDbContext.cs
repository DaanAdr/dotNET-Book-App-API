using Book_App_API.Domain.Entity;
using Book_App_API.Infrastructure.Database.Seed_data;
using Microsoft.EntityFrameworkCore;

namespace Book_App_API.Infrastructure.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Author> Author { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Get seed data for genres
            List<Genre> genreSeedData = GenreSeedData.GetGenreSeedData();

            modelBuilder.Entity<Genre>().HasData(genreSeedData);

            //Get seed data for authors
            List<Author> authorSeedData = AuthorSeedData.GetAuthorSeedData();

            modelBuilder.Entity<Author>().HasData(authorSeedData);
        }
    }
}
