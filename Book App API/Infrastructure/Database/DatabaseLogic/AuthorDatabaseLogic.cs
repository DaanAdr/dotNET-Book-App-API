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

        public async Task<List<Author>> GetAllAsync()
        {
            return await _dbContext.Author.AsNoTracking().ToListAsync();
        }

        private async Task<Author?> GetByNameAsync(Author author)
        {
            return await _dbContext.Author.FirstOrDefaultAsync(a => a.Firstname == author.Firstname && a.Surname == a.Surname);
        }

        public async Task<Author?> GetByIdAsync(Guid id)
        {
            return await _dbContext.Author.FindAsync(id);
        }

        public async Task<Author> PostAsync(Author author)
        {
            //Check if author already exists
            Author? foundAuthor = await GetByNameAsync(author);

            //Return found author
            if (foundAuthor != null)
            {
                return foundAuthor;
            }

            //Create new author if none were found
            _dbContext.Author.Add(author);
            await _dbContext.SaveChangesAsync();
            return author;
        }

        public async Task<Author> PatchAsync(Author author)
        {
            _dbContext.Author.Update(author);
            await _dbContext.SaveChangesAsync();
            return author;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            Author? author = await GetByIdAsync(id);

            if (author != null) 
            {
                _dbContext.Author.Remove(author);
                await _dbContext.SaveChangesAsync();

                return true;
            }

            throw new KeyNotFoundException($"Author with ID {id} not found.");
        }
    }
}
