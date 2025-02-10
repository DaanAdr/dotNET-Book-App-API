using System.ComponentModel.DataAnnotations;

namespace Book_App_API.Domain.DTOs.AuthorDTOs
{
    public class AuthorGetDTO
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
    }
}
