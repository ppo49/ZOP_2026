using System;
using System.Collections.Generic;

namespace projekat_2026.Data.Models;

public partial class Telefon
{
    public int IdTelefon { get; set; }

    public int IdAdresar { get; set; }

    public string Telefon1 { get; set; } = null!;

    public virtual Adresar IdAdresarNavigation { get; set; } = null!;
}
