using IMS_Project.Data;
using IMS_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace IMS_Project.Controllers
{
    public class LoginController : Controller
    {

        private readonly ApplicationDbContext _context;

        //Contructor to inject the DbContext
        public LoginController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginAsync(LoginViewModel model)
        {
            if(ModelState.IsValid)
            {
                string role = await AuthenticateUser(model.Email, model.Password);

                if(role == null)
                {
                    ModelState.AddModelError("", "Invalid Email or Password");
                    return View(model);
                }

                switch(role)
                {
                    case "Admin":
                        return RedirectToAction("Dashboard" , "Admin");
                    case "Instructor":
                        return RedirectToAction("Dashboard", "Instructor");
                    case "Student":
                        return RedirectToAction("Dashboard", "Student");
                    default:
                        return View(model);

                }
            }
            return View(model);
        }

        // Authentication
        private async Task<string> AuthenticateUser(string email, string password)
        {
            // Replace this with actual authentication logic
            var user = await _context.UserRegistration.FirstOrDefaultAsync(u => u.Email == email && u.Password == password);

            if (user != null)
            {
                return user.Role;
            }

            return null;
        }
    }
}
