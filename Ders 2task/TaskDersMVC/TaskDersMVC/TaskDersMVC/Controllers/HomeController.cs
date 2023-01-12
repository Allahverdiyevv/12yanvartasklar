using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using TaskDersMVC.Models;

namespace TaskDersMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _datacontext;

        public HomeController(DataContext dataContext)
        {
            _datacontext = dataContext;
        }

        public IActionResult Index()
        {
            List<Prodact> prodacts = _datacontext.prodacts./*Include(x=>x.Image)*/ToList();
            return View(prodacts);
        }

    }
}