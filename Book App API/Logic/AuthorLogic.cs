using Book_App_API.Domain.DTO;
using Book_App_API.Domain.Entity;
using Book_App_API.Infrastructure.Database.DatabaseLogic;

namespace Book_App_API.Logic
{
    public class AuthorLogic
    {
        private readonly AuthorDatabaseLogic _dbLogic;

        public AuthorLogic(AuthorDatabaseLogic databaseLogic)
        {
            _dbLogic = databaseLogic;
        }

        public async Task<List<Author>> GetAuthors()
        {
            try
            {
                return await _dbLogic.GetAllAsync();
            }
            catch (Exception)
            {
                //TODO Log the error

                throw;
            }
        }

        public async Task<Author> PostAuthor(AuthorPostDTO author)
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

        public async Task<Author> PatchAuthor(string id, AuthorPatchDTO authorPatch)
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
            if(authorPatch.Firstname != null)
            {
                author.Firstname = authorPatch.Firstname;
            }

            //Patch surname if necessary
            if(authorPatch.Surname != null)
            {
                author.Surname = authorPatch.Surname;
            }
        }

        public async Task<bool> DeleteAuthor(string id)
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
