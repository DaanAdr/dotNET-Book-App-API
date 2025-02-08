using Book_App_API.Domain.DTO;

namespace Book_App_API.Logic.Interfaces
{
    public interface IBookLogic
    {
        Task<List<BookGetDTO>> GetAllAsync();
    }
}
