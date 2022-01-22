using ProjectCoffee.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectCoffee.Dal
{
    public class CartD : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cart>().ToTable("Cart");

        }

        public DbSet<Cart> Carts { get; set; }
    }
}