using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServices.Models
{
    public class Orders
    {
        [Key]
        [JsonProperty("Id")]
        public int Id { get; set; }

        [Required]
        [JsonProperty("OrderDate")]
        public DateTime OrderDate { get; set; }

        [Required]
        [JsonProperty("OrderAdress")]
        public string OrderAdress { get; set; }

        [Required]
        [JsonProperty("FirstName")]
        public string FirstName { get; set; }

        [Required]
        [JsonProperty("LastName")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [JsonProperty("Email")]
        public string Email { get; set; }
    }
}
