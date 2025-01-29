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
    }
}
