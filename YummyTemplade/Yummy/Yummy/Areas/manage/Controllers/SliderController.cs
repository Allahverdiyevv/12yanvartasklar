using Microsoft.AspNetCore.Mvc;
using Yummy.Models;

namespace Yummy.Areas.manage.Controllers
{
    public class SliderController : Controller
    {
        private readonly DataContext _dataContext;

        public SliderController(DataContext dataContext)
        {
            _dataContext =dataContext;

        }
        public IActionResult Index()
        {
            List<Slider> sliderlist = _dataContext.Slider.ToList();
            return View(sliderlist);
        }
    }
}
