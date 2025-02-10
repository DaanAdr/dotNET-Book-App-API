using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_App_API.Business.Logic;
using Book_App_API.Domain.DTOs.GenreDTOs;
using Book_App_API.Domain.Entity;
using Book_App_API.Infrastructure.Database.Interfaces;
using Book_App_API.Infrastructure.Database.Seed_data;
using Book_App_API.Logic.Interfaces;
using Moq;

namespace Book_App_API_Unit_Tests.Logic_Tests
{
    internal class GenreLogicTests
    {
        private readonly Mock<IGenreRepository> _mockRepository;
        private readonly GenreLogic _genreLogic;

        public GenreLogicTests()
        {
            _mockRepository = new Mock<IGenreRepository>();
            _genreLogic = new GenreLogic(_mockRepository.Object);
        }

        [Fact]
        public async Task GetAllAsync_ReturnsListOfGenreGetDTO()
        {
            //Arrange
            List<Genre> genres = new List<Genre>()
            {
                BooksSeedData.genreSeedData[4],
                BooksSeedData.genreSeedData[5]
            };

            _mockRepository.Setup(repo => repo.GetAllAsync()).ReturnsAsync(genres);

            //Act
            List<GenreGetDTO> result = await _genreLogic.GetAllAsync();

            //Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
            Assert.Equal(genres[0].Id, result[0].Id);
            Assert.Equal(genres[0].GenreName, result[0].GenreName);
            Assert.Equal(genres[1].GenreName, result[1].GenreName);
            Assert.Equal(genres[1].Id, result[1].Id);
        }

        [Fact]
        public async Task GetAllAsync_ThrowsException_WhenRepositoryThrows()
        {
            // Arrange
            _mockRepository.Setup(repo => repo.GetAllAsync()).ThrowsAsync(new Exception("Database error"));

            // Act & Assert
            await Assert.ThrowsAsync<Exception>(() => _genreLogic.GetAllAsync());
        }
    }
}
