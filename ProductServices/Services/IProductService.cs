using ProductServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductServices.Services
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Product GetById(int id);
        ProductInformation GetInfoById(int id);
        ProductVM GetProductVM(int id); 
    }
}
