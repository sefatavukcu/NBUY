using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitabeviApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int WriteYear { get; set; }
        public int PageNumber { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public Category Category { get; set; }
        public Author Author { get; set; }
    }
}