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
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekat_2026
{
    public partial class FormFirmaObjekatDodaj : Form
    {
        private ClassDizajnFormi classDizajnFormi = new ClassDizajnFormi();

        private readonly FirmaObjekatService firmaObjekatService;
        private readonly SistemService sistemService;
        private readonly DbContextOptions<AppDbContext> _dbOptions;

        private FirmaObjekat novaFirma;
        private List<ObjekatSistemVeznaTabela> listaSistema = new List<ObjekatSistemVeznaTabela>();
        private List<Adresar> listaAdresar = new List<Adresar>();

        private bool _allowTabChange = false;

        public FormFirmaObjekatDodaj(DbContextOptions<AppDbContext> dbOptions)
        {
            InitializeComponent();

            firmaObjekatService = new FirmaObjekatService(dbOptions);
            sistemService = new SistemService(dbOptions);

            _dbOptions = dbOptions;

            labelDatumAktivnosti.Text = $"Datum aktivnosti: {DateOnly.FromDateTime(DateTime.Now)}";

            numericUpDownBrZaposlenih.Minimum = 0;
            numericUpDownBrZaposlenih.Maximum = 10000;

            textBoxPib.MaxLength = 9;
            textBoxMb.MaxLength = 8;

            comboBoxStatus.SelectedIndex = 0;

            setupDataGridViewSistem();
            setupComboBoxSistem();
            setupDataGridViewAdresar();
        }

        private void tabControlDodajFirmuObjekat_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!_allowTabChange)
            {
                e.Cancel = true;
            }
        }

        private void SwitchToTab(int tabIndex)
        {
            _allowTabChange = true;
            tabControlDodajFirmuObjekat.SelectedIndex = tabIndex;
            _allowTabChange = false;
        }

        private void buttonOcisti_Click(object sender, EventArgs e)
        {
            classDizajnFormi.clearTabPageContent(tabPageOsnovniPodaci);
        }

        private void setupComboBoxSistem()
        {
            comboBoxSistemi.DataSource = sistemService.GetNameAndId();
            comboBoxSistemi.DisplayMember = "Naziv";
            comboBoxSistemi.ValueMember = "IdSistem";
        }

        private void setupDataGridViewSistem()
        {
            dataGridViewSistemi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSistemi.ReadOnly = true;
            dataGridViewSistemi.MultiSelect = false;
            dataGridViewSistemi.RowHeadersVisible = false;

            dataGridViewSistemi.ColumnCount = 3;
            dataGridViewSistemi.Columns[0].Name = "IdSistem";
            dataGridViewSistemi.Columns[0].Visible = false;

            dataGridViewSistemi.Columns[1].Name = "NazivSistema";
            dataGridViewSistemi.Columns[1].HeaderText = "Naziv sistema";

            dataGridViewSistemi.Columns[2].Name = "Napomena";
            dataGridViewSistemi.Columns[2].HeaderText = "Napomena";

            dataGridViewSistemi.ContextMenuStrip = contextMenuStripIzbrisi;

            dataGridViewSistemi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void setupDataGridViewAdresar()
        {
            dataGridViewAdresar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAdresar.ReadOnly = true;
            dataGridViewAdresar.MultiSelect = false;
            dataGridViewAdresar.RowHeadersVisible = false;

            dataGridViewAdresar.ColumnCount = 5;
            dataGridViewAdresar.Columns[0].Name = "idAdresar";
            dataGridViewAdresar.Columns[0].Visible = false;

            dataGridViewAdresar.Columns[1].Name = "ImePrezime";
            dataGridViewAdresar.Columns[1].HeaderText = "Ime i prezime";

            dataGridViewAdresar.Columns[2].Name = "Email";
            dataGridViewAdresar.Columns[2].HeaderText = "Email";

            dataGridViewAdresar.Columns[3].Name = "Telefon";
            dataGridViewAdresar.Columns[3].HeaderText = "Telefon";

            dataGridViewAdresar.Columns[4].Name = "Napomena";
            dataGridViewAdresar.Columns[4].HeaderText = "Napomena";

            dataGridViewAdresar.ContextMenuStrip = contextMenuStripIzbrisi;

            dataGridViewAdresar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void keyPressFunction(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void DeleteSelectedRowFromMenuItem(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem && menuItem.Owner is ContextMenuStrip contextMenu)
            {
                if (contextMenu.SourceControl is DataGridView dgv)
                {
                    if (dgv.SelectedRows.Count > 0 && !dgv.SelectedRows[0].IsNewRow)
                    {
                        dgv.Rows.RemoveAt(dgv.SelectedRows[0].Index);
                    }
                }
                else if (contextMenu.SourceControl is ListBox lbx)
                {
                    if (lbx.SelectedIndex != -1)
                    {
                        lbx.Items.RemoveAt(lbx.SelectedIndex);
                    }
                }
            }
        }

        private void buttonSistemDodajUTabelu_Click(object sender, EventArgs e)
        {
            if (comboBoxSistemi.SelectedValue == null)
            {
                MessageBox.Show("Molimo izaberite sistem.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idSistem = (int)comboBoxSistemi.SelectedValue;
            string nazivSistema = comboBoxSistemi.Text;
            string napomenaSistema = textBoxSistemNapomena.Text;

            dataGridViewSistemi.Rows.Add(idSistem, nazivSistema, napomenaSistema);
            textBoxSistemNapomena.Clear();
        }

        private void buttonSledeci1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxImeFirmeObjekta.Text) ||
                string.IsNullOrWhiteSpace(textBoxAdresa.Text) ||
                string.IsNullOrWhiteSpace(textBoxGrad.Text) ||
                string.IsNullOrWhiteSpace(textBoxPib.Text) ||
                string.IsNullOrWhiteSpace(textBoxMb.Text))
            {
                MessageBox.Show("Molimo vas popunite sva obavezna polja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int.TryParse(numericUpDownBrZaposlenih.Value.ToString(), out int brZaposlenih);
            bool isAktivan = comboBoxStatus.SelectedItem?.ToString() == "Aktivan";

            novaFirma = new FirmaObjekat
            {
                ImeFirmeObjekat = textBoxImeFirmeObjekta.Text.Trim(),
                BrojZaposlenih = brZaposlenih,
                Adresa = textBoxAdresa.Text.Trim(),
                Grad = textBoxGrad.Text.Trim(),
                Pib = textBoxPib.Text.Trim(),
                Mb = textBoxMb.Text.Trim(),
                Aktivan = isAktivan,
                DatumAktivnosti = DateOnly.FromDateTime(DateTime.Now),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            SwitchToTab(1);
        }

        private void buttonPonisti_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Da li ste sigurni da želite da poništite? Sve unete informacije æe biti izbrisane.",
                "Poništi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void buttonSledeci2_Click(object sender, EventArgs e)
        {
            if (dataGridViewAdresar.Rows.Count == 0 || (dataGridViewAdresar.Rows.Count == 1 && dataGridViewAdresar.Rows[0].IsNewRow))
            {
                DialogResult result = MessageBox.Show("Tabela Adresar je prazna. Da li želite da preskoèite ovaj korak?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    ResetAdresarInputs();
                    SwitchToTab(2);
                    return; // Early exit prevents executing the rest of the method
                }
                return;
            }

            listaAdresar.Clear();

            foreach (DataGridViewRow row in dataGridViewAdresar.Rows)
            {
                if (row.IsNewRow) continue;

                string imePrezime = row.Cells[1].Value?.ToString() ?? string.Empty;
                string emailAdresa = row.Cells[2].Value?.ToString() ?? string.Empty;
                string telefonBroj = row.Cells[3].Value?.ToString() ?? string.Empty;
                string napomena = row.Cells[4].Value?.ToString() ?? string.Empty;

                if (string.IsNullOrWhiteSpace(imePrezime)) continue;


                var noviAdresar = new Adresar
                {
                    //IdAdresar = idAdresar,
                    ImePrezime = imePrezime,
                    Aktivan = true,
                    Napomena = napomena,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Emails = emailAdresa
                        .Split(',', StringSplitOptions.RemoveEmptyEntries)
                        .Select(eStr => new Email { Email1 = eStr.Trim() })
                        .ToList(),
                    Telefons = telefonBroj
                        .Split(',', StringSplitOptions.RemoveEmptyEntries)
                        .Select(tStr => new Telefon { Telefon1 = tStr.Trim() })
                        .ToList(),
                    IdFirmaObjekats = new List<FirmaObjekat> { novaFirma }
                };

                listaAdresar.Add(noviAdresar);
            }

            SwitchToTab(2);
        }

        private void buttonPreskoci_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Da li ste sigurni da želite da preskoèite? Sve unete informacije o Kontaktima biæe izbrisane.",
                "Preskoèi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ResetAdresarInputs();
                SwitchToTab(2);
            }
        }

        private void ResetAdresarInputs()
        {
            listaAdresar.Clear();
            textBoxEmail.Clear();
            textBoxTelefon.Clear();
            textBoxKontaktImePrezime.Clear();
            textBoxKontaktNapomena.Clear();
            listBoxEmail.Items.Clear();
            listBoxTelefon.Items.Clear();
            dataGridViewAdresar.Rows.Clear();
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

        private void buttonDodajTelefonUTextbox_Click(object sender, EventArgs e)
        {
            string telefon = textBoxTelefon.Text.Trim();
            if (string.IsNullOrEmpty(telefon)) return;

            if (!classDizajnFormi.isTelefon(telefon))
            {
                MessageBox.Show("Unesite validan Telefon!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listBoxTelefon.Items.Add(telefon);
            textBoxTelefon.Clear();
        }

        private void buttonDodajKontaktUTabelu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxKontaktImePrezime.Text.Trim()))
            {
                MessageBox.Show("Polje ime i prezime mora biti popunjeno.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string imeIPrezime = textBoxKontaktImePrezime.Text.Trim();
            string listaEmailova = string.Join(", ", listBoxEmail.Items.Cast<object>());
            string listaTelefona = string.Join(", ", listBoxTelefon.Items.Cast<object>());
            string kontaktNapomena = textBoxKontaktNapomena.Text.Trim();

            dataGridViewAdresar.Rows.Add(0, imeIPrezime, listaEmailova, listaTelefona, kontaktNapomena);

            textBoxKontaktNapomena.Clear();
            textBoxKontaktImePrezime.Clear();
            listBoxEmail.Items.Clear();
            listBoxTelefon.Items.Clear();
        }

        private async void buttonSacuvaj_Click(object sender, EventArgs e)
        {
            if (dataGridViewSistemi.Rows.Count == 0)
            {
                DialogResult result = MessageBox.Show("Tabela Sistemi je prazna. Da li želite da saèuvate bez dodatih sistema?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }
                listaSistema.Clear();
            }
            else
            {
                listaSistema.Clear();
                foreach (DataGridViewRow row in dataGridViewSistemi.Rows)
                {
                    if (row.IsNewRow) continue;

                    string napomena = row.Cells[2].Value?.ToString() ?? string.Empty;

                    if (row.Cells[0].Value != null && int.TryParse(row.Cells[0].Value.ToString(), out int idSistem))
                    {
                        var noviOsvt = new ObjekatSistemVeznaTabela
                        {
                            IdSistem = idSistem,
                            Napomena = napomena,
                            IdFirmaObjekatNavigation = novaFirma
                        };

                        listaSistema.Add(noviOsvt);
                    }
                }
            }

            string pregledPodataka = GenerisiPregledPodataka();


            string poruka = $"PREGLED PODATAKA ZA ÈUVANJE:\n\n" +
                            $"{pregledPodataka}\n\n" +
                            $"Da li ste sigurni da želite da saèuvate ove podatke u bazu?";

            DialogResult confirm = MessageBox.Show(
                poruka,
                "Potvrda èuvanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                await SacuvajSveUBazuAsync();
            }
        }

        private async Task SacuvajSveUBazuAsync()
        {
            try
            {
                buttonSacuvaj.Enabled = false;

                await firmaObjekatService.SaveComplete(novaFirma, listaAdresar, listaSistema);
                MessageBox.Show("Podaci uspešno saèuvani!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                string detalji = ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show($"Greška pri èuvanju u bazu: {detalji}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormFirmaObjekatDodaj_Load(object sender, EventArgs e)
        {
            SwitchToTab(0);
        }

        private void FormFirmaObjekatDodaj_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Skip prompt if the form is closing after a successful save
            if (this.DialogResult == DialogResult.OK)
            {
                return;
            }

            DialogResult result = MessageBox.Show(
                "Da li ste sigurni da želite da napustite formu? Sve nesaèuvane informacije æe biti izbrisane.",
                "Obaveštenje",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                // Cancel the form closing action
                e.Cancel = true;
            }
        }


        private string GenerisiPregledPodataka()
        {
            var sb = new StringBuilder();

            // 1. Osnovni podaci
            sb.AppendLine("OSNOVNI PODACI");
            sb.AppendLine($"Naziv: {(string.IsNullOrWhiteSpace(textBoxImeFirmeObjekta.Text) ? "[Nije uneto]" : textBoxImeFirmeObjekta.Text.Trim())}");
            sb.AppendLine($"Adresa: {(string.IsNullOrWhiteSpace(textBoxAdresa.Text) ? "[Nije uneto]" : textBoxAdresa.Text.Trim())}");
            sb.AppendLine($"Grad: {(string.IsNullOrWhiteSpace(textBoxGrad.Text) ? "[Nije uneto]" : textBoxGrad.Text.Trim())}");
            sb.AppendLine($"PIB: {(string.IsNullOrWhiteSpace(textBoxPib.Text) ? "[Nije uneto]" : textBoxPib.Text.Trim())}");
            sb.AppendLine($"MB: {(string.IsNullOrWhiteSpace(textBoxMb.Text) ? "[Nije uneto]" : textBoxMb.Text.Trim())}");
            sb.AppendLine($"Broj zaposlenih: {numericUpDownBrZaposlenih.Value}");
            sb.AppendLine($"Status: {comboBoxStatus.SelectedItem ?? "Nije izabran"}");
            sb.AppendLine();

            // 2. Kontakti (Adresar)
            var kontakti = dataGridViewAdresar.Rows.Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow)
                .ToList();

            sb.AppendLine($"KONTAKTI ({kontakti.Count})");
            if (kontakti.Any())
            {
                foreach (var row in kontakti)
                {
                    string ime = row.Cells[1].Value?.ToString() ?? "";
                    string email = row.Cells[2].Value?.ToString() ?? "";
                    string tel = row.Cells[3].Value?.ToString() ?? "";
                    sb.AppendLine($"• {ime} | Email: {email} | Tel: {tel}");
                }
            }
            else
            {
                sb.AppendLine("[Nema unetih kontakata]");
            }
            sb.AppendLine();

            // 3. Sistemi
            var sistemi = dataGridViewSistemi.Rows.Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow)
                .ToList();

            sb.AppendLine($"SISTEMI ({sistemi.Count})");
            if (sistemi.Any())
            {
                foreach (var row in sistemi)
                {
                    string naziv = row.Cells[1].Value?.ToString() ?? "";
                    string napomena = row.Cells[2].Value?.ToString() ?? "";
                    sb.AppendLine($"• {naziv}{(string.IsNullOrEmpty(napomena) ? "" : $" ({napomena})")}");
                }
            }
            else
            {
                sb.AppendLine("[Nema unetih sistema]");
            }

            return sb.ToString();
        }

        private void buttonNazad1_Click(object sender, EventArgs e)
        {
            SwitchToTab(0);
        }

        private void buttonNazad2_Click(object sender, EventArgs e)
        {
            SwitchToTab(1);
        }

        private void buttonPreskociSacuvaj_Click(object sender, EventArgs e)
        {

        }
    }
}