using System;
using System.Collections.Generic;

namespace projekat_2026.Data.Models;

public partial class Agent
{
    public int IdAgent { get; set; }

    public string? Pwd { get; set; }

    public string ImePrezime { get; set; } = null!;

    public string SluzbeniEmail { get; set; } = null!;

    public string SluzbeniTelefon { get; set; } = null!;

    public bool? StatusAktivnosti { get; set; }

    public string Role { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<PregledLog> PregledLogs { get; set; } = new List<PregledLog>();
}
