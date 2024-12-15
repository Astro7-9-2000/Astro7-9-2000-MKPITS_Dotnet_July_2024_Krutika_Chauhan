using Microsoft.AspNetCore.Mvc;

namespace RoutingWithoutMVC.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("Index")]
        [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("About")]
        public IActionResult About()
        {
            return View();
        }

        [Route("Details/{id?}")]
        public int Details(int ? id)
        {
            return id ?? 1;
        }
    }
}
