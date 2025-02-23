using System.Net;
using System.Text;
using System.Transactions;
using Book_App_API.Domain.DTOs.AuthorDTOs;
using Book_App_API.Infrastructure.Database.Seed_data;
using Newtonsoft.Json;

namespace Book_App_API_Integration_Tests
{
    public class AuthorIntegrationTest : IClassFixture<IntegrationTestWebApplicationFactory>
    {
        private readonly HttpClient _client;

        public AuthorIntegrationTest(IntegrationTestWebApplicationFactory factory)
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

        [Fact]
        public async Task PostAsync_CreateAuthor_ReturnsStatus201Created()
        {
            // Arrange
            AuthorPostDTO postObj = new AuthorPostDTO
            {
                Firstname = "Nigel",
                Surname = "Young"
            };

            string postJsonObj = JsonConvert.SerializeObject(postObj);
            StringContent bodyContent = new StringContent(postJsonObj, Encoding.UTF8, "application/json");

            // Act
            HttpResponseMessage httpResponse = new HttpResponseMessage();

            using (TransactionScope transaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                httpResponse = await _client.PostAsync("/author", bodyContent);
            }

            string httpContent = httpResponse.Content.ReadAsStringAsync().Result;
            AuthorGetDTO author = JsonConvert.DeserializeObject<AuthorGetDTO>(httpContent);

            // Assert
            Assert.Equal(expected: HttpStatusCode.Created, actual: httpResponse.StatusCode);
            Assert.Equal(postObj.Firstname, author.Firstname);
            Assert.Equal(postObj.Surname, author.Surname);
            Assert.Equal(13, author.Id);
        }
    }
}