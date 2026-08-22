using Microsoft.EntityFrameworkCore;
using projekat_2026.Core;
using projekat_2026.Data;
using projekat_2026.Data.Models;
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
    public partial class FormPregled : Form
    {
        private readonly DbContextOptions<AppDbContext> _dbOptions;
        private readonly Agent _loggedInAgent;
        private readonly FirmaObjekat _firmaObjekat;

        private readonly FirmaObjekatService firmaObjekatService;
        private readonly SistemService sistemService;
        private readonly ObjekatSistemService objekatSistemService;
        private readonly PregledService pregledService;

        private bool _isSaved = false;
        private bool _isCancelled = false;


        public FormPregled(DbContextOptions<AppDbContext> dbOptions, Agent loggedInAgent, FirmaObjekat firmaObjekat)
        {
            InitializeComponent();
            _dbOptions = dbOptions;
            _loggedInAgent = loggedInAgent;
            _firmaObjekat = firmaObjekat;

            firmaObjekatService = new FirmaObjekatService(dbOptions);
            sistemService = new SistemService(dbOptions);
            objekatSistemService = new ObjekatSistemService(dbOptions);
            pregledService = new PregledService(dbOptions);


            int noviPregledId = pregledService.CreatePregled(firmaObjekat.IdFirmaObjekat, _loggedInAgent.IdAgent);

            labelAgent.Text = $"Agent: {_loggedInAgent.ImePrezime}";
            labelFirmaObjekat.Text = $"Firma/Objekat: {_firmaObjekat.ImeFirmeObjekat}";

            SetupdataGridViewPregledStavke(noviPregledId);

        }

        private List<StavkaPregledaVM> _stavke = new();
        private int _currentPregledLogId;

        private void SetupdataGridViewPregledStavke(int pregledLogId)
        {
            _currentPregledLogId = pregledLogId;

            _stavke = pregledService.GetStavkeByPregledId(pregledLogId)
                .Select(s => new StavkaPregledaVM
                {
                    IdStavkaPregleda = s.IdStavkaPregleda,
                    IdPregledLog = s.IdPregledLog,
                    IdObjekatSistemVeznaTabela = s.IdObjekatSistemVeznaTabela,
                    NazivSistema = s.IdObjekatSistemVeznaTabelaNavigation.IdSistemNavigation.Naziv,
                    Periodika = s.IdObjekatSistemVeznaTabelaNavigation.IdSistemNavigation.Periodika,
                    NapomenaSistema = s.IdObjekatSistemVeznaTabelaNavigation.Napomena,
                    Zadovoljava = s.Zadovoljava,
                    NapomenaStavke = s.NapomenaStavke
                })
                .ToList();

            dataGridViewPregledStavke.DataSource = _stavke;
            dataGridViewPregledStavke.RowHeadersVisible = false;
            dataGridViewPregledStavke.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPregledStavke.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewPregledStavke.Columns["IdStavkaPregleda"].Visible = false;
            dataGridViewPregledStavke.Columns["IdPregledLog"].Visible = false;
            dataGridViewPregledStavke.Columns["IdObjekatSistemVeznaTabela"].Visible = false;

            dataGridViewPregledStavke.Columns["NazivSistema"].ReadOnly = true;
            dataGridViewPregledStavke.Columns["Periodika"].ReadOnly = true;
            dataGridViewPregledStavke.Columns["NapomenaSistema"].ReadOnly = true;
            dataGridViewPregledStavke.Columns["Zadovoljava"].ReadOnly = false;
            dataGridViewPregledStavke.Columns["NapomenaStavke"].ReadOnly = false;

            dataGridViewPregledStavke.Columns["NazivSistema"].FillWeight = 25;
            dataGridViewPregledStavke.Columns["Periodika"].FillWeight = 10;
            dataGridViewPregledStavke.Columns["NapomenaSistema"].FillWeight = 20;
            dataGridViewPregledStavke.Columns["Zadovoljava"].FillWeight = 10;
            dataGridViewPregledStavke.Columns["NapomenaStavke"].FillWeight = 35;
        }

        private void buttonSacuvaj_Click(object sender, EventArgs e)
        {
            dataGridViewPregledStavke.EndEdit();

            var updateDtos = _stavke.Select(s => new StavkaPregledaUpdateDto
            {
                IdStavkaPregleda = s.IdStavkaPregleda,
                Zadovoljava = s.Zadovoljava,
                NapomenaStavke = s.NapomenaStavke
            }).ToList();

            try
            {
                pregledService.SavePregled(_currentPregledLogId, textBoxNapomenaCitavogPregleda.Text, dateTimePickerDatumPregleda.Value, updateDtos);
                _isSaved = true;
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Pregled je saèuvan.", "Uspešno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom snimanja: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPonisti_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Da li ste sigurni da želite da poništite ovaj pregled? Sve unete izmene æe biti izgubljene.",
                "Poništi pregled", MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                );

            if (confirm == DialogResult.Yes)
            {
                _isCancelled = true;
                Close();
            }
        }

        private void FormPregled_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isSaved) return;

            if (!_isCancelled)
            {
                // korisnik je zatvorio formu preko X, ne preko dugmeta Poništi
                var confirm = MessageBox.Show(
                    "Pregled nije saèuvan. Ako zatvorite formu, pregled æe biti obrisan. Nastaviti?",
                    "Nesaèuvane izmene",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm != DialogResult.Yes)
                {
                    e.Cancel = true; // ostaje otvorena forma
                    return;
                }
            }

            try
            {
                pregledService.DeletePregled(_currentPregledLogId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom brisanja pregleda: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
