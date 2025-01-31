using Book_App_API.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Book_App_API.Infrastructure.Database.Logic
{
    public class GenreDatabaseLogic
    {
        private readonly AppDbContext _dbContext;

        public GenreDatabaseLogic(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public async Task<List<Genre>> GetAllAsync()
        {
            //AsNoTracking makes this function a readonly function, making it more efficient
            return await _dbContext.Genres.AsNoTracking().ToListAsync();
        }
    }
}
