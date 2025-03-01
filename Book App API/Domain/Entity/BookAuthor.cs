﻿using System.ComponentModel.DataAnnotations;

namespace Book_App_API.Domain.Entity
{
    public class BookAuthor
    {
        [Key]
        public Guid Id { get; set; }

        public Guid BookId { get; set; }

        public Guid AuthorId { get; set; }


        public Book Books { get; set; }
        public Author Author { get; set; }
    }
}
