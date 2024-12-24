using System;
using System.Collections.Generic;

namespace IMS_Project.Models;

public partial class AuditLog
{
    public int Id { get; set; }

    public string Action { get; set; } = null!;

    public string TableName { get; set; } = null!;

    public int RecordId { get; set; }

    public int UserId { get; set; }

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public DateTime Timestamp { get; set; }

    public string? IpAddress { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public string? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public virtual TblUser User { get; set; } = null!;
}
