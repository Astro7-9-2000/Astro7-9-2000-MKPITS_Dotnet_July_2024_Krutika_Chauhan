using Microsoft.AspNetCore.Mvc;

namespace IMS_Project.Controllers
{
    public class QuizController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
