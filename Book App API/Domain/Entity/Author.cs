using System.ComponentModel.DataAnnotations;

namespace Book_App_API.Domain.Entity
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
    }
}
