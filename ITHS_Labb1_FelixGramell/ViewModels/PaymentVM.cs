using ITHS_Labb1_FelixGramell.Models;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ITHS_Labb1_FelixGramell.ViewModels
{
    public class PaymentVM
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string DeliveryAdress { get; set; }

        [Required]
        public ShoppingCart Cart { get; set; }

        //Inte required eftersom att det inte är en riktig betalningsmetod
        [MinLength(16), MaxLength(16)]
        public string CardNumber { get; set; }
        [MinLength(3), MaxLength(3)]
        public string CVC { get; set; }
        [MinLength(2), MaxLength(2)]
        public string ExpirationMonth { get; set; }
        [MinLength(2), MaxLength(2)]
        public string ExpirationYear { get; set; }
    }
}
