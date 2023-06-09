﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookStore.Model
{
    internal class Book
    {
        [Key, Required]
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        public int Price { get; set; }
        public Author Author { get; set; }
        public ICollection<BookStore> Stores { get; set; }

    }
}
