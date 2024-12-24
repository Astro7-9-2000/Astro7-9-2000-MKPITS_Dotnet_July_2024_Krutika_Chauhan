using System;
using System.Collections.Generic;

namespace IMS_Project.Models;

public partial class Assignment
{
    public int Id { get; set; }

    public string AssignmentTitle { get; set; } = null!;

    public int CourseId { get; set; }

    public int BatchId { get; set; }

    public int InstructorId { get; set; }

    public DateTime DueDate { get; set; }

    public string? Description { get; set; }

    public string? FileUrl { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public string? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public virtual ICollection<AssignmentSubmission> AssignmentSubmissions { get; set; } = new List<AssignmentSubmission>();

    public virtual Batch Batch { get; set; } = null!;

    public virtual Course Course { get; set; } = null!;

    public virtual TblUser Instructor { get; set; } = null!;
}
