using System.ComponentModel.DataAnnotations;

namespace Book_App_API.Domain.Entity
{
    public class ReaderAge
    {
        [Key]
        public Guid Id { get; set; }
        public string AgeRange { get; set; }
    }
}
