using System;
using System.Collections.Generic;

namespace BookStore.Data.Models
{
    public partial class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
