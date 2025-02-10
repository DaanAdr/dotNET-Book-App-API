using Book_App_API.Business.Logic;
using Book_App_API.Domain.DTOs.ReaderAgeDTOs;
using Book_App_API.Domain.Entity;
using Book_App_API.Infrastructure.Database.Interfaces;
using Book_App_API.Infrastructure.Database.Seed_data;
using Moq;

namespace Book_App_API_Unit_Tests.Logic_Tests
{
    //public class ReaderAgeLogicTests
    //{
    //    private readonly Mock<IReaderAgeRepository> _mockRepository;
    //    private readonly ReaderAgeLogic _readerAgeLogic;

    //    public ReaderAgeLogicTests()
    //    {
    //        _mockRepository = new Mock<IReaderAgeRepository>();
    //        _readerAgeLogic = new ReaderAgeLogic(_mockRepository.Object);
    //    }

    //    [Fact]
    //    public async Task GetAllAsync_ReturnsListOfReaderAgeGetDTO()
    //    {
    //        // Arrange
    //        List<ReaderAge> readerAges = new List<ReaderAge>
    //        {
    //            BooksSeedData.readerAgeSeedData[0],
    //            BooksSeedData.readerAgeSeedData[1]
    //        };

    //        _mockRepository.Setup(repo => repo.GetAllAsync()).ReturnsAsync(readerAges);

    //        // Act
    //        List<ReaderAgeGetDTO> result = await _readerAgeLogic.GetAllAsync();

    //        // Assert
    //        Assert.NotNull(result);
    //        Assert.Equal(2, result.Count);
    //        Assert.Equal(readerAges[0].Id, result[0].Id);
    //        Assert.Equal(readerAges[0].AgeRange, result[0].AgeRange);
    //        Assert.Equal(readerAges[1].AgeRange, result[1].AgeRange);
    //        Assert.Equal(readerAges[1].Id, result[1].Id);
    //    }

    //    [Fact]
    //    public async Task GetAllAsync_ThrowsException_WhenRepositoryThrows()
    //    {
    //        // Arrange
    //        _mockRepository.Setup(repo => repo.GetAllAsync()).ThrowsAsync(new Exception("Database error"));

    //        // Act & Assert
    //        await Assert.ThrowsAsync<Exception>(() => _readerAgeLogic.GetAllAsync());
    //    }
    //}
}