using Book_App_API.Domain.DTOs.ReaderAgeDTOs;
using Book_App_API.Domain.Entity;
using Book_App_API.Infrastructure.Database.Interfaces;
using Book_App_API.Logic.Interfaces;

namespace Book_App_API.Business.Logic
{
    public class ReaderAgeLogic : IReaderAgeLogic
    {
        private readonly IReaderAgeRepository _dbLogic;

        public ReaderAgeLogic(IReaderAgeRepository databaseLogic)
        {
            _dbLogic = databaseLogic;
        }

        public async Task<List<ReaderAgeGetDTO>> GetAllAsync()
        {
            try
            {
                List<ReaderAge> readerAges = await _dbLogic.GetAllAsync();
                List<ReaderAgeGetDTO> dtos = ConvertAllToDTO(readerAges);
                return dtos;
            }
            catch (Exception)
            {
                //TODO Log the error

                throw;
            }
        }

        private ReaderAgeGetDTO ConvertToDTO(ReaderAge readerAge)
        {
            return new ReaderAgeGetDTO
            {
                Id = readerAge.Id,
                AgeRange = readerAge.AgeRange,
            };
        }

        private List<ReaderAgeGetDTO> ConvertAllToDTO(List<ReaderAge> readerAges)
        {
            List<ReaderAgeGetDTO> dtos = new List<ReaderAgeGetDTO>();

            foreach (ReaderAge readerAge in readerAges)
            {
                ReaderAgeGetDTO dto = ConvertToDTO(readerAge);
                dtos.Add(dto);
            }

            return dtos;
        }
    }
}
