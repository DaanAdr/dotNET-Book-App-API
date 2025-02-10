using System.ComponentModel.DataAnnotations;

namespace Book_App_API.Domain.Entity
{
    public class BookAuthor
    {
        [Key]
        public int Id { get; set; }

        public int BookId { get; set; }

        public int AuthorId { get; set; }


        public Book Book { get; set; }
        public Author Author { get; set; }
    }
}
