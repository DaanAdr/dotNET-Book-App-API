using System.Net;
using System.Text;
using Book_App_API.Domain.DTOs.AuthorDTOs;
using Newtonsoft.Json;

namespace Book_App_API_Integration_Tests.Integration_Tests.v1.AuthorIntegrationTests
{
    public class PostEndpointTests : IClassFixture<IntegrationTestWebApplicationFactory>
    {
        private readonly HttpClient _client;

        public PostEndpointTests(IntegrationTestWebApplicationFactory factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task PostAsync_CorrectInput_ReturnsStatus201Created()
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
            HttpResponseMessage httpResponsePost = await _client.PostAsync("/author", bodyContent);
            HttpResponseMessage httpResponseGet = await _client.GetAsync("/author");

            string httpContentPost = httpResponsePost.Content.ReadAsStringAsync().Result;
            AuthorGetDTO? author = JsonConvert.DeserializeObject<AuthorGetDTO>(httpContentPost);

            string httpContentGet = httpResponseGet.Content.ReadAsStringAsync().Result;
            List<AuthorGetDTO>? authors = JsonConvert.DeserializeObject<List<AuthorGetDTO>>(httpContentGet);

            // Assert
            Assert.Equal(expected: HttpStatusCode.Created, actual: httpResponsePost.StatusCode);
            Assert.Equal(postObj.Firstname, author.Firstname);
            Assert.Equal(postObj.Surname, author.Surname);
            Assert.Equal(13, author.Id);

            // Check if the value really has been added to the database
            AuthorGetDTO authorInDb = authors[12];

            Assert.Equal(13, authors.Count());
            Assert.Equal(author.Id, authorInDb.Id);
            Assert.Equal(author.Firstname, authorInDb.Firstname);
            Assert.Equal(author.Surname, authorInDb.Surname);
        }

        [Fact]
        public async Task PostAsync_FirstnameIsEmpty_ReturnsStatus404BadRequest()
        {
            // Arrange
            AuthorPostDTO postObj = new AuthorPostDTO
            {
                Surname = "Young"
            };

            string postJsonObj = JsonConvert.SerializeObject(postObj);
            StringContent bodyContent = new StringContent(postJsonObj, Encoding.UTF8, "application/json");

            // Act
            HttpResponseMessage httpResponse = await _client.PostAsync("/author", bodyContent);

            string httpContent = httpResponse.Content.ReadAsStringAsync().Result;
            ErrorResponse? errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(httpContent);

            // Assert
            Assert.Equal(expected: HttpStatusCode.BadRequest, actual: httpResponse.StatusCode);
            Assert.Contains("Firstname is required.", errorResponse.Errors["Firstname"]);
        }

        [Fact]
        public async Task PostAsync_FirstnameContainsANumber_ReturnsStatus404BadRequest()
        {
            // Arrange
            AuthorPostDTO postObj = new AuthorPostDTO
            {
                Firstname = "N1gel",
                Surname = "Young"
            };

            string postJsonObj = JsonConvert.SerializeObject(postObj);
            StringContent bodyContent = new StringContent(postJsonObj, Encoding.UTF8, "application/json");

            // Act
            HttpResponseMessage httpResponse = await _client.PostAsync("/author", bodyContent);

            string httpContent = httpResponse.Content.ReadAsStringAsync().Result;
            ErrorResponse? errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(httpContent);

            // Assert
            Assert.Equal(expected: HttpStatusCode.BadRequest, actual: httpResponse.StatusCode);
            Assert.Contains("Firstname can only contain letters.", errorResponse.Errors["Firstname"]);
        }

        [Fact]
        public async Task PostAsync_FirstnameContainsASpecialCharacter_ReturnsStatus404BadRequest()
        {
            // Arrange
            AuthorPostDTO postObj = new AuthorPostDTO
            {
                Firstname = "Ni*el",
                Surname = "Young"
            };

            string postJsonObj = JsonConvert.SerializeObject(postObj);
            StringContent bodyContent = new StringContent(postJsonObj, Encoding.UTF8, "application/json");

            // Act
            HttpResponseMessage httpResponse = await _client.PostAsync("/author", bodyContent);

            string httpContent = httpResponse.Content.ReadAsStringAsync().Result;
            ErrorResponse? errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(httpContent);

            // Assert
            Assert.Equal(expected: HttpStatusCode.BadRequest, actual: httpResponse.StatusCode);
            Assert.Contains("Firstname can only contain letters.", errorResponse.Errors["Firstname"]);
        }

        [Fact]
        public async Task PostAsync_SurnameIsEmpty_ReturnsStatus404BadRequest()
        {
            // Arrange
            AuthorPostDTO postObj = new AuthorPostDTO
            {
                Firstname = "Ni*el"
            };

            string postJsonObj = JsonConvert.SerializeObject(postObj);
            StringContent bodyContent = new StringContent(postJsonObj, Encoding.UTF8, "application/json");

            // Act
            HttpResponseMessage httpResponse = await _client.PostAsync("/author", bodyContent);

            string httpContent = httpResponse.Content.ReadAsStringAsync().Result;
            ErrorResponse? errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(httpContent);

            // Assert
            Assert.Equal(expected: HttpStatusCode.BadRequest, actual: httpResponse.StatusCode);
            Assert.Contains("Surname is required.", errorResponse.Errors["Surname"]);
        }

        [Fact]
        public async Task PostAsync_SurnameContainsANumber_ReturnsStatus404BadRequest()
        {
            // Arrange
            AuthorPostDTO postObj = new AuthorPostDTO
            {
                Firstname = "Nigel",
                Surname = "Y0ung"
            };

            string postJsonObj = JsonConvert.SerializeObject(postObj);
            StringContent bodyContent = new StringContent(postJsonObj, Encoding.UTF8, "application/json");

            // Act
            HttpResponseMessage httpResponse = await _client.PostAsync("/author", bodyContent);

            string httpContent = httpResponse.Content.ReadAsStringAsync().Result;
            ErrorResponse? errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(httpContent);

            // Assert
            Assert.Equal(expected: HttpStatusCode.BadRequest, actual: httpResponse.StatusCode);
            Assert.Contains("Surname can only contain letters.", errorResponse.Errors["Surname"]);
        }

        [Fact]
        public async Task PostAsync_SurnameContainsASpecialCharacter_ReturnsStatus404BadRequest()
        {
            // Arrange
            AuthorPostDTO postObj = new AuthorPostDTO
            {
                Firstname = "Nigel",
                Surname = "You#g"
            };

            string postJsonObj = JsonConvert.SerializeObject(postObj);
            StringContent bodyContent = new StringContent(postJsonObj, Encoding.UTF8, "application/json");

            // Act
            HttpResponseMessage httpResponse = await _client.PostAsync("/author", bodyContent);

            string httpContent = httpResponse.Content.ReadAsStringAsync().Result;
            ErrorResponse? errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(httpContent);

            // Assert
            Assert.Equal(expected: HttpStatusCode.BadRequest, actual: httpResponse.StatusCode);
            Assert.Contains("Surname can only contain letters.", errorResponse.Errors["Surname"]);
        }
    }
}
