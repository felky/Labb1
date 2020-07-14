using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Internal;
using ProductServices.Data;
using ProductServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ProductServices.Repositories
{
    public class ProductRepo
    {

        private List<Product> products = new List<Product>();

        public List<Product> GetAllProducts()
        {
            using (ProductServiceContext ctx = new ProductServiceContext())
            {
                products = ctx.Product.ToList();
            };

            return products;
        }

        public Product GetById(int id)
        {
            Product product;

            using (ProductServiceContext ctx = new ProductServiceContext())
            {
                product = ctx.Product.FirstOrDefault(x => x.Id == id); 
            };

            return product;
        }

        public ProductInformation GetInfoById(int id)
        {
            ProductInformation productInfo;

            using (ProductServiceContext ctx = new ProductServiceContext())
            {
                var products = ctx.ProductInformation.ToList();
                productInfo = ctx.ProductInformation.FirstOrDefault(x => x.Keyboard_Id == id);
            };

            return new ProductInformation();
        }

        public ProductVM GetProductVM(int id)
        {
            ProductVM productVM = new ProductVM();

            using (ProductServiceContext ctx = new ProductServiceContext())
            {
                productVM.product = ctx.Product.FirstOrDefault(x => x.Id == id);
                productVM.productInformation = ctx.ProductInformation.FirstOrDefault(x => x.Keyboard_Id == id);
            };

            return productVM;
        }
    }
}
