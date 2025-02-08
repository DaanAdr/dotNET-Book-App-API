namespace Book_App_API.Domain.DTOs.BookDTOs
{
    public class BookGetDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ReaderAge { get; set; }
        public DateTime PublishDate { get; set; }
        public int Pages { get; set; }

        public List<string> Authors { get; set; }
        public List<string> Genres { get; set; }
    }
}
