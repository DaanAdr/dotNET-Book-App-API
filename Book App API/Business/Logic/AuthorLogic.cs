using Book_App_API.Domain.DTOs.AuthorDTOs;
using Book_App_API.Domain.Entity;
using Book_App_API.Infrastructure.Database.Interfaces;
using Book_App_API.Logic.Interfaces;

namespace Book_App_API.Business.Logic
{
    public class AuthorLogic : IAuthorLogic
    {
        private readonly IAuthorRepository _dbLogic;

        public AuthorLogic(IAuthorRepository databaseLogic)
        {
            _dbLogic = databaseLogic;
        }

        public async Task<List<AuthorGetDTO>> GetAllAsync()
        {
            try
            {
                List<Author> authors = await _dbLogic.GetAllAsync();
                List<AuthorGetDTO> dtos = ConvertAllToGetDTO(authors);
                return dtos;
            }
            catch (Exception)
            {
                //TODO Log the error

                throw;
            }
        }

        private AuthorGetDTO ConvertToGetDTO(Author author)
        {
            return new AuthorGetDTO
            {
                Id = author.Id,
                Firstname = author.Firstname,
                Surname = author.Surname,
            };
        }

        private List<AuthorGetDTO> ConvertAllToGetDTO(List<Author> authors)
        {
            List<AuthorGetDTO> dtos = new List<AuthorGetDTO>();

            foreach (Author author in authors)
            {
                AuthorGetDTO dto = ConvertToGetDTO(author);
                dtos.Add(dto);
            }

            return dtos;
        }

        public async Task<Author> PostAsync(AuthorPostDTO author)
        {
            try
            {
                Author newAuthor = ConvertPostDtoToEntity(author);

                return await _dbLogic.PostAsync(newAuthor);
            }
            catch (Exception)
            {
                //TODO Log the error

                throw;
            }
        }

        private Author ConvertPostDtoToEntity(AuthorPostDTO author)
        {
            Author newAuthor = new Author()
            {
                Firstname = author.Firstname,
                Surname = author.Surname,
            };

            return newAuthor;
        }

        public async Task<Author> PatchAsync(string id, AuthorPatchDTO authorPatch)
        {
            try
            {
                //Find author at ID
                Author? author = await _dbLogic.GetByIdAsync(Guid.Parse(id));

                //If no author found, return error
                if (author == null)
                {
                    throw new KeyNotFoundException($"Author with ID {id} not found.");
                }

                //Apply changes from patchDTO
                ApplyPatchData(author, authorPatch);

                //Save patch data to database
                return await _dbLogic.PatchAsync(author);
            }
            catch (Exception)
            {
                //TODO Log the error

                throw;
            }
        }

        /// <summary>
        /// Apply the data in authorPatch to author
        /// </summary>
        /// <param name="author">The object to patch</param>
        /// <param name="authorPatch">Data to patch author with</param>
        private void ApplyPatchData(Author author, AuthorPatchDTO authorPatch)
        {
            //Patch firstname if necessary
            if (authorPatch.Firstname != null)
            {
                author.Firstname = authorPatch.Firstname;
            }

            //Patch surname if necessary
            if (authorPatch.Surname != null)
            {
                author.Surname = authorPatch.Surname;
            }
        }

        public async Task<bool> DeleteAsync(string id)
        {
            try
            {
                return await _dbLogic.DeleteAsync(Guid.Parse(id));
            }
            catch (Exception)
            {
                //TODO Log the error

                throw;
            }
        }
    }
}
