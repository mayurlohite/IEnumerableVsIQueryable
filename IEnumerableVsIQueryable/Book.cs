using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableVsIQueryable
{
    [Table("Books")]
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [StringLength(255)]
        public string? Title { get; set; }
        public decimal Price { get; set; }
    }
}
