using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServices.Models
{
    public class OrderLine
    {
        [Key]
        [JsonProperty("Id")]
        public int Id { get; set; }

        [Required]
        [JsonProperty("OrderId")]
        public int OrderId { get; set; }

        [Required]
        [JsonProperty("ProductId")]
        public int ProductId { get; set; }

        [Required]
        [JsonProperty("Total")]
        public double Total { get; set; }
    }
}
