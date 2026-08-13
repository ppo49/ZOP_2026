using Microsoft.Extensions.Configuration;
using System;
using System.Windows.Forms;
using projekat_2026.Data;
using Microsoft.EntityFrameworkCore;

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

            Application.Run(new FormLogin(optionsBuilder.Options));
        }
    }
}