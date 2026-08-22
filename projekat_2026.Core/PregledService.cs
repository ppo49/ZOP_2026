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
            return db.PregledLogs
                .Include(p => p.IdFirmaObjekatNavigation)
                .Include(p => p.IdAgentNavigation)
                .AsNoTracking()
                .FirstOrDefault(p => p.IdPregledLog == id);
        }

        public List<PregledLog> GetByFirmaObjekatId(int idFirmaObjekat)
        {
            using var db = new AppDbContext(_dbOptions);
            return db.PregledLogs
                .Include(p => p.IdAgentNavigation)
                .Where(p => p.IdFirmaObjekat == idFirmaObjekat)
                .OrderByDescending(p => p.DatumPregleda)
                .ToList();
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
        public int CreatePregled(int idFirmaObjekat, int idAgent, string? napomena = null)
        {
            using var db = new AppDbContext(_dbOptions);
            using var transaction = db.Database.BeginTransaction();
            try
            {
                var noviPregled = new PregledLog
                {
                    IdFirmaObjekat = idFirmaObjekat,
                    IdAgent = idAgent,
                    DatumPregleda = DateOnly.FromDateTime(DateTime.Now),
                    Napomena = napomena,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now

                };
                db.PregledLogs.Add(noviPregled);
                db.SaveChanges();

                var sistemiNaObjektu = db.ObjekatSistemVeznaTabelas
                    .Where(os => os.IdFirmaObjekat == idFirmaObjekat)
                    .ToList();

                foreach (var sistem in sistemiNaObjektu)
                {
                    db.StavkaPregleda.Add(new StavkaPregledum
                    {
                        IdPregledLog = noviPregled.IdPregledLog,
                        IdObjekatSistemVeznaTabela = sistem.IdObjekatSistemVeznaTabela,
                        Zadovoljava = false,      
                        NapomenaStavke = null,
                    });
                }

                db.SaveChanges();
                transaction.Commit();
                return noviPregled.IdPregledLog;
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        public void SavePregled(int pregledLogId, string? napomena, DateTime datum, List<StavkaPregledaUpdateDto> stavke)
        {
            using var db = new AppDbContext(_dbOptions);
            using var transaction = db.Database.BeginTransaction();
            try
            {
                var pregled = db.PregledLogs.FirstOrDefault(p => p.IdPregledLog == pregledLogId);
                if (pregled == null)
                    throw new InvalidOperationException("Pregled ne postoji.");

                pregled.Napomena = napomena;
                pregled.UpdatedAt = DateTime.Now;
                pregled.DatumPregleda = DateOnly.FromDateTime(datum);

                var stavkaIds = stavke.Select(s => s.IdStavkaPregleda).ToList();
                var dbStavke = db.StavkaPregleda
                    .Where(s => stavkaIds.Contains(s.IdStavkaPregleda))
                    .ToList();

                foreach (var dbStavka in dbStavke)
                {
                    var updated = stavke.First(s => s.IdStavkaPregleda == dbStavka.IdStavkaPregleda);
                    dbStavka.Zadovoljava = updated.Zadovoljava;
                    dbStavka.NapomenaStavke = updated.NapomenaStavke;
                }

                db.SaveChanges();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        public void DeletePregled(int pregledLogId)
        {
            using var db = new AppDbContext(_dbOptions);
            using var transaction = db.Database.BeginTransaction();
            try
            {
                var stavke = db.StavkaPregleda.Where(s => s.IdPregledLog == pregledLogId);
                db.StavkaPregleda.RemoveRange(stavke);

                var pregled = db.PregledLogs.FirstOrDefault(p => p.IdPregledLog == pregledLogId);
                if (pregled != null)
                    db.PregledLogs.Remove(pregled);

                db.SaveChanges();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

    }
}
