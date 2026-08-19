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
using projekat_2026.Core;


namespace projekat_2026
{
    public partial class FormMain : Form
    {
        private readonly DbContextOptions<AppDbContext> _dbOptions;
        private readonly Agent _loggedInAgent;
        private ClassDizajnFormi classDizajnFormi = new ClassDizajnFormi();

        private int? _selectedFirmaObjekatId;

        private readonly FirmaObjekatService firmaObjekatService;
        public FormMain(DbContextOptions<AppDbContext> dbOptions, Agent loggedInAgent)
        {
            InitializeComponent();
            _dbOptions = dbOptions;
            _loggedInAgent = loggedInAgent;

            firmaObjekatService = new FirmaObjekatService(dbOptions);

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


            SetupdataGridViewFirmaObjekat();

        }



        private void SetupdataGridViewFirmaObjekat()
        {
            var firme = firmaObjekatService.GetAll().Select(
                f => new
                {
                    f.IdFirmaObjekat, //0
                    f.ImeFirmeObjekat, //1
                    f.Adresa, //2
                    f.Grad, //3
                    f.Pib, //4
                    f.Mb, //5
                    f.BrojZaposlenih, //6
                    Status = f.Aktivan == true ? "Aktivan" : "Neaktivan" //7
                })
                .ToList();
            dataGridViewFirmaObjekat.DataSource = firme;
            dataGridViewFirmaObjekat.RowHeadersVisible = false;
            dataGridViewFirmaObjekat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFirmaObjekat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewFirmaObjekat.Columns["IdFirmaObjekat"].Visible = false;
            dataGridViewFirmaObjekat.Columns["Adresa"].Visible = false;
            dataGridViewFirmaObjekat.Columns["Grad"].Visible = false;
            dataGridViewFirmaObjekat.Columns["Pib"].Visible = false;
            dataGridViewFirmaObjekat.Columns["Mb"].Visible = false;
            dataGridViewFirmaObjekat.Columns["BrojZaposlenih"].Visible = false;
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

        private void dataGridViewFirmaObjekat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
           

            DataGridViewRow row =  dataGridViewFirmaObjekat.Rows[e.RowIndex];

            int IdFirmaObjekat = (int)row.Cells["IdFirmaObjekat"].Value;
            var firma = firmaObjekatService.GetById(IdFirmaObjekat);
            if (firma == null) return;

            textBoxObjekatfirmaIme.Text = firma.ImeFirmeObjekat.ToString();

        }
    }
}
