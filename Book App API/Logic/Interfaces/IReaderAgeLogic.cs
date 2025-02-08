using Book_App_API.Domain.DTOs;

namespace Book_App_API.Logic.Interfaces
{
    public interface IReaderAgeLogic
    {
        Task<List<ReaderAgeGetDTO>> GetAllAsync();
    }
}
