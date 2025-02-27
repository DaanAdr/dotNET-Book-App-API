using System.Net;
using Book_App_API.Domain.DTOs.AuthorDTOs;
using Newtonsoft.Json;

namespace Book_App_API_Integration_Tests.Integration_Tests.v1.AuthorIntegrationTests
{
    public class DeleteEndpointTests : IClassFixture<IntegrationTestWebApplicationFactory>
    {
        private readonly HttpClient _client;

        public DeleteEndpointTests(IntegrationTestWebApplicationFactory factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task DeleteAsync_CorrectId_ReturnsStatus200Ok()
        {
            // Act
            HttpResponseMessage httpResponseDelete = await _client.DeleteAsync("/author/3");
            HttpResponseMessage httpResponseGet = await _client.GetAsync("/author");

            string httpContentDelete = httpResponseDelete.Content.ReadAsStringAsync().Result;
            //AuthorGetDTO? author = JsonConvert.DeserializeObject<AuthorGetDTO>(httpContentPost);

            string httpContentGet = httpResponseGet.Content.ReadAsStringAsync().Result;
            List<AuthorGetDTO>? authors = JsonConvert.DeserializeObject<List<AuthorGetDTO>>(httpContentGet);

            // Assert
            Assert.Equal(expected: HttpStatusCode.OK, actual: httpResponseDelete.StatusCode);
            Assert.Equal("Author deleted!", httpContentDelete);

            // Check if the record has been removed from the database
            Assert.False(authors.Exists(x => x.Id == 3));
        }

        [Fact]
        public async Task DeleteAsync_IncorrectId_ReturnsStatus404BadRequest()
        {
            // Act
            HttpResponseMessage httpResponseDelete = await _client.DeleteAsync("/author/103");
            HttpResponseMessage httpResponseGet = await _client.GetAsync("/author");

            string httpContent = httpResponseDelete.Content.ReadAsStringAsync().Result;

            // Assert
            Assert.Equal(expected: HttpStatusCode.NotFound, actual: httpResponseDelete.StatusCode);
            Assert.Equal("Author with ID 103 not found.", httpContent);
        }
    }
}
