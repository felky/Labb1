using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductServices.Models
{
    public class ProductVM
    {
        public Product product { get; set; }
        public ProductInformation productInformation { get; set; }
    }
}
