using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq; 
using System.Threading.Tasks;
using IMS_Project.Models;

namespace IMS_Project.Controllers
{
    public class CourseManagementController : Controller
    {
        // Simulated database for demonstration purposes
        private static List<Course> courses = new List<Course>();

        // GET: /admin/create-course
        [HttpGet]
        public IActionResult CreateCourse()
        {
            return View();
        }

        // POST: /admin/create-course
        [HttpPost]
        public async Task<IActionResult> CreateCourse(Course course)
        {
            if (ModelState.IsValid)
            {
                // Handle file upload if needed
                if (course.CourseMaterial != null)
                {
                    var filePath = Path.Combine("uploads", course.CourseMaterial.FileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await course.CourseMaterial.CopyToAsync(stream);
                    }
                }

                // Add course to the simulated database
                course.CourseId = courses.Count + 1; // Simple ID assignment
                courses.Add(course);

                return RedirectToAction("Index"); // Redirect to a suitable page after creation
            }

            return View(course);
        }

        // GET: /admin/edit-course/{id}
        [HttpGet]
        public IActionResult EditCourse(int id)
        {
            var course = courses.FirstOrDefault(c => c.CourseId == id);
            if (course == null) return NotFound();

            return View(course);
        }

        // POST: /admin/edit-course
        [HttpPost]
        public async Task<IActionResult> EditCourse(Course course)
        {
            if (ModelState.IsValid)
            {
                var existingCourse = courses.FirstOrDefault(c => c.CourseId == course.CourseId);
                if (existingCourse != null)
                {
                    existingCourse.CourseName = course.CourseName;
                    existingCourse.Description = course.Description;
                    existingCourse.StartDate = course.StartDate;
                    existingCourse.EndDate = course.EndDate;
                    existingCourse.Duration = course.Duration;
                    existingCourse.Instructor = course.Instructor;

                    // Handle file upload if needed
                    if (course.CourseMaterial != null)
                    {
                        var filePath = Path.Combine("uploads", course.CourseMaterial.FileName);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await course.CourseMaterial.CopyToAsync(stream);
                        }
                    }
                }

                return RedirectToAction("Index"); // Redirect to a suitable page after update
            }

            return View(course);
        }

        // POST: /admin/delete-course
        [HttpPost]
        public IActionResult DeleteCourse(int id)
        {
            if (id <= 0)
            {
                ModelState.AddModelError("", "Course ID is required and must be numeric.");
                return View();
            }

            var course = courses.FirstOrDefault(c => c.CourseId == id);
            if (course != null)
            {
                courses.Remove(course);
            }

            return RedirectToAction("Index"); // Redirect to a suitable page after deletion
        }

        // GET: /admin/courses
        public IActionResult Index()
        {
            return View(courses); // Display the list of courses
        }
    }
}