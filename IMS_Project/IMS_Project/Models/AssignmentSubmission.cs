using System;
using System.Collections.Generic;

namespace IMS_Project.Models;

public partial class AssignmentSubmission
{
    public int Id { get; set; }

    public int AssignmentId { get; set; }

    public int StudentId { get; set; }

    public DateTime SubmittedOn { get; set; }

    public string? FileUrl { get; set; }

    public string? Remarks { get; set; }

    public int? MarksObtained { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public string? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public virtual Assignment Assignment { get; set; } = null!;

    public virtual TblUser Student { get; set; } = null!;
}
