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

using projekat_2026.Data.Models;


namespace projekat_2026
{
    public partial class FormMain : Form
    {
        private readonly DbContextOptions<AppDbContext> _dbOptions;
        private readonly Agent _loggedInAgent;
        private ClassDizajnFormi classDizajnFormi = new ClassDizajnFormi();
        public FormMain(DbContextOptions<AppDbContext> dbOptions, Agent loggedInAgent)
        {
            InitializeComponent();
            _dbOptions = dbOptions;
            _loggedInAgent = loggedInAgent;

            this.Text = $"ZOP, {_loggedInAgent.ImePrezime}";

            textBoxAgentSifra.UseSystemPasswordChar = true;

            classDizajnFormi.setAllTextBoxesReadOnly(this, true);

            textBoxFrimaOjekatFilter.ReadOnly = false;

            textBoxAgentSifra.Text = _loggedInAgent.Pwd.ToString();
            textBoxAgentSluzbeniEmail.Text = _loggedInAgent.SluzbeniEmail.ToString();
            textBoxAgentImePrzime.Text = _loggedInAgent.ImePrezime.ToString();
            textBoxAgentSluzbeniTelefon.Text = _loggedInAgent.SluzbeniTelefon.ToString();
            labelAgentRole.Text = $"Role: {_loggedInAgent.Role.ToString()}";
            labelAgentStatusAktivnosti.Text = $"Status Aktivnosti: {_loggedInAgent.StatusAktivnosti.ToString()}";

            dataGridViewFirmaObjekat.RowHeadersVisible = false;
            dataGridViewFirmaObjekat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }




        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonDodajFirmaObjekat_Click(object sender, EventArgs e)
        {
            FormFirmaObjekatDodaj formFirmaObjekatDodaj = new FormFirmaObjekatDodaj(_dbOptions);
            formFirmaObjekatDodaj.ShowDialog();
        }

        private void toolStripButtondodajFirmu_Click(object sender, EventArgs e)
        {
            FormFirmaObjekatDodaj formFirmaObjekatDodaj = new FormFirmaObjekatDodaj(_dbOptions);
            formFirmaObjekatDodaj.ShowDialog();
        }
    }
}
