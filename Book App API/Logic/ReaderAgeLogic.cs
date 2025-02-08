using Book_App_API.Domain.Entity;
using Book_App_API.Infrastructure.Database.Interfaces;
using Book_App_API.Logic.Interfaces;

namespace Book_App_API.Logic
{
    public class ReaderAgeLogic : IReaderAgeLogic
    {
        private readonly IReaderAgeRepository _dbLogic;

        public ReaderAgeLogic(IReaderAgeRepository databaseLogic)
        {
            _dbLogic = databaseLogic;
        }

        public async Task<List<ReaderAge>> GetAllAsync()
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
