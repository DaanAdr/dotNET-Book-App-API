using Book_App_API.Domain.Entity;
using Book_App_API.Infrastructure.Database.Interfaces;

namespace Book_App_API.Logic
{
    public class GenreLogic : IGenreRepository
    {
        private readonly IGenreRepository _dbLogic;

        public GenreLogic(IGenreRepository databaseLogic)
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
