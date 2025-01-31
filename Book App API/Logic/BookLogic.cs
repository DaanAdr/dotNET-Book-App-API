using Book_App_API.Domain.DTO;
using Book_App_API.Domain.Entity;
using Book_App_API.Infrastructure.Database.DatabaseLogic;

namespace Book_App_API.Logic
{
    public class BookLogic
    {
        private readonly BookDatabaseLogic _dbLogic;

        public BookLogic(BookDatabaseLogic bookDatabaseLogic)
        {
            _dbLogic = bookDatabaseLogic;
        }

        public async Task<List<BookGetDTO>> GetBook()
        {
            try
            {
                List<Book> unmappedBooks = await _dbLogic.GetAllAsync();

                return MapBookToGetDTO(unmappedBooks);
            }
            catch (Exception)
            {
                //TODO Log the error

                throw;
            }
        }

        private List<BookGetDTO> MapBookToGetDTO(List<Book> books)
        {
            List<BookGetDTO> mappedBooks = new List<BookGetDTO>();  

            foreach (Book book in books)
            {
                //Create list of authors
                List<string> authors = new List<string>();

                foreach(BookAuthor author in book.BookAuthors)
                {
                    string authorName = $"{author.Author.Firstname} {author.Author.Surname}";
                    authors.Add(authorName);
                }

                //Create list of genres
                List<string> genres = new List<string>();

                foreach(BookGenre genre in book.BookGenres)
                {
                    genres.Add(genre.Genre.GenreName);
                }

                //Map book to BookGetDTO
                BookGetDTO mappedBook = new BookGetDTO
                {
                    Id = book.Id,
                    Title = book.Title,
                    ReaderAge = book.ReaderAge.AgeRange,
                    Pages = book.Pages,
                    PublishDate = book.PublishDate,
                    Authors = authors,
                    Genres = genres,
                };

                mappedBooks.Add(mappedBook);
            }

            return mappedBooks;
        }
    }
}
