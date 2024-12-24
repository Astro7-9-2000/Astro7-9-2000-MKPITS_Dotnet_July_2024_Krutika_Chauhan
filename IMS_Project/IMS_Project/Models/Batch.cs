using System;
using System.Collections.Generic;

namespace IMS_Project.Models;

public partial class Batch
{
    public int Id { get; set; }

    public string BatchName { get; set; } = null!;

    public int CourseId { get; set; }

    public int InstructorId { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public string? BatchTiming { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public string? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public int Capacity { get; set; }

    public int? CurrentEnrollment { get; set; }

    public string? RoomNumber { get; set; }

    public string BatchStatus { get; set; } = null!;

    public virtual ICollection<Assignment> Assignments { get; set; } = new List<Assignment>();

    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    public virtual TblUser Instructor { get; set; } = null!;

    public virtual ICollection<Quiz> Quizzes { get; set; } = new List<Quiz>();
}
