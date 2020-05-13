using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITHS_Labb1_FelixGramell.Models;
using ITHS_Labb1_FelixGramell.Services;
using ITHS_Labb1_FelixGramell.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ITHS_Labb1_FelixGramell.Controllers
{
    public class CheckoutController : Controller
    {
        [HttpGet]
        [Route("[controller]/[action]")]
        public IActionResult Cart()
        {
            ShoppingCart cart;

            if (string.IsNullOrEmpty(HttpContext.Session.GetString("cart")))
            {
                return View();
            }
            else
            {
                cart = HttpContext.Session.GetObjectFromJson<ShoppingCart>("cart");
            }

            CartVM vm = new CartVM();
            vm.Cart = cart; 

            return View(vm);
        }

        public IActionResult RemoveFromCart(int index)
        {
            ShoppingCart cart = new ShoppingCart();

            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("cart")))
            {
                cart = HttpContext.Session.GetObjectFromJson<ShoppingCart>("cart");
                cart.Products.RemoveAt(index);
                HttpContext.Session.SetObjectAsJson("cart", cart);
                System.Diagnostics.Debug.WriteLine("REMOVED AT INDEX: " + index);
            }            

            CartVM vm = new CartVM();
            vm.Cart = cart;

            return RedirectToAction("Cart");
        }
    }
}