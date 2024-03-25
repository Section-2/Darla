using System;
using System.Collections.Generic;

namespace Darla.Models;

public partial class PresentationSurvey
{
    public int JudgeId { get; set; }

    public int TeamNumber { get; set; }

    public string? CommunicationScore { get; set; }

    public string? CommunicationNotes { get; set; }

    public string? DemonstrationScore { get; set; }

    public string? DemonstrationNotes { get; set; }

    public string? ClientNeedsScore { get; set; }

    public string? ClientNeedsNotes { get; set; }

    public string? ConsideredAwards { get; set; }

    public string? TeamRank { get; set; }
}
