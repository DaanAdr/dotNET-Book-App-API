using Book_App_API.Domain.DTOs.BookDTOs;

namespace Book_App_API.Logic.Interfaces
{
    public interface IBookLogic
    {
        Task<List<BookGetDTO>> GetAllAsync();
    }
}
