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
    public partial class FormPregledLista : Form
    {
        private readonly DbContextOptions<AppDbContext> _dbOptions;
        private readonly PregledService pregledService;

        private readonly int _pregledLogId;
        private List<StavkaPregledaVM> _stavke = new();

        private bool _isSaved = false;
        private bool _isDeleted = false;
        private bool _isDirty = false;

        public FormPregledLista(DbContextOptions<AppDbContext> dbOptions, int pregledLogId)
        {
            InitializeComponent();

            _dbOptions = dbOptions;
            pregledService = new PregledService(dbOptions);
            _pregledLogId = pregledLogId;

            LoadPregled();

            dataGridViewStavke.CellValueChanged += MarkDirty;
            textBoxNapomenaCitavogPregleda.TextChanged += MarkDirty;
            dateTimePickerDatumPregleda.ValueChanged += MarkDirty;
        }

        private void LoadPregled()
        {
            var pregled = pregledService.GetById(_pregledLogId);
            if (pregled == null)
            {
                MessageBox.Show("Pregled ne postoji.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            labelFirmaObjekat.Text = $"Firma/Objekat {pregled.IdFirmaObjekatNavigation.ImeFirmeObjekat}";
            labelAgent.Text = $"Agent: {pregled.IdAgentNavigation.ImePrezime}";
            dateTimePickerDatumPregleda.Value = pregled.DatumPregleda.ToDateTime(TimeOnly.MinValue);
            textBoxNapomenaCitavogPregleda.Text = pregled.Napomena;

            SetupDataGridViewStavke();
        }

        private void SetupDataGridViewStavke()
        {
            _stavke = pregledService.GetStavkeByPregledId(_pregledLogId)
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

            dataGridViewStavke.DataSource = _stavke;
            dataGridViewStavke.RowHeadersVisible = false;
            dataGridViewStavke.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStavke.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewStavke.Columns["IdStavkaPregleda"].Visible = false;
            dataGridViewStavke.Columns["IdPregledLog"].Visible = false;
            dataGridViewStavke.Columns["IdObjekatSistemVeznaTabela"].Visible = false;

            dataGridViewStavke.Columns["NazivSistema"].ReadOnly = true;
            dataGridViewStavke.Columns["Periodika"].ReadOnly = true;
            dataGridViewStavke.Columns["NapomenaSistema"].ReadOnly = true;

            dataGridViewStavke.Columns["NazivSistema"].FillWeight = 25;
            dataGridViewStavke.Columns["Periodika"].FillWeight = 10;
            dataGridViewStavke.Columns["NapomenaSistema"].FillWeight = 20;
            dataGridViewStavke.Columns["Zadovoljava"].FillWeight = 10;
            dataGridViewStavke.Columns["NapomenaStavke"].FillWeight = 35;
        }

        private void MarkDirty(object sender, EventArgs e) => _isDirty = true;

        private void buttonSacuvaj_Click(object sender, EventArgs e)
        {
            dataGridViewStavke.EndEdit();

            var updateDtos = _stavke.Select(s => new StavkaPregledaUpdateDto
            {
                IdStavkaPregleda = s.IdStavkaPregleda,
                Zadovoljava = s.Zadovoljava,
                NapomenaStavke = s.NapomenaStavke
            }).ToList();

            try
            {
                pregledService.SavePregled(
                    _pregledLogId,
                    textBoxNapomenaCitavogPregleda.Text,
                    dateTimePickerDatumPregleda.Value,
                    updateDtos);

                _isSaved = true;
                _isDirty = false;
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Pregled je saèuvan.", "Uspešno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom snimanja: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonObrisiPregled_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Da li ste sigurni da želite da obrišete ovaj pregled? Ova akcija je nepovratna.",
                "Brisanje pregleda",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                pregledService.DeletePregled(_pregledLogId);
                _isDeleted = true;
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Pregled je obrisan.", "Uspešno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom brisanja: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormPregledLista_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isDeleted || !_isDirty) return;

            var confirm = MessageBox.Show(
                "Imate nesaèuvane izmene. Zatvoriti bez èuvanja?",
                "Nesaèuvane izmene",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                e.Cancel = true;
        }
    }
}
