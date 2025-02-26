using Book_App_API.Domain.DTOs.GenreDTOs;
using Book_App_API.Domain.Entity;
using Book_App_API.Infrastructure.Database.Logic;

namespace Book_App_API.Business.Logic
{
    public class GenreLogic 
    {
        private readonly GenreRepository _dbLogic;

        public GenreLogic(GenreRepository databaseLogic)
        {
            _dbLogic = databaseLogic;
        }

        public async Task<List<GenreGetDTO>> GetAllAsync()
        {
            try
            {
                List<Genre> genres = await _dbLogic.GetAllAsync();
                List<GenreGetDTO> dtos = ConvertAllToDTO(genres);
                return dtos;
            }
            catch (Exception)
            {
                //TODO Log the error

                throw;
            }
        }

        private GenreGetDTO ConvertToDTO(Genre genre)
        {
            return new GenreGetDTO
            {
                Id = genre.Id,
                GenreName = genre.GenreName,
            };
        }

        private List<GenreGetDTO> ConvertAllToDTO(List<Genre> genres)
        {
            List<GenreGetDTO> dtos = new List<GenreGetDTO>();

            foreach (Genre genre in genres)
            {
                GenreGetDTO dto = ConvertToDTO(genre);
                dtos.Add(dto);
            }

            return dtos;
        }
    }
}
