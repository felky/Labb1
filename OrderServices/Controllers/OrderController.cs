using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using OrderServices.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OrderServices.Services;
using System.Net.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.IO;
using OrderServices.Data;

namespace OrderServices.Controllers
{
    [Route("orderapi/[controller]/[action]")]
    [ApiController]
    public class OrderController : Controller
    {
        OrderService _os = new OrderService();

        [HttpPost]
        public async Task AddOrder(PaymentVM pvm)
        {
            var paymentVM = pvm;
            await _os.AddOrder(paymentVM); 
        }
    }
}
