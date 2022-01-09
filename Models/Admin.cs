using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectCoffee.Models
{
    public class Admin
    {
        [Key]
        public string Username { get; set; }
        //[DataType(DataType.Password)]
        //[Required]
        //[StringLength(15,MinimumLength = 8 , ErrorMessage ="Password must be 8 - 15 ")]

        public string Password { get; set; }
    }
}