using System;
using System.Collections.Generic;

namespace IMS_Project.Models;

public partial class Quiz
{
    public int Id { get; set; }

    public string QuizTitle { get; set; } = null!;

    public int CourseId { get; set; }

    public int BatchId { get; set; }

    public int InstructorId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int Duration { get; set; }

    public int TotalMarks { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public string? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public virtual Batch Batch { get; set; } = null!;

    public virtual Course Course { get; set; } = null!;

    public virtual TblUser Instructor { get; set; } = null!;

    public virtual ICollection<QuizSubmission> QuizSubmissions { get; set; } = new List<QuizSubmission>();
}
