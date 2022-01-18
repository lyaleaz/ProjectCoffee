using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectCoffee.Models
{
    public class Product
    {
        [Key]
        public string NameProduct { get; set; }
        public string price { get; set; }
        public string image { get; set; } 

    }
}