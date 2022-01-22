namespace ProjectCoffee.Models
{
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


    public partial class Cart
    {
        [Key]
        public string Product { get; set; }
        public int Quantity { get; set; }
        public string message { get; set; }

    }
}