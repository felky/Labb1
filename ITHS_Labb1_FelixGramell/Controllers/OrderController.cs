using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITHS_Labb1_FelixGramell.Data;
using ITHS_Labb1_FelixGramell.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITHS_Labb1_FelixGramell.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult ViewCart()
        {
            return View();
        }
    }
}