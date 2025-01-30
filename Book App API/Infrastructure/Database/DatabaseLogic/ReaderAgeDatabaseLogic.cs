using Book_App_API.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Book_App_API.Infrastructure.Database.DatabaseLogic
{
    public class ReaderAgeDatabaseLogic
    {
        private readonly AppDbContext _dbContext;

        public ReaderAgeDatabaseLogic(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public async Task<List<ReaderAge>> GetReaderAges()
        {
            return await _dbContext.ReaderAges.AsNoTracking().ToListAsync();
        }
    }
}
