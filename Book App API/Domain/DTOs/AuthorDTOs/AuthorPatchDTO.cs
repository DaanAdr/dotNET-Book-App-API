using System.ComponentModel.DataAnnotations;

namespace Book_App_API.Domain.DTOs.AuthorDTOs
{
    public class AuthorPatchDTO
    {
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Firstname can only contain letters.")]
        public string? Firstname { get; set; }  //Nullable to avoid property required error messages

        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Surname can only contain letters.")]
        public string? Surname { get; set; }
    }
}
