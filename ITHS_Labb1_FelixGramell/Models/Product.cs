using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITHS_Labb1_FelixGramell.Models
{
    public class Product
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public bool InStock { get; set; }
        public int AmountInStock { get; set; }
        public float Price { get; set; }
        public string Img_Url { get; set; }

    }
}
