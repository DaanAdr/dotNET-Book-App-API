using Book_App_API.Domain.DTOs.AuthorDTOs;
using Book_App_API.Domain.Entity;

namespace Book_App_API.Logic.Interfaces
{
    public interface IAuthorLogic
    {
        public Task<List<AuthorGetDTO>> GetAllAsync();

        public Task<Author> PostAsync(AuthorPostDTO author);

        public Task<Author> PatchAsync(string id, AuthorPatchDTO authorPatch);

        public Task<bool> DeleteAsync(string id);
    }
}
