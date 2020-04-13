using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using BookShop.Models;

namespace BookShop.Dal
{
    public class BooksDal : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Books>().ToTable("tblBooks");
        }

        public DbSet <Books> Books { get; set; }
    }
}