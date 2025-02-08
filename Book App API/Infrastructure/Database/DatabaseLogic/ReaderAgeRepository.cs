using Book_App_API.Domain.Entity;
using Book_App_API.Infrastructure.Database.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Book_App_API.Infrastructure.Database.DatabaseLogic
{
    public class ReaderAgeRepository : IReaderAgeRepository
    {
        private readonly AppDbContext _dbContext;

        public ReaderAgeRepository(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public async Task<List<ReaderAge>> GetAllAsync()
        {
            return await _dbContext.ReaderAges.AsNoTracking().ToListAsync();
        }
    }
}
