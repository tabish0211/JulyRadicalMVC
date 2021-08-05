using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace JulyRadicalMVC.Models
{
    public class BookContext :DbContext
    {
        public BookContext()
            :base("name=constr")
        {

        }

        public DbSet<Book> books { get; set; }
    }
}