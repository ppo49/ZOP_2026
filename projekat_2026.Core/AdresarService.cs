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
    public class AdresarService
    {
        private readonly DbContextOptions<AppDbContext> _dbOptions;

        public AdresarService(DbContextOptions<AppDbContext> dbOptions)
        {
            _dbOptions = dbOptions;
        }


        public List<Adresar> GetAll()
        {
            using var db = new AppDbContext(_dbOptions);
            return db.Adresars.ToList();
        }

        public Adresar? GetById(int id)
        {
            using var db = new AppDbContext(_dbOptions);
            return db.Adresars.FirstOrDefault(a => a.IdAdresar == id);
        }

        public void Add(Adresar adresar)
        {
            using var db = new AppDbContext(_dbOptions);
            db.Adresars.Add(adresar);
            db.SaveChanges();
        }

        public void Update(Adresar adresar)
        {
            using var db = new AppDbContext(_dbOptions);
            db.Adresars.Update(adresar);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            using var db = new AppDbContext(_dbOptions);
            var adresar = db.Adresars.Find(id);
            if (adresar != null)
            {
                db.Adresars.Remove(adresar);
                db.SaveChanges();
            }
        }


        public List<Telefon> GetTelefonsbyAdresarId(int adresarId)
        {
            using var db = new AppDbContext(_dbOptions);
            return db.Telefons.Where(t => t.IdAdresar == adresarId).ToList();
        }

        public void DeleteTelefonbyAdresarId(int adresarId)
        {
            using var db = new AppDbContext(_dbOptions);
            var telefon = db.Telefons.FirstOrDefault(t => t.IdAdresar == adresarId);
            if (telefon != null)
            {
                db.Telefons.Remove(telefon);
                db.SaveChanges();
            }
        }

        public void AddTelefonByAdresarId(int adresarId, string brojTelefona)
        {
            using var db = new AppDbContext(_dbOptions);
            var noviTelefon = new Telefon
            {
                IdAdresar = adresarId,
                Telefon1 = brojTelefona
            };
            db.Telefons.Add(noviTelefon);
            db.SaveChanges();

        }

        public List<Email> GetEmailsbyAdresarId(int adresarId)
        {
            using var db = new AppDbContext(_dbOptions);
            return db.Emails.Where(t => t.IdAdresar == adresarId).ToList();
        }

        public void DeleteEmailbyAdresarId(int adresarId)
        {
            using var db = new AppDbContext(_dbOptions);
            var email = db.Emails.FirstOrDefault(t => t.IdAdresar == adresarId);
            if (email != null)
            {
                db.Emails.Remove(email);
                db.SaveChanges();
            }
        }

        public void AddEmailByAdresarId(int adresarId, string email)
        {
            using var db = new AppDbContext(_dbOptions);
            var noviEmail = new Email
            {
                IdAdresar = adresarId,
                Email1 = email
            };
            db.Emails.Add(noviEmail);
            db.SaveChanges();

        }

        public List<Adresar> GetAdresarOnlyNameForFirmaObjekat(int firmaObjekatId)
        {
            using var db = new AppDbContext(_dbOptions);
            return db.Adresars
                .Where(a => a.IdFirmaObjekats.Any(f => f.IdFirmaObjekat == firmaObjekatId))
                .AsNoTracking()
                .ToList();
        }

        public List<Adresar> GetAdresarFullForFirmaObjekat(int firmaObjekatId)
        {
            using var db = new AppDbContext(_dbOptions);

            return db.Adresars
                .Include(a => a.Telefons)
                .Include(a => a.Emails)
                .Where(a => a.IdFirmaObjekats.Any(f => f.IdFirmaObjekat == firmaObjekatId))
                .AsNoTracking()
                .ToList();
        }
    }
}
