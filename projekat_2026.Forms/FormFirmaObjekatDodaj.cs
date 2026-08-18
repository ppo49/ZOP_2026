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
        //private ObjekatSistemVeznaTabela noviOSVTSistem;

        private List<ObjekatSistemVeznaTabela> listaSistema = new List<ObjekatSistemVeznaTabela>();
        private List<Adresar> listaAdresar = new List<Adresar>();

        public FormFirmaObjekatDodaj(DbContextOptions<AppDbContext> dbOptions)
        {
            InitializeComponent();

            tabControlDodajFirmuObjekat.SelectedIndex = 0;

            firmaObjekatService = new FirmaObjekatService(dbOptions);
            sistemService = new SistemService(dbOptions);

            dbOptions = _dbOptions;

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

            if (e.TabPage == tabPageOsnovniPodaci)
            {
                e.Cancel = true;
            }


            if (e.TabPage == tabPageSistemi)
            {
                e.Cancel = true;
            }

            if (e.TabPage == tabPageAdresar)
            {
                e.Cancel = true;
            }

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
            // 1. Get the clicked menu item
            if (sender is ToolStripMenuItem menuItem)
            {
                // 2. Get the ContextMenuStrip hosting the item
                if (menuItem.Owner is ContextMenuStrip contextMenu)
                {
                    // 3. Find which DataGridView triggered this specific menu
                    if (contextMenu.SourceControl is DataGridView dgv)
                    {
                        // 4. Remove the selected row
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
        }

        private void buttonSistemDodajUTabelu_Click(object sender, EventArgs e)
        {

            if (comboBoxSistemi.SelectedValue == null)
            {
                MessageBox.Show("Molimo izaberite sistem.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idSistem = (int)comboBoxSistemi.SelectedValue;
            string nazivSistema = comboBoxSistemi.SelectedValue.ToString();
            string napomenaSistema = textBoxSistemNapomena.Text.ToString();


            dataGridViewSistemi.Rows.Add(idSistem, nazivSistema, napomenaSistema);

            textBoxSistemNapomena.Clear();

        }

        private void buttonSledeci1_Click(object sender, EventArgs e)
        {
            int.TryParse(numericUpDownBrZaposlenih.Value.ToString(), out int brZaposlenih);
            bool isAktivan = comboBoxStatus.SelectedItem?.ToString() == "Aktivan";

            if
                (
                string.IsNullOrWhiteSpace(textBoxImeFirmeObjekta.Text) ||
                string.IsNullOrWhiteSpace(textBoxAdresa.Text) ||
                string.IsNullOrWhiteSpace(textBoxGrad.Text) ||
                string.IsNullOrWhiteSpace(textBoxPib.Text) ||
                string.IsNullOrWhiteSpace(textBoxMb.Text)
                )
            {
                MessageBox.Show("Molimo vas popunite sva obavezna polja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            novaFirma = new FirmaObjekat
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

            tabControlDodajFirmuObjekat.SelectedIndex = 1;

        }

        private void buttonPonisti_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Da li ste sigurni da želite da poništite? sve unete informacije æe biti izbrisane.",
                "Poništi",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }


        private void buttonSledeci2_Click(object sender, EventArgs e)
        {

            if (dataGridViewAdresar.Rows.Count == 0)
            {
                DialogResult result = MessageBox.Show("Tabela Adresar je prazna. Da li želzte da preskoèite ovaj korak?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    listaAdresar.Clear();
                    textBoxEmail.Clear();
                    textBoxTelefon.Clear();
                    textBoxKontaktImePrezime.Clear();
                    dataGridViewAdresar.ClearSelection();
                    textBoxTelefon.Clear();
                    textBoxEmail.Clear();

                    tabControlDodajFirmuObjekat.SelectedIndex = 2;
                }
            }
            listaAdresar.Clear();

            foreach (DataGridViewRow row in dataGridViewAdresar.Rows)
            {

                string imePrezime = row.Cells[1].Value?.ToString() ?? string.Empty;
                string telefonBroj = row.Cells[2].Value?.ToString() ?? string.Empty;
                string emailAdresa = row.Cells[3].Value?.ToString() ?? string.Empty;
                string napomena = row.Cells[4].Value?.ToString() ?? string.Empty;

                if (row.Cells[0].Value != null && int.TryParse(row.Cells[0].Value.ToString(), out int IdAdresar))
                {

                    var noviAdresar = new Adresar
                    {
                        IdAdresar = IdAdresar,
                        ImePrezime = imePrezime,
                        Aktivan = true,
                        Napomena = napomena,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        Emails = emailAdresa
                            .Split(',', StringSplitOptions.RemoveEmptyEntries)
                            .Select(e => new Email
                            {
                                Email1 = e.Trim()
                            })
                            .ToList(), //EF sam dodaje fk na adresar lol
                        Telefons = telefonBroj
                            .Split(',', StringSplitOptions.RemoveEmptyEntries)
                            .Select(t => new Telefon
                            {
                                Telefon1 = t.Trim()
                            })
                            .ToList(),
                        IdFirmaObjekats = new List<FirmaObjekat> { novaFirma }


                    };

                    listaAdresar.Add(noviAdresar);
                }
            }


        }

        private void buttonPreskoci_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Da li ste sigurni da želite da preskoèite? sve unete informacije o Kontaktima firme/objekta æe biti izbrisane.",
                "Preskoèi",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                listaAdresar.Clear();
                textBoxEmail.Clear();
                textBoxTelefon.Clear();
                textBoxKontaktImePrezime.Clear();
                dataGridViewAdresar.ClearSelection();
                textBoxTelefon.Clear();
                textBoxEmail.Clear();

                tabControlDodajFirmuObjekat.SelectedIndex = 2;
            }
        }

        private void buttonDodajEmailUTexBox_Click(object sender, EventArgs e)
        {
            string _email = textBoxEmail.Text.Trim();
            if (!classDizajnFormi.isEmail(_email) && !string.IsNullOrEmpty(_email))
            {
                MessageBox.Show("Unesite validan E-mail!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                listBoxEmail.Items.Add(_email);
                textBoxEmail.Clear();
            }
        }

        private void buttonDodajTelefonUTextbox_Click(object sender, EventArgs e)
        {
            string telefon = textBoxTelefon.Text.Trim();
            if (!classDizajnFormi.isTelefon(telefon) && !string.IsNullOrEmpty(telefon))
            {
                MessageBox.Show("Unesite validan Telefon!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                listBoxTelefon.Items.Add(telefon);
                textBoxTelefon.Clear();
            }
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


            //dataGridViewSistemi.Rows.Add(idSistem, nazivSistema, napomenaSistema);
            textBoxKontaktNapomena.Clear();
            textBoxKontaktImePrezime.Clear();
            listBoxEmail.Items.Clear();
            listBoxTelefon.Items.Clear();
        }

        private async void buttonSacuvaj_Click(object sender, EventArgs e)
        {
            if (dataGridViewAdresar.Rows.Count == 0)
            {
                DialogResult result = MessageBox.Show("Tabela Sisteni je prazna. Da li želzte da preskoèite ovaj korak?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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

                    //string nazivSistema = row.Cells[1].Value?.ToString() ?? string.Empty;
                    string napomena = row.Cells[2].Value?.ToString() ?? string.Empty;

                    if (row.Cells[0].Value != null && int.TryParse(row.Cells[0].Value.ToString(), out int IdSistem))
                    {

                        var noviOsvt = new ObjekatSistemVeznaTabela
                        {
                            IdSistem = IdSistem,
                            Napomena = napomena,
                            IdFirmaObjekatNavigation = novaFirma

                        };

                        listaSistema.Add(noviOsvt);
                    }
                }
            }

            await SacuvajSveUBazuAsync();

        }











        private async Task SacuvajSveUBazuAsync()
        {
            using var db = new AppDbContext(_dbOptions);
            using var transaction = await db.Database.BeginTransactionAsync();

            try
            {
                // Add Root Parent (Step 1)
                db.FirmaObjekats.Add(novaFirma);

                // Add Adresar contacts (Step 2)
                if (listaAdresar.Any())
                {
                    foreach (var adresar in listaAdresar)
                    {
                        if (adresar.IdAdresar > 0)
                        {
                            // Existing contact: attach and connect to novaFirma
                            db.Adresars.Attach(adresar);
                            adresar.IdFirmaObjekats.Add(novaFirma);
                        }
                        else
                        {
                            // Brand new contact: add entire graph
                            db.Adresars.Add(adresar);
                        }
                    }
                }

                // Add Systems (Step 3)
                if (listaSistema.Any())
                {
                    db.ObjekatSistemVeznaTabelas.AddRange(listaSistema);
                }

                // Single SaveChanges handles all primary/foreign key assignments automatically
                await db.SaveChangesAsync();
                await transaction.CommitAsync();

                MessageBox.Show("Podaci uspešno saèuvani!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                MessageBox.Show($"Greška pri èuvanju u bazu: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
