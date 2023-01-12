using Microsoft.AspNetCore.Mvc;
using Yummy.Models;

namespace Yummy.Areas.manage.Controllers
{
    public class TempladeController : Controller
    {
        [Area("manage")]
        public IActionResult Index()
        {
            return View();
        }  public IActionResult Create()
        {
            return View();
        }  public IActionResult Create(Slider slider)
        {
            return View();
        }
    }
}
