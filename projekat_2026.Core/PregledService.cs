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
    
    public class PregledService
    {
        private readonly DbContextOptions<AppDbContext> _dbOptions;
        public PregledService(DbContextOptions<AppDbContext> dbOptions) 
        {
            _dbOptions = dbOptions;
        }

        public List<PregledLog> GetAll()
        {
            using var db = new AppDbContext(_dbOptions);
            return db.PregledLogs.ToList();
        }

        public PregledLog? GetById(int id)
        {
            using var db = new AppDbContext(_dbOptions);
            return db.PregledLogs.FirstOrDefault(f => f.IdPregledLog == id);
        }

        public void Add(PregledLog pregled)
        {
            using var db = new AppDbContext(_dbOptions);
            db.PregledLogs.Add(pregled);
            db.SaveChanges();
        }

        public void Update(PregledLog pregled)
        {
            using var db = new AppDbContext(_dbOptions);
            db.PregledLogs.Update(pregled);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            using var db = new AppDbContext(_dbOptions);
            var pregled = db.PregledLogs.Find(id);
            if (pregled != null)
            {
                db.PregledLogs.Remove(pregled);
                db.SaveChanges();
            }
        }

        public List<StavkaPregledum> GetStavkeByPregledId(int pregledLogId)
        {
            using var db = new AppDbContext(_dbOptions);

            return db.StavkaPregleda
                .Include(s => s.IdObjekatSistemVeznaTabelaNavigation)
                    .ThenInclude(os => os.IdSistemNavigation)
                .Where(s => s.IdPregledLog == pregledLogId)
                .AsNoTracking()
                .ToList();
        }

        /*
         var stavke = GetStavkeByPregledId(pregledLogId);

        foreach (var stavka in stavke)
        {
            var nazivSistema =
                stavka.IdObjekatSistemVeznaTabelaNavigation
                      .IdSistemNavigation
                      .Naziv;

            var napomenaSistema =
                stavka.IdObjekatSistemVeznaTabelaNavigation
                      .IdSistemNavigation
                      .Napomena;

            var zadovoljava = stavka.Zadovoljava;

            var napomenaStavke = stavka.NapomenaStavke;
        }
         */





    }
}
