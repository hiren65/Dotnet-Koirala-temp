using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace HelloWorld.Models
{
    public class Customer
    {
        //Data Annotation

        [Required]
        [StringLength(10)]
        public string CustName { get; set; }

        [RegularExpression("^[A-Z]{3,3}[0-9]{4,4}$")]     //("^[A-Z]{3,3}[0-9]{4,4}$")
        [Required]
        [Key]
        public string CustId { get; set; }
    }
}