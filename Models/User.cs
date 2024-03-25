using System;
using System.Collections.Generic;

namespace Darla.Models;

public partial class User
{
    public int NetId { get; set; }

    public int? PermissionsType { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();

    public virtual ICollection<JudgeRoom> JudgeRooms { get; set; } = new List<JudgeRoom>();

    public virtual Permission? PermissionsTypeNavigation { get; set; }

    public virtual ICollection<StudentTeam> StudentTeams { get; set; } = new List<StudentTeam>();

    public virtual UserPassword? UserPassword { get; set; }
}
