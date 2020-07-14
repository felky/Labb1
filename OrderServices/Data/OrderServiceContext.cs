using Microsoft.EntityFrameworkCore;
using OrderServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServices.Data
{
    public class OrderServiceContext : DbContext
    {
        public OrderServiceContext()
        {

        }

        public OrderServiceContext(DbContextOptions<OrderServiceContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = (localdb)\\MSSQLLocalDB; Database = FelixGramell_Labb1_DB; Trusted_Connection = True;");
            }
        }

        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderLine> OrderLine { get; set; }
        public DbSet<ShoppingCart> ShoppingCart { get; set; }
    }
}
