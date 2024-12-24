using IMS_Project.Data;
using IMS_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Composition;
using System.Threading.Tasks;

namespace IMS_Project.Controllers
{
    public class AdminDashboardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminDashboardController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /admin/dashboard
        public async Task<IActionResult> Index()
        {
            var courses = await _context.Courses.ToListAsync();
            var batches = await _context.Batches.ToListAsync();
            var instructors = await _context.Instructors.ToListAsync();
            var reports = await GenerateReportsAsync(); // Method to generate reports

            var viewModel = new AdminDashboardViewModel
            {
                Courses = courses,
                Batches = batches,
                Instructors = instructors,
                Reports = reports
            };

            return View(viewModel);
        }

        // POST: /admin/dashboard/create-course
        [HttpPost]
        public async Task<IActionResult> CreateCourse(Course course)
        {
            if (ModelState.IsValid)
            {
                _context.Courses.Add(course);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(course);
        }

        // POST: /admin/dashboard/assign-instructor
        [HttpPost]
        public async Task<IActionResult> AssignInstructor(int courseId, int instructorId)
        {
            var course = await _context.Courses.FindAsync(courseId);
            var instructor = await _context.Instructors.FindAsync(instructorId);

            if (course != null && instructor != null)
            {
                course.InstructorId = instructorId; // Assuming Course has an InstructorId property
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return NotFound();
        }

        // Method to generate reports
        private async Task<List<Report>> GenerateReportsAsync()
        {
            // Logic to generate reports
            return await _context.Reports.ToListAsync();
        }
    }
}