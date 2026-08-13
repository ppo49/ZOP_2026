using System;
using System.Collections.Generic;

namespace projekat_2026.Data.Models;

public partial class Sistem
{
    public int IdSistem { get; set; }

    public string Naziv { get; set; } = null!;

    public int? Periodika { get; set; }

    public string? Napomena { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<ObjekatSistemVeznaTabela> ObjekatSistemVeznaTabelas { get; set; } = new List<ObjekatSistemVeznaTabela>();
}
