﻿using System.ComponentModel.DataAnnotations;

namespace Book_App_API.Domain.Entity
{
    public class Genre
    {
        [Key]
        public Guid Id { get; set; }
        public string GenreName { get; set; }
    }
}
