using System;
using System.Collections.Generic;

namespace Darla.Models;

public partial class StudentTeam
{
    public int StudentNetId { get; set; }

    public int TeamNumber { get; set; }

    public virtual User StudentNet { get; set; } = null!;
}
