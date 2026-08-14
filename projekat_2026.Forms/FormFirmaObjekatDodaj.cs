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
    public partial class FormFirmaObjekatDodaj : Form
    {

        private readonly FirmaObjekatService firmaObjekatService;

        public FormFirmaObjekatDodaj(DbContextOptions<AppDbContext> dbOptions)
        {
            InitializeComponent();
            firmaObjekatService = new FirmaObjekatService(dbOptions);

            dataGridViewSistemi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSistemi.ReadOnly = true;
            dataGridViewSistemi.MultiSelect = false;
            dataGridViewSistemi.RowHeadersVisible = false;

            dataGridViewAdresar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAdresar.ReadOnly = true;
            dataGridViewAdresar.MultiSelect = false;
            dataGridViewAdresar.RowHeadersVisible = false;

            labelDatumAktivnosti.Text = $"Datum aktivnosti: {DateOnly.FromDateTime(DateTime.Now)}";

        }

        private void tableLayoutPanelFirmaObjekat_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.LightGray, 1))
            {

                Rectangle rect = e.CellBounds;


                e.Graphics.DrawLine(pen, rect.Left, rect.Bottom - 1, rect.Right, rect.Bottom - 1);

            }
        }

        private void buttonDodajSistem_Click(object sender, EventArgs e)
        {

        }

        private void buttonSacuvaj_Click(object sender, EventArgs e)
        {

            int.TryParse(textBoxBrZaposlenih.Text, out int brZaposlenih);
            bool isAktivan = comboBoxStatus.SelectedItem?.ToString() == "Aktivan";

            var novaFirma = new FirmaObjekat
            {
                ImeFirmeObjekat = textBoxImeFirmeObjekta.Text.ToString(),
                BrojZaposlenih = brZaposlenih,
                Adresa = textBoxAdresa.Text.ToString(),
                Grad = textBoxGrad.Text.ToString(),
                Pib = textBoxPib.Text.ToString(),
                Mb = textBoxMb.Text.ToString(),
                Aktivan = isAktivan,
                DatumAktivnosti = DateOnly.FromDateTime(DateTime.Now), // Returns: 2026-08-14
                CreatedAt = DateTime.Now.Date,
                UpdatedAt = DateTime.Now.Date
            };

            if (dataGridViewSistemi.Rows.Count != 0)
            {
                for (int i = 0; i <= dataGridViewSistemi.Rows.Count; i++)
                {

                }
            }
        }

        private void buttonSistemDodajUTabelu_Click(object sender, EventArgs e)
        {
        }
    }
}
