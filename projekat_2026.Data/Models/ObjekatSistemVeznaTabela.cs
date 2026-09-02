using System;
using System.Collections.Generic;

namespace projekat_2026.Data.Models;

public partial class ObjekatSistemVeznaTabela
{
    public int IdObjekatSistemVeznaTabela { get; set; }

    public int IdFirmaObjekat { get; set; }

    public int IdSistem { get; set; }

    public string? Napomena { get; set; }

    public virtual FirmaObjekat IdFirmaObjekatNavigation { get; set; } = null!;

    public virtual Sistem IdSistemNavigation { get; set; } = null!;

    public virtual ICollection<StavkaPregledum> StavkaPregleda { get; set; } = new List<StavkaPregledum>();
}
