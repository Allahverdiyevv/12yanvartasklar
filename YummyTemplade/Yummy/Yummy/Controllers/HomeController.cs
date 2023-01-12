using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Yummy.Models;

namespace Yummy.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }

     
    }
}