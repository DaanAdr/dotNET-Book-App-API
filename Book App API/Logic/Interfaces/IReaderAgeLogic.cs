using Book_App_API.Domain.Entity;

namespace Book_App_API.Logic.Interfaces
{
    public interface IReaderAgeLogic
    {
        Task<List<ReaderAge>> GetAllAsync();
    }
}
