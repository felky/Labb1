using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using OrderServices.Data;
using OrderServices.Models;
using ProductServices.Models;

namespace OrderServices.Repositories
{
    public class OrderRepo
    {
        public async Task AddOrder(PaymentVM pvm)
        {
            using (OrderServiceContext ctx = new OrderServiceContext())
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

                foreach (Product p in pvm.Cart.Products)
                {
                    ctx.OrderLine.Add(new OrderLine()
                    {
                        ProductId = p.Id,
                        OrderId = order.Id,
                        Total = p.Price
                    });
                }

                System.Diagnostics.Debug.WriteLine("ORDER ADDED: " + order.ToString());
                await ctx.SaveChangesAsync();
            }
        }
    }
}
