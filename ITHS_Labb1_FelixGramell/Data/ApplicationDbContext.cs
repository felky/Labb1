using System;
using System.Collections.Generic;
using System.Text;
using ITHS_Labb1_FelixGramell.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ITHS_Labb1_FelixGramell.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
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



        public DbSet<Product> Product { get; set; }
        public DbSet<Orders> Orders { get; set; } 
        public DbSet<OrderLine> OrderLines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = 1, Name = "Purple mechanical keyboard", Price = 149.99, Img_Url = "https://preview.redd.it/9d69elb5ext41.png?width=1024&auto=webp&s=6c0a8defaaed5d5707e889b10cc1f5e527706b46" },
                new Product() { Id = 2, Name = "Galaxy mechanical keyboard", Price = 249.99, Img_Url = "https://preview.redd.it/cw9ax8o8fws41.png?width=1024&auto=webp&s=c78e19c619bfc72933084710a656f39b2f347eea" },
                new Product() { Id = 3, Name = "Small grey and beige keyboard", Price = 200, Img_Url = "https://preview.redd.it/z5p7t8t2fst41.png?width=1024&auto=webp&s=14090fd249c2bf94fd2a2d5e3c0701f13f635fe6" }
            );
        }
    }
}
