using Book_App_API.Domain.Entity;
using Book_App_API.Infrastructure.Database.DatabaseLogic;

namespace Book_App_API.Logic
{
    public class ReaderAgeLogic
    {
        private readonly ReaderAgeDatabaseLogic _dbLogic;

        public ReaderAgeLogic(ReaderAgeDatabaseLogic databaseLogic)
        {
            _dbLogic = databaseLogic;
        }

        public async Task<List<ReaderAge>> GetReaderAges()
        {
            try
            {
                return await _dbLogic.GetReaderAges();
            }
            catch (Exception)
            {
                //TODO Log the error

                throw;
            }
        }
    }
}
