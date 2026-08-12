using System;
using System.Collections.Generic;

namespace projekat_2026.Data.Models;

public partial class Adresar
{
    public int IdAdresar { get; set; }

    public string ImePrezime { get; set; } = null!;

    public bool Aktivan { get; set; }

    public string? Napomena { get; set; }

    public DateTime ReatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<Email> Emails { get; set; } = new List<Email>();

    public virtual ICollection<Telefon> Telefons { get; set; } = new List<Telefon>();

    public virtual ICollection<FirmaObjekat> IdFirmaObjekats { get; set; } = new List<FirmaObjekat>();
}
