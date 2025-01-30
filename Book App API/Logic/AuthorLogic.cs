using Book_App_API.Domain.DTO;
using Book_App_API.Domain.Entity;
using Book_App_API.Infrastructure.Database.DatabaseLogic;

namespace Book_App_API.Logic
{
    public class AuthorLogic
    {
        private readonly AuthorDatabaseLogic _dbLogic;

        public AuthorLogic(AuthorDatabaseLogic databaseLogic)
        {
            _dbLogic = databaseLogic;
        }

        public async Task<List<Author>> GetAuthors()
        {
            try
            {
                return await _dbLogic.GetAuthors();
            }
            catch (Exception)
            {
                //TODO Log the error

                throw;
            }
        }

        public async Task<Author> PostAuthor(AuthorDTO author)
        {
            try
            {
                //TODO Validate AuthorDTO

                //Convert DTO to Author
                Author newAuthor = new Author()
                {
                    Firstname = author.Firstname,
                    Surname = author.Surname,
                };

                return await _dbLogic.PostAuthor(newAuthor);
            }
            catch (Exception)
            {
                //TODO Log the error

                throw;
            }
        }
    }
}
