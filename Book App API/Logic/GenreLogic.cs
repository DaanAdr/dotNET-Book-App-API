using Book_App_API.Domain.Entity;
using Book_App_API.Infrastructure.Database.Logic;

namespace Book_App_API.Logic
{
    public class GenreLogic
    {
        private readonly GenreDatabaseLogic _dbLogic;

        public GenreLogic(GenreDatabaseLogic genreDatabaseLogic)
        {
            _dbLogic = genreDatabaseLogic;
        }

        public async Task<List<Genre>> GetGenres()
        {
            try
            {
                return await _dbLogic.GetGenres();
            }
            catch (Exception)
            {
                //TODO Log the error

                throw;
            }
        }
    }
}
