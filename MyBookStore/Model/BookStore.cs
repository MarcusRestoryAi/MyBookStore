using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookStore.Model
{
    internal class BookStore
    {
        [Key]
        public int Id { get; set; }
        public Book Book { get; set; }
        public Store Store { get; set; }
    }
}
