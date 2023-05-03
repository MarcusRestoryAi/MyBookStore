using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookStore.Model
{
    internal class Store
    {
        [Key, Required]
        public int Id { get; set; }
        [Required]
        public string? StoreName { get; set; }
        public ICollection<BookStore> Books { get; set; }
    }
}
