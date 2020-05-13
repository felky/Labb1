using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ITHS_Labb1_FelixGramell.Data;
using ITHS_Labb1_FelixGramell.Models;
using ITHS_Labb1_FelixGramell.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ITHS_Labb1_FelixGramell.Controllers
{
    public class StoreController : Controller
    {
        [HttpGet]
        [Route("[controller]")]
        public IActionResult Store()
        {
            List<Product> products = new List<Product>();

            using (ApplicationDbContext ctx = new ApplicationDbContext())
            {
                try
                {
                    products = ctx.Product.ToList();
                }
                catch (Exception e)
                {
                    return View("Error");
                }
            };

            StoreVM vm = new StoreVM();
            vm.products = products;

            return View(vm);
        }

        [HttpGet("{id}")]
        [Route("[controller]/[action]")]
        public IActionResult ViewProduct(int id)
        {
            ProductVM vm = new ProductVM();

            using (ApplicationDbContext ctx = new ApplicationDbContext())
            {
                try
                {
                    Product prd = ctx.Product.Single(x => x.Id == id);
                    ProductInformation prdInf = ctx.ProductInformation.Single(x => x.Keyboard_Id == id);
                    vm.productInformation = prdInf;
                    vm.product = prd;
                } catch (Exception e)
                {
                    return View("Error"); 
                }
            };

            return View(vm);
        }
    }
}