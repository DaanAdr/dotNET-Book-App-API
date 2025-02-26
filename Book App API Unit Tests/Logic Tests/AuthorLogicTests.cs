using Book_App_API.Business.Logic;
using Book_App_API.Domain.DTOs.AuthorDTOs;
using Book_App_API.Domain.Entity;
using Book_App_API.Infrastructure.Database.Interfaces;
using Book_App_API.Infrastructure.Database.Seed_data;
using Moq;

namespace Book_App_API_Unit_Tests.Logic_Tests
{
    public class AuthorLogicTests
    {
        private readonly Mock<IAuthorRepository> _mockRepository;
        private readonly AuthorLogic _authorLogic;

        public AuthorLogicTests()
        {
            _mockRepository = new Mock<IAuthorRepository>();
            _authorLogic = new AuthorLogic(_mockRepository.Object);
        }

        #region GetAllAsync Tests
        [Fact]
        public async Task GetAllAsync_ReturnsListOfAuthors()
        {
            //Arrange
            List<Author> authors = new List<Author>()
            {
                BooksSeedData.authorSeedData[1],
                BooksSeedData.authorSeedData[3],
            };

            _mockRepository.Setup(repo => repo.GetAllAsync()).ReturnsAsync(authors);

            //Act
            List<AuthorGetAndDeleteDTO> result = await _authorLogic.GetAllAsync();

            //Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
            Assert.Equal(authors[0].Id, result[0].Id);
            Assert.Equal(authors[0].Firstname, result[0].Firstname);
            Assert.Equal(authors[0].Surname, result[0].Surname);
            Assert.Equal(authors[1].Surname, result[1].Surname);
            Assert.Equal(authors[1].Firstname, result[1].Firstname);
            Assert.Equal(authors[1].Id, result[1].Id);
        }

        [Fact]
        public async Task GetAllAsync_ThrowsException_WhenRepositoryThrows()
        {
            // Arrange
            _mockRepository.Setup(repo => repo.GetAllAsync()).ThrowsAsync(new Exception("Database error"));

            // Act & Assert
            await Assert.ThrowsAsync<Exception>(() => _authorLogic.GetAllAsync());
        }
        #endregion
    }
}
