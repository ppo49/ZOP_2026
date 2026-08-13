using Microsoft.EntityFrameworkCore;
using projekat_2026.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace projekat_2026
{
   
    public partial class FormLogin : Form
    {
        private readonly DbContextOptions<AppDbContext> _dbOptions;
        public FormLogin(DbContextOptions<AppDbContext> dbOptions)
        {
            InitializeComponent();
            _dbOptions = dbOptions;
        }
    }
}
