using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookShop.Models
{
    public class Customer
    {
        [StringLength(15)]
        [Required]
        public  string CustName  { get; set; }
        
        public int CustMobile { get; set; }

        [Required]
        [Key]
        public int CustId { get; set; }
    }
}