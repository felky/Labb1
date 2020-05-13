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


        [HttpPost]
        [Route("[controller]/[action]")]
        public IActionResult Payment(PaymentVM pvm)
        {
            if (!ModelState.IsValid)
            {
                ShoppingCart cart = HttpContext.Session.GetObjectFromJson<ShoppingCart>("cart");

                System.Diagnostics.Debug.WriteLine("Model state valid, keep going.");
                
                using (ApplicationDbContext ctx = new ApplicationDbContext())
                {
                    Orders order = new Orders()
                    {
                        OrderAdress = pvm.DeliveryAdress,
                        OrderDate = DateTime.Now,
                        FirstName = pvm.FirstName,
                        LastName = pvm.LastName,
                        Email = pvm.Email
                    };

                    ctx.Orders.Add(order);
                    ctx.SaveChanges();

                    foreach (Product p in cart.Products)
                    {
                        ctx.OrderLines.Add( new OrderLine()
                        {
                            ProductId = p.Id,
                            OrderId = order.Id,
                            Total = p.Price
                        });
                    }

                    HttpContext.Session.Clear();

                    ctx.SaveChanges();
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