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
        public DbSet<ReaderAge> ReaderAges { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookGenre> BookGenres { get; set; }
        public DbSet<BookAuthor> BookAuthor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Junction table relation for bookAuthors
            modelBuilder.Entity<BookAuthor>().HasKey(ba => new {ba.AuthorId, ba.BookId});

            modelBuilder.Entity<BookAuthor>()
                .HasOne(ba => ba.Book)
                .WithMany(ba => ba.BookAuthors)
                .HasForeignKey(ba => ba.BookId);

            modelBuilder.Entity<BookAuthor>()
                .HasOne(ba => ba.Author)
                .WithMany() // No collection in Author
                .HasForeignKey(ba => ba.AuthorId);

            //Junction table relation for bookGenre
            modelBuilder.Entity<BookGenre>().HasKey(bg => new {bg.GenreId, bg.BookId});

            modelBuilder.Entity<BookGenre>()
                .HasOne(bg => bg.Book)
                .WithMany(bg => bg.BookGenres)
                .HasForeignKey(bg => bg.BookId);

            modelBuilder.Entity<BookGenre>()
                .HasOne(bg => bg.Genre)
                .WithMany()
                .HasForeignKey(bg => bg.GenreId);

            //Seed Genre table
            modelBuilder.Entity<Genre>().HasData(BooksSeedData.genreSeedData);

            //Seed ReaderAge table
            modelBuilder.Entity<ReaderAge>().HasData(BooksSeedData.readerAgeSeedData);

            //Seed Author table
            modelBuilder.Entity<Author>().HasData(BooksSeedData.authorSeedData);

            //Seed Book table and its relations
            modelBuilder.Entity<Book>().HasData(BooksSeedData.bookSeedData);
            modelBuilder.Entity<BookAuthor>().HasData(BooksSeedData.bookAuthorSeedData);
            modelBuilder.Entity<BookGenre>().HasData(BooksSeedData.bookGenreSeedData);
        }
    }
}
