using System;
using System.Collections.Generic;

namespace Darla.Models;

public partial class Grade
{
    public int AssignmentId { get; set; }

    public int StudentGradesNetId { get; set; }

    public int? Points { get; set; }

    public string? Comments { get; set; }

    public int? ClassCode { get; set; }

    public virtual Assignment Assignment { get; set; } = null!;

    public virtual User StudentGradesNet { get; set; } = null!;
}
