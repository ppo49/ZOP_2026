using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using projekat_2026.Core;
using projekat_2026.Data;
using projekat_2026.Data.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace projekat_2026
{
    public partial class FormMain : Form
    {
        private readonly DbContextOptions<AppDbContext> _dbOptions;
        private readonly Agent _loggedInAgent;
        private readonly FirmaObjekat _fairmaObjekat;

        private ClassDizajnFormi classDizajnFormi = new ClassDizajnFormi();


        private int? _selectedFirmaObjekatId;
        private int? _selectedStavkaId;
        private int? _selectedKontaktId;

        private readonly FirmaObjekatService firmaObjekatService;
        private readonly SistemService sistemService;
        private readonly ObjekatSistemService objekatSistemService;
        private readonly AdresarService adresarService;
        private readonly PregledService pregledService;

        public FormMain(DbContextOptions<AppDbContext> dbOptions, Agent loggedInAgent)
        {
            InitializeComponent();
            _dbOptions = dbOptions;
            _loggedInAgent = loggedInAgent;

            firmaObjekatService = new FirmaObjekatService(dbOptions);
            sistemService = new SistemService(dbOptions);
            objekatSistemService = new ObjekatSistemService(dbOptions);
            adresarService = new AdresarService(dbOptions);
            pregledService = new PregledService(dbOptions);

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
            setupComboBoxSistem();
            setupCoboBoxAdresarStatus();


            //listBoxEmails.DisplayMember = "Email1";
            //listBoxTelefoni.DisplayMember = "Telefon1";

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

        private void setupComboBoxSistem()
        {
            comboBoxSistemi.DataSource = sistemService.GetNameAndId();
            comboBoxSistemi.DisplayMember = "Naziv";
            comboBoxSistemi.ValueMember = "IdSistem";
            comboBoxSistemi.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void setupCoboBoxAdresarStatus()
        {
            comboBoxAdresarStatus.Items.Add("Aktivan");
            comboBoxAdresarStatus.Items.Add("Neaktivan");
            comboBoxSistemi.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void SetupDatagridViewPregled(int idFirmaObjekat)
        {
            var pregledLog = pregledService.GetByFirmaObjekatId(idFirmaObjekat)
                .Select(p => new
                {
                    p.IdFirmaObjekat,
                    p.IdPregledLog,
                    p.DatumPregleda,
                    p.Napomena,
                    p.IdAgent,
                    AgentImePrezime = p.IdAgentNavigation.ImePrezime,
                    CreatedAt = p.CreatedAt.ToShortDateString(),
                    UpdatedAt = p.UpdatedAt.ToShortDateString(),
                }).ToList();

            dataGridViewPreglediObjekta.DataSource = pregledLog;
            dataGridViewPreglediObjekta.RowHeadersVisible = false;
            dataGridViewPreglediObjekta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPreglediObjekta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewPreglediObjekta.Columns["IdFirmaObjekat"].Visible = false;
            dataGridViewPreglediObjekta.Columns["IdPregledLog"].Visible = false;
            dataGridViewPreglediObjekta.Columns["IdAgent"].Visible = false;

            dataGridViewPreglediObjekta.Columns["DatumPregleda"].FillWeight = 20;
            dataGridViewPreglediObjekta.Columns["Napomena"].FillWeight = 30;
            dataGridViewPreglediObjekta.Columns["AgentImePrezime"].FillWeight = 20;
            dataGridViewPreglediObjekta.Columns["CreatedAt"].FillWeight = 15;
            dataGridViewPreglediObjekta.Columns["UpdatedAt"].FillWeight = 15;

        }

        private void SetupdataGridViewAdresar(int idFirmaObjekat)
        {
            var adresar = adresarService.GetAdresarFullForFirmaObjekat(idFirmaObjekat)
                .Select(a => new
                {
                    a.IdAdresar,
                    //a.IdFirmaObjekats,
                    ImePrezime = a.ImePrezime,
                    Emails = string.Join(", ", a.Emails.Select(e => e.Email1)),
                    Telefoni = string.Join(", ", a.Telefons.Select(e => e.Telefon1)),
                    a.Napomena,
                    Status = a.Aktivan,
                    a.CreatedAt,
                    a.UpdatedAt
                })
                .ToList();

            dataGridViewAdresar.DataSource = adresar;
            dataGridViewAdresar.RowHeadersVisible = false;
            dataGridViewAdresar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAdresar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



            dataGridViewAdresar.Columns["IdAdresar"].Visible = false;
            dataGridViewAdresar.Columns["CreatedAt"].Visible = false;
            dataGridViewAdresar.Columns["UpdatedAt"].Visible = false;

            dataGridViewAdresar.Columns["ImePrezime"].FillWeight = 25;
            dataGridViewAdresar.Columns["Emails"].FillWeight = 25;
            dataGridViewAdresar.Columns["Telefoni"].FillWeight = 25;
            dataGridViewAdresar.Columns["Napomena"].FillWeight = 15;
            dataGridViewAdresar.Columns["Status"].FillWeight = 10;

        }

        private void SetupdataGridViewSistemi(int idFirmaObjekat)
        {
            var stavke = objekatSistemService.GetByFirmaObjekat(idFirmaObjekat)
                .Select(o => new
                {
                    o.IdObjekatSistemVeznaTabela,
                    Nazivsistema = o.IdSistemNavigation.Naziv,
                    Periodika = o.IdSistemNavigation.Periodika,
                    o.Napomena,
                    o.IdSistem
                    // IdFirmaObjekat = o.IdFirmaObjekatNavigation.IdFirmaObjekat
                })
                .ToList();

            dataGridViewSistemi.DataSource = stavke;
            dataGridViewSistemi.RowHeadersVisible = false;
            dataGridViewSistemi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSistemi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewSistemi.Columns["IdObjekatSistemVeznaTabela"].Visible = false;
            dataGridViewSistemi.Columns["IdSistem"].Visible = false;
            //dataGridViewSistemi.Columns["IdFirmaObjekat"].Visible = false;

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
            try
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
                SetupdataGridViewAdresar(_selectedFirmaObjekatId.Value);
                SetupDatagridViewPregled(_selectedFirmaObjekatId.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

                SetupdataGridViewSistemi(_selectedFirmaObjekatId.Value);
                SetupdataGridViewAdresar(_selectedFirmaObjekatId.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridViewSistemi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridViewSistemi.Rows[e.RowIndex];

            _selectedStavkaId = (int)row.Cells["IdObjekatSistemVeznaTabela"].Value;

            var stavka = objekatSistemService.GetById(_selectedStavkaId.Value);

            if (stavka == null) return;

            textBoxNapomenaAzuriraj.Text = stavka.Napomena;
            textBoxSistemNaziv.Text = stavka.IdSistemNavigation.Naziv;

        }

        private void buttonAzurirajStavku_Click(object sender, EventArgs e)
        {
            if (_selectedStavkaId == null)
            {
                MessageBox.Show("Molimo izaberite sistem.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var stavka = objekatSistemService.GetById(_selectedStavkaId.Value);
            if (stavka == null) return;

            stavka.Napomena = textBoxNapomenaAzuriraj.Text.Trim();
            objekatSistemService.Update(stavka);

            MessageBox.Show("Napomena ažurirana!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SetupdataGridViewSistemi(_selectedFirmaObjekatId.Value);
        }

        private void buttonDodajStavku_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedFirmaObjekatId == null)
                {
                    MessageBox.Show("Molimo izaberite firmu/objekat.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (comboBoxSistemi.SelectedValue == null)
                {
                    MessageBox.Show("Molimo izaberite sistem.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var novaStavka = new ObjekatSistemVeznaTabela
                {
                    Napomena = textBoxSistemNapomena.Text.Trim(),
                    IdSistem = (int)comboBoxSistemi.SelectedValue,
                    IdFirmaObjekat = _selectedFirmaObjekatId.Value,
                };

                objekatSistemService.Add(novaStavka);

                MessageBox.Show("Sistem dodat!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxSistemNapomena.Clear();
                SetupdataGridViewSistemi(_selectedFirmaObjekatId.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void dataGridViewAdresar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridViewAdresar.Rows[e.RowIndex];
            _selectedKontaktId = (int)row.Cells["IdAdresar"].Value;
            var kontakt = adresarService.GetById(_selectedKontaktId.Value);

            if (kontakt == null) return;

            textBoxKontaktImePrezime.Text = kontakt.ImePrezime;
            textBoxKontaktNapomena.Text = kontakt.Napomena;
            comboBoxAdresarStatus.SelectedValue = kontakt.Aktivan;


            listBoxEmails.Items.Clear();
            listBoxEmails.Items.AddRange(kontakt.Emails.Select(e => e.Email1).ToArray());

            listBoxTelefoni.Items.Clear();
            listBoxTelefoni.Items.AddRange(kontakt.Telefons.Select(t => t.Telefon1).ToArray());

        }

        private void buttonAzurirajKontakt_Click(object sender, EventArgs e)
        {

            try
            {
                if (_selectedKontaktId == null)
                {
                    MessageBox.Show("Molimo izaberite kontakt.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (string.IsNullOrEmpty(textBoxKontaktImePrezime.Text))
                {
                    MessageBox.Show("Molimo popunite polje ime i prezime.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var kontakt = new Adresar
                {
                    IdAdresar = _selectedKontaktId.Value,
                    ImePrezime = textBoxKontaktImePrezime.Text,
                    Napomena = textBoxKontaktNapomena.Text,
                    Aktivan = comboBoxAdresarStatus.SelectedItem?.ToString() == "Aktivan"
                };

                var emailList = listBoxEmails.Items.Cast<object>().Select(i => i.ToString()).ToList();
                var telefonList = listBoxTelefoni.Items.Cast<object>().Select(i => i.ToString()).ToList();

                adresarService.Update(kontakt, emailList, telefonList);
                MessageBox.Show("Kontakt azuriran!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetupdataGridViewAdresar(_selectedFirmaObjekatId.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void buttonDodajEmailUTexBox_Click(object sender, EventArgs e)
        {
            string email = textBoxAdresarEmail.Text.Trim();
            if (string.IsNullOrEmpty(email)) return;

            if (!classDizajnFormi.isEmail(email))
            {
                MessageBox.Show("Unesite validan E-mail!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listBoxEmails.Items.Add(email);
            textBoxAdresarEmail.Clear();
        }

        private void buttonAdresarDodajTelefon_Click(object sender, EventArgs e)
        {
            string telefon = textBoxAdresarTelefon.Text.Trim();
            if (string.IsNullOrEmpty(telefon)) return;

            if (!classDizajnFormi.isTelefon(telefon))
            {
                MessageBox.Show("Unesite validan broj telefona", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listBoxTelefoni.Items.Add(telefon);
            textBoxAdresarTelefon.Clear();
        }

        private void buttonFirmaObjekatObrisi_Click(object sender, EventArgs e)
        {

        }

        private void buttonDodajKontakt_Click(object sender, EventArgs e)
        {
            if (_selectedFirmaObjekatId == null) return;

            var firma = firmaObjekatService.GetById(_selectedFirmaObjekatId.Value);
            if (firma == null) return;

            using (var formDetalji = new FormKontaktDetalji(_dbOptions, firma))
            {
                if (formDetalji.ShowDialog() == DialogResult.OK)
                {
                    // Refresh main DataGridView upon success
                    SetupdataGridViewAdresar(_selectedFirmaObjekatId.Value);
                }
            }
        }

        private void toolStripButtonNoviPregled_Click(object sender, EventArgs e)
        {
            if (dataGridViewFirmaObjekat.CurrentRow == null)
            {
                MessageBox.Show("Izaberite Firma/Objekat za koji se generiše pregled.", "Greska",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //int idFirmaObjekat = (int)dataGridViewFirmaObjekat.CurrentRow.Cells["IdFirmaObjekat"].Value;
            var firma = firmaObjekatService.GetById(_selectedFirmaObjekatId.Value);
            if (firma == null) return;

            var formPregled = new FormPregled(_dbOptions, _loggedInAgent, firma);
            //formPregled.Show();


            if (formPregled.ShowDialog() == DialogResult.OK)
            {
                SetupDatagridViewPregled(_selectedFirmaObjekatId.Value); 
            }
        }

        private void dataGridViewPreglediObjekta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridViewPreglediObjekta.Rows[e.RowIndex];
            int idPregledLog = (int)row.Cells["IdPregledLog"].Value;

            using var formPregledLIsta = new FormPregledLista(_dbOptions, idPregledLog);
            formPregledLIsta.ShowDialog();
            SetupDatagridViewPregled(_selectedFirmaObjekatId.Value);
        }
    }
}
