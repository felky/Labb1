using OrderServices.Models;
using OrderServices.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServices.Services
{
    public class OrderService : IOrderService
    {
        private OrderRepo _repo = new OrderRepo();

        public async Task AddOrder(PaymentVM pvm)
        {
            await _repo.AddOrder(pvm); 
        }
    }
}
