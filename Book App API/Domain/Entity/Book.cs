using System.ComponentModel.DataAnnotations;

namespace Book_App_API.Domain.Entity
{
    public class Book
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Guid ReaderAgeId { get; set; }
        public DateTime PublishDate { get; set; }
        public int Pages { get; set; }
    }
}
