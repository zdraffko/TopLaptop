using Microsoft.AspNetCore.Mvc;

namespace TopLaptop.Web.Controllers
{
    public class LaptopPartsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}