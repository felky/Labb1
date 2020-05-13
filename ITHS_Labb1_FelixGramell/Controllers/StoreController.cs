using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ITHS_Labb1_FelixGramell.Models;
using ITHS_Labb1_FelixGramell.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ITHS_Labb1_FelixGramell.Controllers
{
    public class StoreController : Controller
    {
        [HttpGet]
        [Route("[controller]/[action]/")]
        public IActionResult Store()
        {
            List<Product> products = new List<Product>();
            StoreVM vm = new StoreVM();
            vm.products = products;
            
            return View(vm);
        }
    }
}