using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using IMS_Project.Models;

namespace IMS_Project.Models
{
    public class Course
    {
        public int CourseId { get; set; } // Unique identifier for the course

        [Required(ErrorMessage = "Course Name is required.")]
        [RegularExpression(@"^[a-zA-Z0-9\s]*$", ErrorMessage = "Course Name must be alphanumeric.")]
        public string CourseName { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Start Date is required.")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "End Date is required.")]
        [DataType(DataType.Date)]
        [DateGreaterThan("StartDate", ErrorMessage = "End Date must be greater than Start Date.")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Duration is required.")]
        [Range(1, 52, ErrorMessage = "Duration must be between 1 and 52 weeks.")]
        public int Duration { get; set; }

        [Required(ErrorMessage = "Instructor ID is  required.")]
        public int InstructorId { get; set; }

        public IFormFile CourseMaterial { get; set; } // Optional file upload
    }

    public class DateGreaterThanAttribute : ValidationAttribute
    {
        private readonly string _comparisonProperty;

        public DateGreaterThanAttribute(string comparisonProperty)
        {
            _comparisonProperty = comparisonProperty;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var startDate = (DateTime)validationContext.ObjectType.GetProperty(_comparisonProperty).GetValue(validationContext.ObjectInstance);
            var endDate = (DateTime)value;

            if (endDate <= startDate)
            {
                return new ValidationResult(ErrorMessage);
            }

            return ValidationResult.Success;
        }
    }
}