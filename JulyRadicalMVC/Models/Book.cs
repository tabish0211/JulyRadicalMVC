using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JulyRadicalMVC.Models
{
    public class Book
    {
        [Required(ErrorMessage="This should be input")]
        public string Name { get; set; }
        public string  Description { get; set; }
    }
}