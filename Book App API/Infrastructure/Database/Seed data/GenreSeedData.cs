using Book_App_API.Domain.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Book_App_API.Infrastructure.Database.Seed_data
{
    public static class GenreSeedData
    {
        public static List<Genre> GetGenreSeedData()
        {
            List<Genre> seedData = new List<Genre>()
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

            return seedData;
        }
    }
}
