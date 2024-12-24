using System.Collections.Generic;
using IMS_Project.Models;

namespace IMS_Project.Models
{
    public class AdminDashboardViewModel
    {
        public List<Course> Courses { get; set; }
        public List<Batch> Batches { get; set; }
        public List<InstructorId> Instructors { get; set; }
        public List<Report> Reports { get; set; }
    }
}
