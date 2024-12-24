using System.ComponentModel.DataAnnotations;

namespace IMS_Project.Models
{
    public class Role
    {
        public int RoleId { get; set; } // Unique identifier for the role

        [Required(ErrorMessage = "Role Name is required.")]
        public string RoleName { get; set; } // Name of the role (e.g., Instructor, Student, Admin)

        public string Description { get; set; } // Optional description of the role
    }