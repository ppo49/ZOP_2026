using System;
using System.Collections.Generic;

namespace projekat_2026.Data.Models;

public partial class PregledLog
{
    public int IdPregledLog { get; set; }

    public int IdFirmaObjekat { get; set; }

    public int IdAgent { get; set; }

    public DateOnly DatumPregleda { get; set; }

    public string? Napomena { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual Agent IdAgentNavigation { get; set; } = null!;

    public virtual FirmaObjekat IdFirmaObjekatNavigation { get; set; } = null!;

    public virtual ICollection<StavkaPregledum> StavkaPregleda { get; set; } = new List<StavkaPregledum>();
}
