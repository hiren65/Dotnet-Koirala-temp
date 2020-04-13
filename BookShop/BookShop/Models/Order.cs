using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookShop.Models
{
    public class Order
    {
        [Required]
        [Key]
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        [ForeignKey("CustId")] 
        public int CustId { get;  set; }

        public Customer Customer { get; set; }

        [ForeignKey("BookId")]
        public int BookId { get; set; }
        public Books Books { get; set; }

    }
}