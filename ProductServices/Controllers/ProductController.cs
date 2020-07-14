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
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : Controller
    {
        ProductRepo pr = new ProductRepo(); 

        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            return pr.GetAllProducts();
        }

        [HttpGet("{id}")]
        public Product GetSpecificProduct(int id)
        {
            return pr.GetById(id);
        }

        [HttpGet("{id}")]
        public ProductInformation GetInfoSpecificProduct(int id)
        {
            return pr.GetInfoById(id);
        }

        [HttpGet("{id}")]
        public ProductVM GetProductVM(int id)
        {
            return pr.GetProductVM(id);
        }
    }
}
