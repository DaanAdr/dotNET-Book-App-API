﻿using System.ComponentModel.DataAnnotations;

namespace Book_App_API.Domain.Entity
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int ReaderAgeId { get; set; }
        public DateTime PublishDate { get; set; }
        public int Pages { get; set; }


        public ReaderAge ReaderAge { get; set; }

        public ICollection<BookAuthor> BookAuthors { get; set; }

        public ICollection<BookGenre> BookGenres { get; set; }
    }
}
