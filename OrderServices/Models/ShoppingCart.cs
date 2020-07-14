using ProductServices.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServices.Models
{
    public class ShoppingCart
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public bool PurchaseDone { get; set; }

        [Required]
        public List<Product> Products { get; set; }

    }
}
