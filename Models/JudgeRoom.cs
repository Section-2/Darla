using System;
using System.Collections.Generic;

namespace Darla.Models;

public partial class JudgeRoom
{
    public int JudgeCode { get; set; }

    public string RoomCode { get; set; } = null!;

    public virtual User JudgeCodeNavigation { get; set; } = null!;
}
