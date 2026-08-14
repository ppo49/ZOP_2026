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
    public class AgentService
    {
        private readonly DbContextOptions<AppDbContext> _dbOptions;

        public AgentService(DbContextOptions<AppDbContext> dbOptions)
        {
            _dbOptions = dbOptions;
        }

        public List<Agent> GetAll()
        {
            using var db = new AppDbContext(_dbOptions);
            return db.Agents.ToList();
        }

        public Agent? GetById(int id)
        {
            using var db = new AppDbContext(_dbOptions);
            return db.Agents.FirstOrDefault(f => f.IdAgent == id);
        }

        public void Add(Agent agent)
        {
            using var db = new AppDbContext(_dbOptions);
            db.Agents.Add(agent);
            db.SaveChanges();
        }

        public void Update(Agent agent)
        {
            using var db = new AppDbContext(_dbOptions);
            db.Agents.Update(agent);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            using var db = new AppDbContext(_dbOptions);
            var agent = db.Agents.Find(id);
            if (agent != null)
            {
                db.Agents.Remove(agent);
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
                .Where(a => a.IdFirmaObjekats.Any(f => f.IdFirmaObjekat==firmaObjekatId))
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
