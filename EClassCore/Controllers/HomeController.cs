using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EClassCore.Controllers
{
    public class HomeController : Controller
    {
        //private readonly 

        public IActionResult Index()
        {
            return View();
        }
    }
}
