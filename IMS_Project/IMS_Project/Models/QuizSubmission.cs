using System;
using System.Collections.Generic;

namespace IMS_Project.Models;

public partial class QuizSubmission
{
    public int Id { get; set; }

    public int QuizId { get; set; }

    public int StudentId { get; set; }

    public DateTime SubmittedOn { get; set; }

    public int MarksObtained { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public string? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public virtual Quiz Quiz { get; set; } = null!;

    public virtual TblUser Student { get; set; } = null!;
}
