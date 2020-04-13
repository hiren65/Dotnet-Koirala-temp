using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookShop.Models;

namespace BookShop.ViewModel
{
    public class BooksAuthorVM
    {
        public Customer customer { get; set; }

        public Books book { get; set; }

        // List of customers
        public List<Customer> MyListOfsustomers { get; set; }


    }
}