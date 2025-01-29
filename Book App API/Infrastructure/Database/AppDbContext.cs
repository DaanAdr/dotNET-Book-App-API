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

        DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Get seed data for genres
            List<Genre> genreSeedData = GenreSeedData.GetGenreSeedData();

            modelBuilder.Entity<Genre>().HasData(
                genreSeedData
            );
        }
    }
}
