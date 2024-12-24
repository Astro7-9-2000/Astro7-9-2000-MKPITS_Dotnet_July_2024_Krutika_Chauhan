using Microsoft.AspNetCore.Mvc;

namespace IMS_Project.Controllers
{
    public class StudentDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
