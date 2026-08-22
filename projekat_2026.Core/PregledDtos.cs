using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekat_2026.Core
{
    public class StavkaPregledaVM
    {
        public int IdStavkaPregleda { get; set; }
        public int IdPregledLog { get; set; }
        public int IdObjekatSistemVeznaTabela { get; set; }
        public string NazivSistema { get; set; } = "";
        public int? Periodika { get; set; }
        public string? NapomenaSistema { get; set; }
        public bool Zadovoljava { get; set; }
        public string? NapomenaStavke { get; set; }
    }

    public class StavkaPregledaUpdateDto
    {
        public int IdStavkaPregleda { get; set; }
        public bool Zadovoljava { get; set; }
        public string? NapomenaStavke { get; set; }
    }
}
