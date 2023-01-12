using Microsoft.AspNetCore.Mvc;
using TaskDersMVC.Models;

namespace TaskDersMVC.Areas.manage.Controllers
{
    public class ProductController : Controller
    {
        private readonly DataContext _dataContext;

        public ProductController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public IActionResult Index()
        {
            List<Prodact> prodacts = _dataContext.prodacts.ToList();
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
