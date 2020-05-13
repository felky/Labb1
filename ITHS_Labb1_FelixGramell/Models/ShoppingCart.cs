using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ITHS_Labb1_FelixGramell.Models
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
