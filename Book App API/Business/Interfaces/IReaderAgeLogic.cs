using Book_App_API.Domain.DTOs.ReaderAgeDTOs;

namespace Book_App_API.Logic.Interfaces
{
    public interface IReaderAgeLogic
    {
        Task<List<ReaderAgeGetDTO>> GetAllAsync();
    }
}
