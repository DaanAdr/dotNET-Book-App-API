using Book_App_API.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Book_App_API.Infrastructure.Database.DatabaseLogic
{
    public class BookDatabaseLogic
    {
        private readonly AppDbContext _dbContext;

        public BookDatabaseLogic(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public async Task<List<Book>> GetBook()
        {
            return await _dbContext.Books.AsNoTracking()
                //Include the readerAge
                .Include(x => x.ReaderAge)
                .Include(b => b.BookAuthors)
                    .ThenInclude(ba => ba.Author)
                .ToListAsync();
        }
    }
}
