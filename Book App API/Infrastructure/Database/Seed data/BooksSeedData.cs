using Book_App_API.Domain.Entity;

namespace Book_App_API.Infrastructure.Database.Seed_data
{
    public static class BooksSeedData
    {
        public static readonly List<Genre> genreSeedData = new List<Genre>()
            {
                new Genre
                {
                    Id = Guid.Parse("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                    GenreName = "Fantasy"
                },
                new Genre
                {
                    Id = Guid.Parse("7369fec7-9646-42b4-8266-bfce860e7ead"),
                    GenreName = "Science Fiction"
                },
                new Genre
                {
                    Id = Guid.Parse("57a1d08a-39f7-4cdb-85e0-20811f714bcb"),
                    GenreName = "Dystopian"
                },
                new Genre
                {
                    Id = Guid.Parse("0db4cd86-f853-4884-bd59-51b154272336"),
                    GenreName = "Action & Adventure"
                },
                new Genre
                {
                    Id = Guid.Parse("a4b21504-11de-430e-bcb7-70bda87975c2"),
                    GenreName = "Mystery"
                },
                new Genre
                {
                    Id = Guid.Parse("cc7b964c-167c-4fd7-ba0e-9dff9edc48c2"),
                    GenreName = "Horror"
                },
                new Genre
                {
                    Id = Guid.Parse("f54d72f0-508d-4d6c-a417-e24383f9ce1b"),
                    GenreName = "Romance"
                }
            };

        public static readonly List<Author> authorSeedData = new List<Author>()
            {
                new Author()
                {
                    Id = Guid.Parse("0f14ebe0-ae44-49ae-b412-796d8ed108a8"),
                    Firstname = "Roderick",
                    Surname = "Gordon"
                },
                new Author()
                {
                    Id = Guid.Parse("fbbb4392-3c14-4625-9449-fa7e19fdf565"),
                    Firstname = "Brian",
                    Surname = "Williams"
                },
                new Author()
                {
                    Id = Guid.Parse("2d8cef7c-551b-489c-b0b4-312f4b02aa4d"),
                    Firstname = "Joanne",
                    Surname = "Rowling"
                },
                new Author()
                {
                    Id = Guid.Parse("82b4c82e-23ff-4fbd-b9c4-1220990dafd4"),
                    Firstname = "George",
                    Surname = "Orwell"
                },
                new Author()
                {
                    Id = Guid.Parse("40a18991-7508-40d2-8cef-e4b2b6a16d1f"),
                    Firstname = "Jane",
                    Surname = "Austen"
                },
                new Author()
                {
                    Id = Guid.Parse("451bd4fc-5bf0-4485-858d-bbf351274b8a"),
                    Firstname = "Mark",
                    Surname = "Twain"
                },
                new Author()
                {
                    Id = Guid.Parse("f7d3c8b7-bb04-44ea-84c6-b9682ec1ea35"),
                    Firstname = "F. Scott",
                    Surname = "Fitzgerald"
                },
                new Author()
                {
                    Id = Guid.Parse("672c53eb-118c-4d82-b66b-1fd4dccf2cbe"),
                    Firstname = "Ernest",
                    Surname = "Hemingway"
                },
                new Author()
                {
                    Id = Guid.Parse("c48a135d-670c-472d-be24-ee678ac2003f"),
                    Firstname = "Harper",
                    Surname = "Lee"
                },
                new Author()
                {
                    Id = Guid.Parse("cc4ce597-ae78-4180-a1ed-68dd94b7566d"),
                    Firstname = "Isaac",
                    Surname = "Asimov"
                },
                new Author()
                {
                    Id = Guid.Parse("c3b56ffd-b51d-431e-8120-5391f86d2b9b"),
                    Firstname = "Brandon",
                    Surname = "Sanderson"
                },
                new Author()
                {
                    Id = Guid.Parse("d7a19b30-cd0b-4292-a6f7-1dafe478df02"),
                    Firstname = "Carlos",
                    Surname = "Ruiz Zafón"
                }
            };

        public static readonly List<ReaderAge> readerAgeSeedData = new List<ReaderAge>()
            {
                new ReaderAge()
                {
                    Id = Guid.Parse("ba9cc1c4-fc08-4ded-a5fd-289f4748cec0"),
                    AgeRange = "Picture Books (Ages 0-5)"
                },
                new ReaderAge()
                {
                    Id = Guid.Parse("7bb41b2d-f163-4604-bd7a-e15ae0d9fbfe"),
                    AgeRange = "Early Readers (Ages 5-7)"
                },
                new ReaderAge()
                {
                    Id = Guid.Parse("1c09c0dc-946b-412c-82f5-a877cc383bf2"),
                    AgeRange = "Chapter Books (Ages 7-9)"
                },
                new ReaderAge()
                {
                    Id = Guid.Parse("6e7f81e0-74f2-4706-9e6f-d891007877fc"),
                    AgeRange = "Middle Grade (Ages 8-12)"
                },
                new ReaderAge()
                {
                    Id = Guid.Parse("e4a6087f-f8c0-473e-8abe-2abeba324833"),
                    AgeRange = "Young Adult (YA) (Ages 12-18)"
                },
                new ReaderAge()
                {
                    Id = Guid.Parse("729ca0c2-2b61-45e5-82c7-78b6680bdd31"),
                    AgeRange = "Adult (Ages 18+)"
                }
            };
    }
}
