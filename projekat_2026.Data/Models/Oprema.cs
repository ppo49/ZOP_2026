using System;
using System.Collections.Generic;

namespace projekat_2026.Data.Models;

public partial class Oprema
{
    public int IdBarcode { get; set; }

    public string Naziv { get; set; } = null!;

    public string? Napomena { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
