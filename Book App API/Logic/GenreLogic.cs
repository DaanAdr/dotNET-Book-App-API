using Book_App_API.Domain.Entity;
using Book_App_API.Infrastructure.Database.Logic;

namespace Book_App_API.Logic
{
    public class GenreLogic
    {
        private readonly GenreDatabaseLogic _dbLogic;

        public GenreLogic(GenreDatabaseLogic databaseLogic)
        {
            _dbLogic = databaseLogic;
        }

        public async Task<List<Genre>> GetAllAsync()
        {
            try
            {
                return await _dbLogic.GetAllAsync();
            }
            catch (Exception)
            {
                //TODO Log the error

                throw;
            }
        }
    }
}
