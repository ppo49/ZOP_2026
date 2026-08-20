using Microsoft.EntityFrameworkCore;
using projekat_2026.Data;
using projekat_2026.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekat_2026.Core
{
    public class ObjekatSistemService
    {
        private readonly DbContextOptions<AppDbContext> _dbOptions;

        public ObjekatSistemService(DbContextOptions<AppDbContext> dbOptions)
        {
            _dbOptions = dbOptions;
        }

        public List<ObjekatSistemVeznaTabela> GetByFirmaObjekat(int idFirmaObjekat)
        {
            using var db = new AppDbContext(_dbOptions);
            return db.ObjekatSistemVeznaTabelas
                .Include(o => o.IdSistemNavigation)   // pulls in Sistem's Naziv, etc.
                .Where(o => o.IdFirmaObjekat == idFirmaObjekat)
                .ToList();
        }
    }
}
