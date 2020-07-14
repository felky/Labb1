using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using ProductServices.Models;
using ProductServices.Repositories;
using ProductServices.Services;

namespace ProductServices.Controllers
{
    [Route("productapi/[controller]/[action]")]
    [ApiController]
    public class ProductController : Controller
    {
        ProductService ps = new ProductService(); 

        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            return ps.GetAllProducts();
        }

        [HttpGet("{id}")]
        public Product GetById(int id)
        {
            return ps.GetById(id);
        }

        [HttpGet("{id}")]
        public ProductInformation GetInfoSpecificProduct(int id)
        {
            return ps.GetInfoById(id);
        }

        [HttpGet("{id}")]
        public ProductVM GetProductVM(int id)
        {
            return ps.GetProductVM(id);
        }
    }
}
