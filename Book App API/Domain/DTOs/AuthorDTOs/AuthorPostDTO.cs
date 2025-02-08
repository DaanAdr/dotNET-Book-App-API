using System.ComponentModel.DataAnnotations;

namespace Book_App_API.Domain.DTOs.AuthorDTOs
{
    public class AuthorPostDTO
    {
        [Required(ErrorMessage = "Firstname is required.")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Firstname can only contain letters.")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Firstname is required.")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Surname can only contain letters.")]
        public string Surname { get; set; }
    }
}
