using System.ComponentModel.DataAnnotations;

namespace Book_App_API.Domain.DTO
{
    public class AuthorDTO
    {
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Surname { get; set; }
    }
}
