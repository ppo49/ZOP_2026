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
    public class SistemService
    {
        private readonly DbContextOptions<AppDbContext> _dbOptions;

        public SistemService(DbContextOptions<AppDbContext> dbOptions) 
        {
            _dbOptions = dbOptions;
        }

        public List<Sistem> GetAll() {
            using var db = new AppDbContext(_dbOptions);
            return db.Sistems.ToList();
        }

        public List<Sistem> GetNameAndId()
        {
            using var db = new AppDbContext(_dbOptions);
            return db.Sistems
                .AsNoTracking()
                .Select(s => new Sistem
                {
                    IdSistem = s.IdSistem,
                    Naziv = s.Naziv
                })
                .ToList();
        }

        public Sistem? GetById(int id)
        {
            using var db = new AppDbContext(_dbOptions);
            return db.Sistems.FirstOrDefault(s => s.IdSistem == id);
        }


        public void Add(Sistem sistem)
        {
            using var db = new AppDbContext(_dbOptions);
            db.Sistems.Add(sistem);
            db.SaveChanges();
        }

        public void Update(Sistem sistem)
        {
            using var db = new AppDbContext(_dbOptions);
            db.Sistems.Update(sistem);
            db.SaveChanges();
        }

        public void Delete(int id) {
            using var db = new AppDbContext(_dbOptions);
            var sistem = db.Sistems.Find(id);
            if (sistem != null)
            {
                db.Sistems.Remove(sistem);
                db.SaveChanges();
            }
        }


        public List<ObjekatSistemVeznaTabela> GetObjekatSistemVeznaTabelaNapomenaFromIdSistem(int idSistem)
        {
            using var db = new AppDbContext(_dbOptions);
            return db.ObjekatSistemVeznaTabelas
                .Include(os=> os.Napomena)
                .Where(os => os.IdSistem == idSistem)
                .ToList();
        }

    }
}
