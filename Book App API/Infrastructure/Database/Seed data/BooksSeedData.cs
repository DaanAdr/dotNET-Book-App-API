using Book_App_API.Domain.Entity;

namespace Book_App_API.Infrastructure.Database.Seed_data
{
    public static class BooksSeedData
    {
        public static readonly List<Genre> genreSeedData = new List<Genre>()
            {
                new Genre
                {
                    Id = 1,
                    GenreName = "Fantasy"
                },
                new Genre
                {
                    Id = 2,
                    GenreName = "Science Fiction"
                },
                new Genre
                {
                    Id = 3,
                    GenreName = "Dystopian"
                },
                new Genre
                {
                    Id = 4,
                    GenreName = "Action & Adventure"
                },
                new Genre
                {
                    Id = 5,
                    GenreName = "Mystery"
                },
                new Genre
                {
                    Id = 6,
                    GenreName = "Horror"
                },
                new Genre
                {
                    Id = 7,
                    GenreName = "Romance"
                }
            };

        public static readonly List<Author> authorSeedData = new List<Author>()
            {
                new Author()
                {
                    Id = 1,
                    Firstname = "Roderick",
                    Surname = "Gordon"
                },
                new Author()
                {
                    Id = 2,
                    Firstname = "Brian",
                    Surname = "Williams"
                },
                new Author()
                {
                    Id = 3,
                    Firstname = "Joanne",
                    Surname = "Rowling"
                },
                new Author()
                {
                    Id = 4,
                    Firstname = "George",
                    Surname = "Orwell"
                },
                new Author()
                {
                    Id = 5,
                    Firstname = "Jane",
                    Surname = "Austen"
                },
                new Author()
                {
                    Id = 6,
                    Firstname = "Mark",
                    Surname = "Twain"
                },
                new Author()
                {
                    Id = 7,
                    Firstname = "F. Scott",
                    Surname = "Fitzgerald"
                },
                new Author()
                {
                    Id = 8,
                    Firstname = "Ernest",
                    Surname = "Hemingway"
                },
                new Author()
                {
                    Id = 9,
                    Firstname = "Harper",
                    Surname = "Lee"
                },
                new Author()
                {
                    Id = 10,
                    Firstname = "Isaac",
                    Surname = "Asimov"
                },
                new Author()
                {
                    Id = 11,
                    Firstname = "Brandon",
                    Surname = "Sanderson"
                },
                new Author()
                {
                    Id = 12,
                    Firstname = "Carlos",
                    Surname = "Ruiz Zafón"
                }
            };

        public static readonly List<ReaderAge> readerAgeSeedData = new List<ReaderAge>()
            {
                new ReaderAge()
                {
                    Id = 1,
                    AgeRange = "Picture Books (Ages 0-5)"
                },
                new ReaderAge()
                {
                    Id = 2,
                    AgeRange = "Early Readers (Ages 5-7)"
                },
                new ReaderAge()
                {
                    Id = 3,
                    AgeRange = "Chapter Books (Ages 7-9)"
                },
                new ReaderAge()
                {
                    Id = 4,
                    AgeRange = "Middle Grade (Ages 8-12)"
                },
                new ReaderAge()
                {
                    Id = 5,
                    AgeRange = "Young Adult (YA) (Ages 12-18)"
                },
                new ReaderAge()
                {
                    Id = 6,
                    AgeRange = "Adult (Ages 18+)"
                }
            };

        public static readonly List<Book> bookSeedData = new List<Book>()
        {
            new Book
            {
                Id = 1,
                Title = "Tunnels",
                Pages = 464,
                PublishDate = new DateTime(2007, 7, 2),
                ReaderAgeId = 5
            },
            new Book
            {
                Id = 2,
                Title = "Deeper",
                Pages = 655,
                PublishDate = new DateTime(2009, 4, 1),
                ReaderAgeId = 5
            },
            new Book
            {
                Id = 3,
                Title = "Freefall",
                Pages = 577,
                PublishDate = new DateTime(2009, 5, 18),
                ReaderAgeId = 5
            },
            new Book
            {
                Id = 4,
                Title = "Closer",
                Pages = 508,
                PublishDate = new DateTime(2010, 5, 3),
                ReaderAgeId = 5
            },
            new Book
            {
                Id = 5,
                Title = "Spiral",
                Pages = 443,
                PublishDate = new DateTime(2011, 9, 1),
                ReaderAgeId = 5
            },
            new Book
            {
                Id = 6,
                Title = "Terminal",
                Pages = 402,
                PublishDate = new DateTime(2013, 5, 2),
                ReaderAgeId = 5
            },
            new Book
            {
                Id = 7,
                Title = "Nineteen Eighty-Four",
                Pages = 328,
                PublishDate = new DateTime(1949, 6, 8),
                ReaderAgeId = 6
            },
            new Book
            {
                Id = 8,
                Title = "I, Robot",
                Pages = 253,
                PublishDate = new DateTime(1950, 12 ,2),
                ReaderAgeId = 6
            }
        };

