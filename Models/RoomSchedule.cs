using System;
using System.Collections.Generic;

namespace Darla.Models;

public partial class RoomSchedule
{
    public string RoomCode { get; set; } = null!;

    public string Timeslot { get; set; } = null!;

    public string? TeamSection { get; set; }

    public string? TeamNumber { get; set; }
}
