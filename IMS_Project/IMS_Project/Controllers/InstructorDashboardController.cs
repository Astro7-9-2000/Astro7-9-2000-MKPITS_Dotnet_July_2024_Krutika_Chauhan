using Microsoft.AspNetCore.Mvc;

namespace IMS_Project.Controllers
{
    public class InstructorDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
