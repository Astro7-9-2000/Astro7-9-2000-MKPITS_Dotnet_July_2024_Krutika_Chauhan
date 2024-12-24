using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace IMS_Project.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Admin Actions
        [Authorize(Roles = "Admin")]
        public IActionResult AdminDashboardViewModel()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public IActionResult ManageUsers()
        {
            // Logic to manage users
            return View();
        }

        [Authorize(Roles = "Instructor")]
        public IActionResult ManageCourses()
        {
            // Logic to manage courses
            return View();
        }

        // Student Actions
        [Authorize(Roles = "Student")]
        public IActionResult StudentDashboard()
        {
            // Logic for Student Dashboard
            return View();
        }

        [Authorize(Roles = "Student")]
        public IActionResult ViewCourses()
        {
            // Logic to view courses
            return View();
        }
    }
}
