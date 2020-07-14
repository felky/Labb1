using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITHS_Labb1_FelixGramell.Models;

namespace ITHS_Labb1_FelixGramell.ViewModels
{
    public class StoreVM
    {

        public StoreVM(List<Product> _products)
        {
            products = _products;
        }

        public List<Product> products { get; set; }
    }
}
