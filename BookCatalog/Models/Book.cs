using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookCatalog.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        [Range(1, 10, ErrorMessage = "Rating must be between 1 and 10")]
        public int Range { get; set; }
    }
}
