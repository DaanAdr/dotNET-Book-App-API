using System.Net;
using System.Text;
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
        #endregion

        #region PATCH
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
        #endregion

        #region DELETE
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
        #endregion
    }
}