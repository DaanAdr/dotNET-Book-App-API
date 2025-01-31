using System.ComponentModel.DataAnnotations;

namespace Book_App_API.Domain.Entity
{
    public class BookGenre
    {
        [Key]
        public Guid Id { get; set; }

        public Guid BookId { get; set; }

        public Guid GenreId { get; set; }

        public Book Book { get; set; }
        public Genre Genre { get; set; }
    }
}
