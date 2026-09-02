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
    public class OpremaService
    {
        private readonly DbContextOptions<AppDbContext> _dbOptions;

        public OpremaService(DbContextOptions<AppDbContext> dbOptions)
        {
            _dbOptions = dbOptions;
        }

        public List<Oprema> GetAll()
        {
            using var db = new AppDbContext(_dbOptions);
            return db.Opremas.ToList();
        }

        public Oprema? GetByIdbarcode(int id)
        {
            using var db = new AppDbContext(_dbOptions);
            return db.Opremas.FirstOrDefault(f => f.IdBarcode == id);
        }

        
        public List<Oprema> GetByFirmaObjekatId(int idFirmaObjekat)
        {
            using var db = new AppDbContext(_dbOptions);
            return db.Opremas
                .Include(o => o.IdFirmaObjekatNavigation)
                .Where(o => o.IdFirmaObjekat == idFirmaObjekat)
                .ToList();
        }


        public void Add(Oprema oprema)
        {
            using var db = new AppDbContext(_dbOptions);
            db.Opremas.Add(oprema);
            db.SaveChanges();
        }

        public void Update(Oprema oprema)
        {
            using var db = new AppDbContext(_dbOptions);
            db.Opremas.Update(oprema);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            using var db = new AppDbContext(_dbOptions);
            var oprema = db.Opremas.Find(id);
            if (oprema != null)
            {
                db.Opremas.Remove(oprema);
                db.SaveChanges();
            }
        }

    }
}
