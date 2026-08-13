using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using projekat_2026.Data;
using projekat_2026.Data.Models;
using System;
using System.Windows.Forms;
using projekat_2026.Core;

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
            Application.Run(new FormLogin(optionsBuilder.Options));
        }
    }
}