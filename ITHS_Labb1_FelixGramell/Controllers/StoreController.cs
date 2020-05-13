using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ITHS_Labb1_FelixGramell.Data;
using ITHS_Labb1_FelixGramell.Models;
using ITHS_Labb1_FelixGramell.ViewModels;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using ITHS_Labb1_FelixGramell.Services;
using System.ComponentModel.DataAnnotations;

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

        [HttpPost("{id}")]
        [Route("[controller]/[action]")]
        public IActionResult AddToCart(int id)
        {
            var cart = new ShoppingCart();
            var prd = new Product();
            var prdList = new List<Product>();

            using (ApplicationDbContext ctx = new ApplicationDbContext())
            {
                prd = ctx.Product.SingleOrDefault(x => x.Id == id);
            }

            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("cart"))) {
                    cart = HttpContext.Session.GetObjectFromJson<ShoppingCart>("cart");
                    cart.Products.Add(prd);
                    HttpContext.Session.SetObjectAsJson("cart", cart);
                    System.Diagnostics.Debug.WriteLine("CART EXISTING, ADDED TO CART: " + cart.Products.ToString());
            }
            else {
                    prdList.Add(prd);
                    cart.Products = prdList;
                    HttpContext.Session.SetObjectAsJson("cart", cart);
                    System.Diagnostics.Debug.WriteLine("CART EMPTY, NEW CART CREATED: " + cart.Products.ToString());
            }

            return RedirectToAction("Cart", "Checkout");

        }
    }
}