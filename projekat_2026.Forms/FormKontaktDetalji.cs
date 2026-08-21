using Microsoft.EntityFrameworkCore;
using projekat_2026.Core; // Path to your AdresarService
using projekat_2026.Data;
using projekat_2026.Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace projekat_2026
{
    public partial class FormKontaktDetalji : Form
    {
        ClassDizajnFormi classDizajnFormi = new ClassDizajnFormi();

        private readonly DbContextOptions<AppDbContext> _dbOptions;
        private readonly FirmaObjekat _firma;
        private readonly AdresarService _adresarService;

        public FormKontaktDetalji(DbContextOptions<AppDbContext> dbOptions, FirmaObjekat firma)
        {
            InitializeComponent();
            _dbOptions = dbOptions;
            _firma = firma;
            _adresarService = new AdresarService(_dbOptions);

            // Optional: Set default selection for status dropdown
            if (comboBoxAdresarStatus.Items.Count > 0)
            {
                comboBoxAdresarStatus.SelectedIndex = 0;
            }
        }

        private void buttonDodajEmailUTexBox_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text.Trim();
            if (string.IsNullOrEmpty(email)) return;

            if (!classDizajnFormi.isEmail(email))
            {
                MessageBox.Show("Unesite validan E-mail!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listBoxEmail.Items.Add(email);
            textBoxEmail.Clear();
        }

        private void buttonAdresarDodajTelefon_Click(object sender, EventArgs e)
        {
            string telefon = textBoxTelefon.Text.Trim();
            if (string.IsNullOrEmpty(telefon)) return;

            if (!classDizajnFormi.isTelefon(telefon))
            {
                MessageBox.Show("Unesite validan broj telefona", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listBoxTelefon.Items.Add(telefon);
            textBoxTelefon.Clear();
        }

        private void buttonSacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxImePrezime.Text))
                {
                    MessageBox.Show("Molimo unesite ime i prezime.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var novKontakt = new Adresar
                {
                    ImePrezime = textBoxImePrezime.Text.Trim(),
                    Napomena = textBoxNapomena.Text.Trim(),
                    Aktivan = comboBoxAdresarStatus.SelectedItem?.ToString() == "Aktivan",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };

                // 3. Extract items from email and phone ListBoxes
                var emailList = listBoxEmail.Items
                    .Cast<object>()
                    .Select(i => i.ToString())
                    .ToList();

                var telefonList = listBoxTelefon.Items
                    .Cast<object>()
                    .Select(i => i.ToString())
                    .ToList();

                // 4. Save to database via service
                _adresarService.Add(novKontakt, _firma.IdFirmaObjekat, emailList, telefonList);

                MessageBox.Show("Kontakt uspešno dodat!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK; // Signals success to parent form
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri èuvanju kontakta: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}