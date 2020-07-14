using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITHS_Labb1_FelixGramell.Data;
using ITHS_Labb1_FelixGramell.Models;
using ITHS_Labb1_FelixGramell.Services;
using ITHS_Labb1_FelixGramell.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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

        [HttpGet]
        [Route("[controller]/[action]")]
        public IActionResult Checkout()
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

            PaymentVM vm = new PaymentVM();
            vm.Cart = cart;

            return View(vm);
        }


        /* Att Göra: 
         *  - Ta datan från Shopping Carten och VM och parsa den till JSON 
         *  - POST:a sedan den JSON datan till Apin. 
         *  - Parsa JSON och lägg i DB
         *  - Poggers
         */

        [HttpPost]
        [Route("[controller]/[action]")]
        public async Task<IActionResult> Payment(PaymentVM pvm)
        {

            if (!ModelState.IsValid)
            {
                ShoppingCart cart = HttpContext.Session.GetObjectFromJson<ShoppingCart>("cart");
                pvm.Cart = cart;
                var payload = JsonConvert.SerializeObject(pvm);

                using (var httpClient = new HttpClient())
                {
                    await httpClient.PostAsync("http://localhost:53577/orderapi/order/addorder/", new StringContent(payload, Encoding.UTF8, "application/json"));
                    HttpContext.Session.Clear();
                }
            }

            return View("Payment");
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