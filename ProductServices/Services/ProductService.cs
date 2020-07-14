using ProductServices.Data;
using ProductServices.Models;
using ProductServices.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductServices.Services
{
    public class ProductService : IProductService
    {
        private ProductRepo _repo = new ProductRepo(); 
        
        public List<Product> GetAllProducts()
        {
            return _repo.GetAllProducts();
        }

        public Product GetProductById(int id)
        {
            return _repo.GetById(id);

        }

        public ProductInformation GetInformationById(int id)
        {
            return _repo.GetInfoById(id);
        }

        public ProductVM GetProductVM(int id)
        {
            return _repo.GetProductVM(id); 
        }
    } 
}
