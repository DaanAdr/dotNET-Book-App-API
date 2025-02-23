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

        #region POST
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
            HttpResponseMessage httpResponsePost = new HttpResponseMessage();
            HttpResponseMessage httpResponseGet = new HttpResponseMessage();

            using (TransactionScope transaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                httpResponsePost = await _client.PostAsync("/author", bodyContent);
                httpResponseGet = await _client.GetAsync("/author");
            }

            string httpContentPost = httpResponsePost.Content.ReadAsStringAsync().Result;
            AuthorGetDTO? author = JsonConvert.DeserializeObject<AuthorGetDTO>(httpContentPost);

            string httpContentGet = httpResponseGet.Content.ReadAsStringAsync().Result;
            List<AuthorGetDTO>? authors = JsonConvert.DeserializeObject<List<AuthorGetDTO>>(httpContentGet);

            // Assert
            Assert.Equal(expected: HttpStatusCode.Created, actual: httpResponsePost.StatusCode);
            Assert.Equal(postObj.Firstname, author.Firstname);
            Assert.Equal(postObj.Surname, author.Surname);
            Assert.Equal(13, author.Id);

            Assert.Equal(13, authors.Count());
            Assert.Equal(author, authors[12]);
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
            HttpResponseMessage httpResponse = new HttpResponseMessage();

            using (TransactionScope transaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                httpResponse = await _client.PostAsync("/author", bodyContent);
            }

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
            HttpResponseMessage httpResponse = new HttpResponseMessage();

            using (TransactionScope transaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                httpResponse = await _client.PostAsync("/author", bodyContent);
            }

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
            HttpResponseMessage httpResponse = new HttpResponseMessage();

            using (TransactionScope transaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                httpResponse = await _client.PostAsync("/author", bodyContent);
            }

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
            HttpResponseMessage httpResponse = new HttpResponseMessage();

            using (TransactionScope transaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                httpResponse = await _client.PostAsync("/author", bodyContent);
            }

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
            HttpResponseMessage httpResponse = new HttpResponseMessage();

            using (TransactionScope transaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                httpResponse = await _client.PostAsync("/author", bodyContent);
            }

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
            HttpResponseMessage httpResponse = new HttpResponseMessage();

            using (TransactionScope transaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                httpResponse = await _client.PostAsync("/author", bodyContent);
            }

            string httpContent = httpResponse.Content.ReadAsStringAsync().Result;
            ErrorResponse? errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(httpContent);

            // Assert
            Assert.Equal(expected: HttpStatusCode.BadRequest, actual: httpResponse.StatusCode);
            Assert.Contains("Surname can only contain letters.", errorResponse.Errors["Surname"]);
        }
        #endregion
    }
}