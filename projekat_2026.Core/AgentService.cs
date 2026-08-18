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




    }
}
