using System;
using System.Collections.Generic;

namespace projekat_2026.Data.Models;

public partial class Email
{
    public int IdEmail { get; set; }

    public int IdAdresar { get; set; }

    public string Email1 { get; set; } = null!;

    public virtual Adresar IdAdresarNavigation { get; set; } = null!;
}
