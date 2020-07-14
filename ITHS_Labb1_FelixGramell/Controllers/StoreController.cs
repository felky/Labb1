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
using System.Net.Http;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ITHS_Labb1_FelixGramell.Controllers
{
    public class StoreController : Controller
    {
        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> Store()
        {
            List<Product> products;
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:52403/api/product/getallproducts/"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    products = JsonConvert.DeserializeObject<List<Product>>(apiResponse);

                }
            }

            StoreVM vm = new StoreVM(products);
            if( vm != null)
            {
                return View(vm);
            }

            return RedirectToAction("Home", "Index"); 
        }

        [HttpGet("{id}")]
        [Route("[controller]/[action]")]
        public async Task<IActionResult> ViewProduct(int id)
        {
            ProductVM productVM;

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"http://localhost:52403/api/product/GetProductVM/{id}"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    productVM = JsonConvert.DeserializeObject<ProductVM>(apiResponse);
                }
            }

            return View(productVM);
        }

        [HttpPost("{id}")]
        [Route("[controller]/[action]")]
        public async Task<IActionResult> AddToCart(int id)
        {
            var cart = new ShoppingCart();
            var prd = new Product();
            var prdList = new List<Product>();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"http://localhost:52403/api/product/getspecificproduct/{id}"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    prd = JsonConvert.DeserializeObject<Product>(apiResponse);

                }
            }

            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("cart"))) {
                    cart = HttpContext.Session.GetObjectFromJson<ShoppingCart>("cart");
                    cart.Products.Add(prd);
                    HttpContext.Session.SetObjectAsJson("cart", cart);
            }
            else {
                    prdList.Add(prd);
                    cart.Products = prdList;
                    HttpContext.Session.SetObjectAsJson("cart", cart);
            }

            return RedirectToAction("Cart", "Checkout");

        }
    }
}