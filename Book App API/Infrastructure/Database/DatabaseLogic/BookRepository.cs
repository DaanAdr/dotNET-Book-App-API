using Book_App_API.Domain.Entity;
using Book_App_API.Infrastructure.Database.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Book_App_API.Infrastructure.Database.DatabaseLogic
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _dbContext;

        public BookRepository(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public async Task<List<Book>> GetAllAsync()
        {
            return await _dbContext.Books.AsNoTracking()
                //Include the readerAge
                .Include(x => x.ReaderAge)
                .Include(b => b.BookAuthors)
                    .ThenInclude(ba => ba.Author)
                .Include(b => b.BookGenres)
                    .ThenInclude(bg => bg.Genre)
                .ToListAsync();
        }
    }
}
