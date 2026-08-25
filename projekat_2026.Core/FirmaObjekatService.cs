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

        public string GetNameById(int id)
        {
            using var db = new AppDbContext(_dbOptions);

            return db.FirmaObjekats
                     .Where(f => f.IdFirmaObjekat == id)
                     .Select(f => f.ImeFirmeObjekat)
                     .FirstOrDefault() ?? string.Empty;
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


        public async Task<bool> SaveComplete(FirmaObjekat firma, List<Adresar> adresari, List<ObjekatSistemVeznaTabela> sistemi)
        {
            using var db = new AppDbContext(_dbOptions);
            using var transaction = await db.Database.BeginTransactionAsync();
            try
            {
                db.FirmaObjekats.Add(firma);
                foreach (var adresar in adresari)
                {
                    if (adresar.IdAdresar > 0)
                    {
                        db.Adresars.Attach(adresar);
                        adresar.IdFirmaObjekats.Add(firma);
                    }
                    else
                    {
                        db.Adresars.Add(adresar);
                    }
                }
                if (sistemi.Any())
                    db.ObjekatSistemVeznaTabelas.AddRange(sistemi);

                await db.SaveChangesAsync();
                await transaction.CommitAsync();
                return true;
            }
            catch
            {
                await transaction.RollbackAsync();
                throw; // let the form decide how to show the error
            }
        }



    }
}