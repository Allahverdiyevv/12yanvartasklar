using Microsoft.AspNetCore.Mvc;

namespace TaskDersMVC.Areas.manage.Controllers
{
    [Area("manage")]
    public class TemplateController : Controller
    {
        
        public IActionResult Index()
        {

            return View();
        }


    }
}
