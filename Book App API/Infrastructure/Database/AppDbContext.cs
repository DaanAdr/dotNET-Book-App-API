﻿using Book_App_API.Domain.Entity;
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
        public DbSet<ReaderAge> ReaderAges { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Seed genre
            modelBuilder.Entity<Genre>().HasData(BooksSeedData.genreSeedData);

            //Seed author
            modelBuilder.Entity<Author>().HasData(BooksSeedData.authorSeedData);

            //Seed readerAges
            modelBuilder.Entity<ReaderAge>().HasData(BooksSeedData.readerAgeSeedData);
        }
    }
}
