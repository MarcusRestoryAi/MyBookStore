using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookStore.Model
{
    internal class Author
    {
        [Key, Required]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public int Age { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
