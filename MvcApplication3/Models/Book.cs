﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication3.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Writer { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }
        public string Genre { get; set; }
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }

    public class BookDBContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}