using System.ComponentModel.DataAnnotations;

namespace Book_App_API.Domain.Entity
{
    public class BookGenre
    {
        [Key]
        public int Id { get; set; }

        public int BookId { get; set; }

        public int GenreId { get; set; }

        public Book Book { get; set; }
        public Genre Genre { get; set; }
    }
}
