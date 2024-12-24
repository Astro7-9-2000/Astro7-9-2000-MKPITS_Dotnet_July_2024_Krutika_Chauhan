using Microsoft.AspNetCore.Mvc;
using IMS_Project.Models;
using IMS_Project.Data;
using Microsoft.EntityFrameworkCore;

namespace IMS_Project.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly ApplicationDbContext _context;
        public RegistrationController(ApplicationDbContext context)
        {
            _context = context;
        }
        //GET: /register
        public IActionResult Register()
        {
            return View();
        }

        // POST: /register
        [HttpPost]
        public async Task<ActionResult> Register(UserRegistration model)
        {
            if (ModelState.IsValid)
            {
                // Save the user data to the database
                await _context.Users.AddAsync(model); // Assuming you have a DbSet<UserRegistration> Users
                await _context.SaveChangesAsync();

               // Set a success message in TempData
               TempData["SuccessMessage"] = "Registration successful!";

                // Redirect to the same page to show the SweetAlert
                return RedirectToAction("Register");
            }

            return View(model);
        }

    }
}

