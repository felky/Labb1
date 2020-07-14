using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ProductServices.Models;
using ProductServices.Repositories;

namespace ProductServices.Test
{
    public class RepositoryTest
    {
        [Fact]
        public void GetProducts_Returns_Product()
        {
            var productRepo = new ProductRepo();
            var product = productRepo.GetAllProducts();

            Assert.IsType<List<Product>>(product);
        }

        [Fact]
        public void GetProductById_Returns_Product()
        {
            var productRepo = new ProductRepo();
            var product = productRepo.GetById(1);

            Assert.IsType<Product>(product);
        }

        [Fact]
        public void GetProductInfoById_Returns_ProductInfo()
        {
            var productInfoRepo = new ProductRepo();
            var productInfo = productInfoRepo.GetInfoById(1);

            Assert.IsType<ProductInformation>(productInfo);
        }

        [Fact]
        public void GetProductVMbyId_Returns_ProductVM()
        {
            var productRepo = new ProductRepo();
            var productVM = productRepo.GetProductVM(1);

            Assert.IsType<ProductVM>(productVM);
        }

    }
}
