using Microsoft.EntityFrameworkCore;
using projekat_2026.Data;
using projekat_2026.Data.Models;
using System.Collections.Generic;
using System.Linq;

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
                .Include(o => o.IdSistemNavigation)
                .Where(o => o.IdFirmaObjekat == idFirmaObjekat)
                .ToList();
        }

        public ObjekatSistemVeznaTabela? GetById(int id)
        {
            using var db = new AppDbContext(_dbOptions);
            return db.ObjekatSistemVeznaTabelas
                .Include(o => o.IdSistemNavigation)
                .FirstOrDefault(o => o.IdObjekatSistemVeznaTabela == id);
        }

        public void Add(ObjekatSistemVeznaTabela stavka)
        {
            using var db = new AppDbContext(_dbOptions);
            db.ObjekatSistemVeznaTabelas.Add(stavka);
            db.SaveChanges();
        }

        public void Update(ObjekatSistemVeznaTabela stavka)
        {
            using var db = new AppDbContext(_dbOptions);
            db.ObjekatSistemVeznaTabelas.Update(stavka);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            using var db = new AppDbContext(_dbOptions);
            var stavka = db.ObjekatSistemVeznaTabelas.Find(id);
            if (stavka != null)
            {
                db.ObjekatSistemVeznaTabelas.Remove(stavka);
                db.SaveChanges();
            }
        }
    }
}