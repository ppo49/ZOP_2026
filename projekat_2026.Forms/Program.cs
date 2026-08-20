using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using projekat_2026.Core;
using projekat_2026.Data;
using projekat_2026.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace projekat_2026
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            
            // Build config and connection string
            var config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            var connString = config.GetConnectionString("ProjectDatabase");
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseMySql(connString, ServerVersion.Parse("5.5.62-mysql"));
            /*
            using var db = new AppDbContext(optionsBuilder.Options);
            var auth = new AuthService();

            var testAgent = new Agent
            {
                ImePrezime = "Test Agent",
                SluzbeniEmail = "test@test.com",
                SluzbeniTelefon = "0600000000",
                Pwd = auth.HashPassword("test123"),
                Role = "agent" // or however your enum-mapped property is typed
            };
            db.Agents.Add(testAgent);
            db.SaveChanges();


            */

            // Program.cs — temporary seeding block, same pattern as the test agent seed
            using var seedDb = new AppDbContext(optionsBuilder.Options);

            

            Application.Run(new FormLogin(optionsBuilder.Options));
        }
    }
}