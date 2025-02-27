using System.Net;
using Book_App_API.Domain.DTOs.AuthorDTOs;
using Book_App_API.Infrastructure.Database.Seed_data;
using Newtonsoft.Json;

namespace Book_App_API_Integration_Tests.Integration_Tests.v1.AuthorIntegrationTests
{
    public class GetEndpointTests : IClassFixture<IntegrationTestWebApplicationFactory>
    {
        private readonly HttpClient _client;

        public GetEndpointTests(IntegrationTestWebApplicationFactory factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task GetAsync_GetAllAuthors_ReturnsStatus200Ok()
        {
            // Act
            HttpResponseMessage httpResponse = await _client.GetAsync("/author");
            string httpContent = httpResponse.Content.ReadAsStringAsync().Result;
            List<AuthorGetDTO>? authors = JsonConvert.DeserializeObject<List<AuthorGetDTO>>(httpContent);

            // Assert
            Assert.Equal(expected: HttpStatusCode.OK, actual: httpResponse.StatusCode);

            List<Book_App_API.Domain.Entity.Author> seedData = BooksSeedData.authorSeedData;
            int index = 0;

            foreach (AuthorGetDTO author in authors)
            {
                Book_App_API.Domain.Entity.Author seededAuthor = seedData[index];

                Assert.Equal(seededAuthor.Id, author.Id);
                Assert.Equal(seededAuthor.Firstname, author.Firstname);
                Assert.Equal(seededAuthor.Surname, author.Surname);

                index++;
            }
        }
    }
}
