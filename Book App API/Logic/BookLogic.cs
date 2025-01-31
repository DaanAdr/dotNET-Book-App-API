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
                List<Book> unmappedBooks = await _dbLogic.GetBook();

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

                //Map book to BookGetDTO
                BookGetDTO mappedBook = new BookGetDTO
                {
                    Id = book.Id,
                    Title = book.Title,
                    ReaderAge = book.ReaderAge.AgeRange,
                    Pages = book.Pages,
                    PublishDate = book.PublishDate,
                    Authors = authors
                };

                mappedBooks.Add(mappedBook);
            }

            return mappedBooks;
        }
    }
}
