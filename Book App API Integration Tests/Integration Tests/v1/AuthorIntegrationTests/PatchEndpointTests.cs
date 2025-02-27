using System.Net;
using System.Text;
using Book_App_API.Domain.DTOs.AuthorDTOs;
using Newtonsoft.Json;

namespace Book_App_API_Integration_Tests.Integration_Tests.v1.AuthorIntegrationTests
{
    public class PatchEndpointTests : IClassFixture<IntegrationTestWebApplicationFactory>
    {
        private readonly HttpClient _client;

        public PatchEndpointTests(IntegrationTestWebApplicationFactory factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task PatchAsync_CorrectInput_ReturnsStatus200Ok()
        {
            // Arrange
            AuthorPatchDTO patchObj = new AuthorPatchDTO
            {
                Firstname = "Joane",
                Surname = "Arc"
            };

            string patchJsonObj = JsonConvert.SerializeObject(patchObj);
            StringContent bodyContent = new StringContent(patchJsonObj, Encoding.UTF8, "application/json");

            // Act
            HttpResponseMessage httpResponsePatch = await _client.PatchAsync("/author/2", bodyContent);
            HttpResponseMessage httpResponseGet = await _client.GetAsync("/author");

            string httpContentPatch = httpResponsePatch.Content.ReadAsStringAsync().Result;
            AuthorGetDTO? author = JsonConvert.DeserializeObject<AuthorGetDTO>(httpContentPatch);

            string httpContentGet = httpResponseGet.Content.ReadAsStringAsync().Result;
            List<AuthorGetDTO>? authors = JsonConvert.DeserializeObject<List<AuthorGetDTO>>(httpContentGet);

            // Assert
            Assert.Equal(expected: HttpStatusCode.OK, actual: httpResponsePatch.StatusCode);
            Assert.Equal(patchObj.Firstname, author.Firstname);
            Assert.Equal(patchObj.Surname, author.Surname);
            Assert.Equal(2, author.Id);

            // Check if the value really has been added to the database
            AuthorGetDTO? changedAuthor = authors.FirstOrDefault(x => x.Id == 2);

            Assert.Equal(author.Id, changedAuthor.Id);
            Assert.Equal(author.Firstname, changedAuthor.Firstname);
            Assert.Equal(author.Surname, changedAuthor.Surname);
        }

        [Fact]
        public async Task PatchAsync_FirstnameContainsANumber_ReturnsStatus404BadRequest()
        {
            // Arrange
            AuthorPatchDTO patchObj = new AuthorPatchDTO
            {
                Firstname = "J0ane",
                Surname = "Arc"
            };

            string patchJsonObj = JsonConvert.SerializeObject(patchObj);
            StringContent bodyContent = new StringContent(patchJsonObj, Encoding.UTF8, "application/json");

            // Act
            HttpResponseMessage httpResponse = await _client.PatchAsync("/author/2", bodyContent);

            string httpContent = httpResponse.Content.ReadAsStringAsync().Result;
            ErrorResponse? errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(httpContent);

            // Assert
            Assert.Equal(expected: HttpStatusCode.BadRequest, actual: httpResponse.StatusCode);
            Assert.Contains("Firstname can only contain letters.", errorResponse.Errors["Firstname"]);
        }

        [Fact]
        public async Task PatchAsync_FirstnameContainsASpecialCharacter_ReturnsStatus404BadRequest()
        {
            // Arrange
            AuthorPatchDTO patchObj = new AuthorPatchDTO
            {
                Firstname = "Joa^e",
                Surname = "Arc"
            };

            string patchJsonObj = JsonConvert.SerializeObject(patchObj);
            StringContent bodyContent = new StringContent(patchJsonObj, Encoding.UTF8, "application/json");

            // Act
            HttpResponseMessage httpResponse = await _client.PatchAsync("/author/2", bodyContent);

            string httpContent = httpResponse.Content.ReadAsStringAsync().Result;
            ErrorResponse? errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(httpContent);

            // Assert
            Assert.Equal(expected: HttpStatusCode.BadRequest, actual: httpResponse.StatusCode);
            Assert.Contains("Firstname can only contain letters.", errorResponse.Errors["Firstname"]);
        }

        [Fact]
        public async Task PatchAsync_SurnameContainsANumber_ReturnsStatus404BadRequest()
        {
            // Arrange
            AuthorPatchDTO patchObj = new AuthorPatchDTO
            {
                Firstname = "Joane",
                Surname = "4rc"
            };

            string patchJsonObj = JsonConvert.SerializeObject(patchObj);
            StringContent bodyContent = new StringContent(patchJsonObj, Encoding.UTF8, "application/json");

            // Act
            HttpResponseMessage httpResponse = await _client.PatchAsync("/author/2", bodyContent);

            string httpContent = httpResponse.Content.ReadAsStringAsync().Result;
            ErrorResponse? errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(httpContent);

            // Assert
            Assert.Equal(expected: HttpStatusCode.BadRequest, actual: httpResponse.StatusCode);
            Assert.Contains("Surname can only contain letters.", errorResponse.Errors["Surname"]);
        }

        [Fact]
        public async Task PatchAsync_SurnameContainsASpecialCharacter_ReturnsStatus404BadRequest()
        {
            // Arrange
            AuthorPatchDTO patchObj = new AuthorPatchDTO
            {
                Firstname = "Joane",
                Surname = "Ar<"
            };

            string patchJsonObj = JsonConvert.SerializeObject(patchObj);
            StringContent bodyContent = new StringContent(patchJsonObj, Encoding.UTF8, "application/json");

            // Act
            HttpResponseMessage httpResponse = await _client.PatchAsync("/author/2", bodyContent);

            string httpContent = httpResponse.Content.ReadAsStringAsync().Result;
            ErrorResponse? errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(httpContent);

            // Assert
            Assert.Equal(expected: HttpStatusCode.BadRequest, actual: httpResponse.StatusCode);
            Assert.Contains("Surname can only contain letters.", errorResponse.Errors["Surname"]);
        }
    }
}