        public static readonly List<BookAuthor> bookAuthorSeedData = new List<BookAuthor>()
        {
            //Tunnels
            new BookAuthor
            {
                Id = 1,
                AuthorId = 1,
                BookId = 1
            },
            new BookAuthor
            {
                Id = 2,
                AuthorId = 2,
                BookId = 1
            },
            //Deeper
            new BookAuthor
            {
                Id = 3,
                AuthorId = 1,
                BookId = 2
            },
            new BookAuthor
            {
                Id = 4,
                AuthorId = 2,
                BookId = 2
            },
            //Freefall
            new BookAuthor
            {
                Id = 5,
                AuthorId = 1,
                BookId = 3
            },
            new BookAuthor
            {
                Id = 6,
                AuthorId = 2,
                BookId = 3
            },
            //Closer
            new BookAuthor
            {
                Id = 7,
                AuthorId = 1,
                BookId = 4
            },
            new BookAuthor
            {
                Id = 8,
                AuthorId = 2,
                BookId = 4
            },
            //Spiral
            new BookAuthor
            {
                Id = 9,
                AuthorId = 1,
                BookId = 5
            },
            new BookAuthor
            {
                Id = 10,
                AuthorId = 2,
                BookId = 5
            },
            //Terminal
            new BookAuthor
            {
                Id = 11,
                AuthorId = 1,
                BookId = 6
            },
            new BookAuthor
            {
                Id = 12,
                AuthorId = 2,
                BookId = 6
            },
            //1984
            new BookAuthor
            {
                Id = 13,
                AuthorId = 4,
                BookId = 7
            },
            //I, Robot
            new BookAuthor
            {
                Id = 14,
                AuthorId = 10,
                BookId = 8
            }
        };

        public static readonly List<BookGenre> bookGenreSeedData = new List<BookGenre>()
        {
            //Tunnels
            new BookGenre
            {
                Id = 1,
                GenreId = 1,
                BookId = 1
            },
            new BookGenre
            {
                Id = 2,
                GenreId = 2,
                BookId = 1
            },
            //Deeper
            new BookGenre
            {
                Id = 3,
                GenreId = 1,
                BookId = 2
            },
            new BookGenre
            {
                Id = 4,
                GenreId = 2,
                BookId = 2
            },
            //Freefall
            new BookGenre
            {
                Id = 5,
                GenreId = 1,
                BookId = 3
            },
            new BookGenre
            {
                Id = 6,
                GenreId = 2,
                BookId = 3
            },
            //Closer
            new BookGenre
            {
                Id = 7,
                GenreId = 1,
                BookId = 4
            },
            new BookGenre
            {
                Id = 8,
                GenreId = 2,
                BookId = 4
            },
            //Spiral
            new BookGenre
            {
                Id = 9,
                GenreId = 1,
                BookId = 5
            },
            new BookGenre
            {
                Id = 10,
                GenreId = 2,
                BookId = 5
            },
            //Terminal
            new BookGenre
            {
                Id = 11,
                GenreId = 1,
                BookId = 6
            },
            new BookGenre
            {
                Id = 12,
                GenreId = 2,
                BookId = 6
            },
            //1984
            new BookGenre
            {
                Id = 13,
                GenreId = 3,
                BookId = 7
            },
            new BookGenre
            {
                Id = 14,
                GenreId = 2,
                BookId = 7
            },
            //I, Robot
            new BookGenre
            {
                Id = 15,
                GenreId = 2,
                BookId = 8
            }
        };
    }
}
