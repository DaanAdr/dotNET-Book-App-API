using Book_App_API.Domain.Entity;
using Book_App_API.Infrastructure.Database.DatabaseLogic;

namespace Book_App_API.Logic
{
    public class BookLogic
    {
        private readonly BookDatabaseLogic _dbLogic;

        public BookLogic(BookDatabaseLogic bookDatabaseLogic)
        {
            _dbLogic = bookDatabaseLogic;
        }

        public async Task<List<Book>> GetBook()
        {
            try
            {
                return await _dbLogic.GetBook();
            }
            catch (Exception)
            {
                //TODO Log the error

                throw;
            }
        }
    }
}
