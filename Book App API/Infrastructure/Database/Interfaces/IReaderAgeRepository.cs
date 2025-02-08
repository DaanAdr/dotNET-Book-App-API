using Book_App_API.Domain.Entity;

namespace Book_App_API.Infrastructure.Database.Interfaces
{
    public interface IReaderAgeRepository
    {
        Task<List<ReaderAge>> GetAllAsync();
    }
}
