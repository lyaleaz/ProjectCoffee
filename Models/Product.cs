
namespace ProjectCoffee.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Product
    {
        [Key]
        public string NameProduct { get; set; }
        public string price { get; set; }
        public string image { get; set; }
    }
}
