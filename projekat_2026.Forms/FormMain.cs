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
        //private readonly SistemService sistemService;
        private readonly ObjekatSistemService objekatSistemService;
        private readonly AdresarService adresarService;
        
        public FormMain(DbContextOptions<AppDbContext> dbOptions, Agent loggedInAgent)
        {
            InitializeComponent();
            _dbOptions = dbOptions;
            _loggedInAgent = loggedInAgent;

            firmaObjekatService = new FirmaObjekatService(dbOptions);
            //sistemService = new SistemService(dbOptions);
            objekatSistemService = new ObjekatSistemService(dbOptions);
            adresarService = new AdresarService(dbOptions);

            this.Text = $"ZOP, {_loggedInAgent.ImePrezime}";

            textBoxAgentSifra.UseSystemPasswordChar = true;

            //classDizajnFormi.setAllTextBoxesReadOnly(this, true);

            textBoxFrimaOjekatFilter.ReadOnly = false;

            textBoxAgentSifra.Text = _loggedInAgent.Pwd.ToString();
            textBoxAgentSluzbeniEmail.Text = _loggedInAgent.SluzbeniEmail.ToString();
            textBoxAgentImePrzime.Text = _loggedInAgent.ImePrezime.ToString();
            textBoxAgentSluzbeniTelefon.Text = _loggedInAgent.SluzbeniTelefon.ToString();
            labelAgentRole.Text = $"Role: {_loggedInAgent.Role.ToString()}";
            labelAgentStatusAktivnosti.Text = $"Status Aktivnosti: {_loggedInAgent.StatusAktivnosti.ToString()}";


            SetupdataGridViewFirmaObjekat();

        }

        private void SetupdataGridViewAdresar(int idFirmaObjekat)
        {
            var adresar = adresarService.GetAdresarFullForFirmaObjekat(idFirmaObjekat)
                .Select(a => new
                {
                    a.IdAdresar,
                    //a.IdFirmaObjekats,
                    ImePrezime = a.ImePrezime,
                    Emails = string.Join(", ", a.Emails.Select(e=>e.Email1)),
                    Telefoni = string.Join(", ", a.Telefons.Select(e => e.Telefon1)),
                    a.Napomena,
                    a.Aktivan,
                    a.CreatedAt,
                    a.UpdatedAt
                })
                .ToList();

            dataGridViewAdresar.DataSource = adresar;
            dataGridViewAdresar.RowHeadersVisible = false;
            dataGridViewAdresar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAdresar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //ZAVRSI OVO

        }

        private void SetupdataGridViewSistemi(int idFirmaObjekat)
        {
            var stavke = objekatSistemService.GetByFirmaObjekat(idFirmaObjekat)
                .Select(o => new
                {
                    o.IdObjekatSistemVeznaTabela,
                    Nazivsistema = o.IdSistemNavigation.Naziv,
                    Periodika = o.IdSistemNavigation.Periodika,
                    o.Napomena
                })
                .ToList();

            dataGridViewSistemi.DataSource = stavke;
            dataGridViewSistemi.RowHeadersVisible = false;
            dataGridViewSistemi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSistemi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewSistemi.Columns["IdObjekatSistemVeznaTabela"].Visible = false;

            dataGridViewSistemi.Columns["NazivSistema"].FillWeight = 40;
            dataGridViewSistemi.Columns["Periodika"].FillWeight = 10;
            dataGridViewSistemi.Columns["Napomena"].FillWeight = 50;
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


            DataGridViewRow row = dataGridViewFirmaObjekat.Rows[e.RowIndex];

            _selectedFirmaObjekatId = (int)row.Cells["IdFirmaObjekat"].Value;
            var firma = firmaObjekatService.GetById(_selectedFirmaObjekatId.Value);
            if (firma == null) return;

            textBoxImeFirmeObjekat.Text = firma.ImeFirmeObjekat;
            textBoxPib.Text = firma.Pib;
            textBoxMb.Text = firma.Mb;
            textBoxAdresaObjekta.Text = firma.Adresa;
            textBoxGrad.Text = firma.Grad;
            textBoxDatumAktivnosti.Text = firma.DatumAktivnosti.ToString();
            numericUpDownBrZaposlenih.Value = firma.BrojZaposlenih;
            textBoxCreatedAt.Text = firma.CreatedAt.ToString("dd.MM.yyyy HH:mm");
            textBoxUpdatedAt.Text = firma.UpdatedAt.ToString("dd.MM.yyyy HH:mm");
            comboBoxStatus.SelectedItem = firma.Aktivan == true ? "Aktivan" : "Neaktivan";


            SetupdataGridViewSistemi(_selectedFirmaObjekatId.Value);
        }

        private void buttonAzurirajObjekat_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedFirmaObjekatId == null)
                {
                    MessageBox.Show("Molimo izaberite firmu/objekat.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBoxImeFirmeObjekat.Text) ||
                    string.IsNullOrWhiteSpace(textBoxPib.Text) ||
                    string.IsNullOrWhiteSpace(textBoxMb.Text))
                {
                    MessageBox.Show("Molimo popunite sva obavezna polja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var firma = firmaObjekatService.GetById(_selectedFirmaObjekatId.Value);
                if (firma == null) return;

                firma.ImeFirmeObjekat = textBoxImeFirmeObjekat.Text.Trim();
                firma.Pib = textBoxPib.Text.Trim();
                firma.Mb = textBoxMb.Text.Trim();
                firma.Adresa = textBoxAdresaObjekta.Text.Trim();
                firma.Grad = textBoxGrad.Text.Trim();
                firma.BrojZaposlenih = (int)numericUpDownBrZaposlenih.Value;
                firma.Aktivan = comboBoxStatus.SelectedItem?.ToString() == "Aktivan";

                firmaObjekatService.Update(firma);
                MessageBox.Show("Podaci uspešno ažurirani.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetupdataGridViewFirmaObjekat();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
