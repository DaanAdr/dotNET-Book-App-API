using Book_App_API.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Book_App_API.Infrastructure.Database.Logic
{
    public class GenreDatabaseLogic
    {
        private readonly AppDbContext _dbContext;
        public async Task<List<Genre>> GetGenres()
        {
            return await _dbContext.Genres.ToListAsync();
        }
    }
}
