using Microsoft.EntityFrameworkCore;
using projekat_2026.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekat_2026.Core
{
    public class KomitentObavestenje
    {
        public int IdFirmaObjekat { get; set; }
        public string ImeFirmeObjekat { get; set; } = "";
        public DateOnly? DatumPoslednjegPregleda { get; set; }
        public bool PregledIzvrsenOvogMeseca { get; set; }
    }

    public class ObavestenjaService
    {
        private readonly DbContextOptions<AppDbContext> _dbOptions;

        public ObavestenjaService(DbContextOptions<AppDbContext> dbOptions)
        {
            _dbOptions = dbOptions;
        }
        public List<KomitentObavestenje> ProveriRokove()
        {
            using var db = new AppDbContext(_dbOptions);

            var danas = DateOnly.FromDateTime(DateTime.Now);

            var aktivneFirme = db.FirmaObjekats
                .Where(f => f.Aktivan == true)
                .Select(f => new
                {
                    f.IdFirmaObjekat,
                    f.ImeFirmeObjekat,
                    // Kastujemo u nullable DateOnly? da sprečimo grešku ako nema zapisnika u bazi
                    PoslednjiPregled = db.PregledLogs
                        .Where(p => p.IdFirmaObjekat == f.IdFirmaObjekat)
                        .OrderByDescending(p => p.DatumPregleda)
                        .Select(p => (DateOnly?)p.DatumPregleda)
                        .FirstOrDefault()
                })
                .ToList();

            return aktivneFirme.Select(f => new KomitentObavestenje
            {
                IdFirmaObjekat = f.IdFirmaObjekat,
                ImeFirmeObjekat = f.ImeFirmeObjekat,
                DatumPoslednjegPregleda = f.PoslednjiPregled,
                PregledIzvrsenOvogMeseca = f.PoslednjiPregled.HasValue &&
                    f.PoslednjiPregled.Value.Month == danas.Month &&
                    f.PoslednjiPregled.Value.Year == danas.Year
            }).ToList();
        }
    }
}
