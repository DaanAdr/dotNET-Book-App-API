using Book_App_API.Domain.Entity;

namespace Book_App_API.Infrastructure.Database.Interfaces
{
    public interface IAuthorRepository
    {
        public Task<List<Author>> GetAllAsync();

        public  Task<Author?> GetByIdAsync(Guid id);

        public Task<Author> PostAsync(Author author);

        public Task<Author> PatchAsync(Author author);

        public Task<bool> DeleteAsync(Guid id);
    }
}
