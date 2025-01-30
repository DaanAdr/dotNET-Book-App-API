using Book_App_API.Controllers;
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

        private async Task<Author> GetAuthorByName(Author author)
        {
            return await _dbContext.Author.FirstOrDefaultAsync(a => a.Firstname == author.Firstname && a.Surname == a.Surname);
        }

        public async Task<Author> PostAuthor(Author author)
        {
            //Check if author already exists
            Author foundAuthor = await GetAuthorByName(author);

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
    }
}
