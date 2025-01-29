using Book_App_API.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Book_App_API.Infrastructure.Database.DatabaseLogic
{
    public class AuthorDatabaseLogic
    {
        private readonly AppDbContext _dbContext;

        public AuthorDatabaseLogic(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public async Task<List<Author>> GetAuthors()
        {
            return await _dbContext.Author.AsNoTracking().ToListAsync();
        }
    }
}
