using System;
using System.Collections.Generic;

namespace projekat_2026.Data.Models;

public partial class FirmaObjekat
{
    public int IdFirmaObjekat { get; set; }

    public string ImeFirmeObjekat { get; set; } = null!;

    public int BrojZaposlenih { get; set; }

    public string Adresa { get; set; } = null!;

    public string Grad { get; set; } = null!;

    public string Pib { get; set; } = null!;

    public string Mb { get; set; } = null!;

    public bool? Aktivan { get; set; }

    public DateOnly? DatumAktivnosti { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<ObjekatSistemVeznaTabela> ObjekatSistemVeznaTabelas { get; set; } = new List<ObjekatSistemVeznaTabela>();

    public virtual ICollection<Oprema> Opremas { get; set; } = new List<Oprema>();

    public virtual ICollection<PregledLog> PregledLogs { get; set; } = new List<PregledLog>();

    public virtual ICollection<Adresar> IdAdresars { get; set; } = new List<Adresar>();
}
