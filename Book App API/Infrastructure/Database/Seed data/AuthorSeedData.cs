using Book_App_API.Domain.Entity;

namespace Book_App_API.Infrastructure.Database.Seed_data
{
    public static class AuthorSeedData
    {
        public static List<Author> GetAuthorSeedData()
        {
            return new List<Author>()
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
        }
    }
}
