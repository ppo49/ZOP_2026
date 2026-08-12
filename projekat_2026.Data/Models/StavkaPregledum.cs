using System;
using System.Collections.Generic;

namespace projekat_2026.Data.Models;

public partial class StavkaPregledum
{
    public int IdStavkaPregleda { get; set; }

    public int IdPregledLog { get; set; }

    public int IdObjekatSistemVeznaTabela { get; set; }

    public bool Zadovoljava { get; set; }

    public string? NapomenaStavke { get; set; }

    public virtual ObjekatSistemVeznaTabela IdObjekatSistemVeznaTabelaNavigation { get; set; } = null!;

    public virtual PregledLog IdPregledLogNavigation { get; set; } = null!;
}
