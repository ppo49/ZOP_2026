using Microsoft.EntityFrameworkCore;
using projekat_2026.Data;
using projekat_2026.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace projekat_2026.Core
{
    public class FirmaObjekatService
    {
        private readonly DbContextOptions<AppDbContext> _dbOptions;

        public FirmaObjekatService(DbContextOptions<AppDbContext> dbOptions)
        {
            _dbOptions = dbOptions;
        }

        public List<FirmaObjekat> GetAll()
        {
            using var db = new AppDbContext(_dbOptions);
            return db.FirmaObjekats.ToList();
        }

        public FirmaObjekat? GetById(int id)
        {
            using var db = new AppDbContext(_dbOptions);
            return db.FirmaObjekats.FirstOrDefault(f => f.IdFirmaObjekat == id);
        }

        public void Add(FirmaObjekat firma)
        {
            using var db = new AppDbContext(_dbOptions);
            db.FirmaObjekats.Add(firma);
            db.SaveChanges();
        }

        public void Update(FirmaObjekat firma)
        {
            using var db = new AppDbContext(_dbOptions);
            db.FirmaObjekats.Update(firma);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            using var db = new AppDbContext(_dbOptions);
            var firma = db.FirmaObjekats.Find(id);
            if (firma != null)
            {
                db.FirmaObjekats.Remove(firma);
                db.SaveChanges();
            }
        }
    }
}