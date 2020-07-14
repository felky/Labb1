﻿using ITHS_Labb1_FelixGramell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITHS_Labb1_FelixGramell.ViewModels
{
    public class ProductVM
    {
        public ProductVM(Product _pr, ProductInformation _prInf)
        {
            product = _pr;
            productInformation = _prInf;
        }

        public Product product { get; set; }
        public ProductInformation productInformation { get; set; }
    }
}
