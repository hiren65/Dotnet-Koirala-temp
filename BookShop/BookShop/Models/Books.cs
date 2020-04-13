using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookShop.Models
{
    public class Books
    {
        [Required]
        [StringLength(15)]
        public string BookName { get; set; }
        [Required]
        [StringLength(15)]
        public string Author { get; set; }
        [Required]
        [Key]
        public int BookId { get; set; }
    }
}