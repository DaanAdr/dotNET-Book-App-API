namespace Book_App_API.Logic.Interfaces
{
    public interface IGenreLogic
    {
        Task<List<Genre>> GetAllAsync()
    }
}
