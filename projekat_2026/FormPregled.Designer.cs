namespace projekat_2026
{
    partial class FormPregled
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelPregled = new System.Windows.Forms.TableLayoutPanel();
            this.labelAgent = new System.Windows.Forms.Label();
            this.labelFirmaObjekat = new System.Windows.Forms.Label();
            this.labelSistem = new System.Windows.Forms.Label();
            this.dataGridViewStavkeSistemi = new System.Windows.Forms.DataGridView();
            this.labelNapomena = new System.Windows.Forms.Label();
            this.textBoxNapomenaCitavogPregleda = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPonisti = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonOcisti = new System.Windows.Forms.Button();
            this.buttonSacuvaj = new System.Windows.Forms.Button();
            this.ColumnBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnZadovoljava = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnNapomenaStavke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanelPregled.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStavkeSistemi)).BeginInit();
            this.tableLayoutPanel17.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelPregled
            // 
            this.tableLayoutPanelPregled.ColumnCount = 3;
            this.tableLayoutPanelPregled.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.1433F));
            this.tableLayoutPanelPregled.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.8567F));
            this.tableLayoutPanelPregled.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.tableLayoutPanelPregled.Controls.Add(this.tableLayoutPanel17, 0, 5);
            this.tableLayoutPanelPregled.Controls.Add(this.labelNapomena, 0, 3);
            this.tableLayoutPanelPregled.Controls.Add(this.labelSistem, 0, 1);
            this.tableLayoutPanelPregled.Controls.Add(this.labelFirmaObjekat, 1, 0);
            this.tableLayoutPanelPregled.Controls.Add(this.labelAgent, 0, 0);
            this.tableLayoutPanelPregled.Controls.Add(this.dataGridViewStavkeSistemi, 0, 2);
            this.tableLayoutPanelPregled.Controls.Add(this.textBoxNapomenaCitavogPregleda, 0, 4);
            this.tableLayoutPanelPregled.Controls.Add(this.dateTimePicker1, 2, 0);
            this.tableLayoutPanelPregled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPregled.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelPregled.Name = "tableLayoutPanelPregled";
            this.tableLayoutPanelPregled.RowCount = 6;
            this.tableLayoutPanelPregled.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelPregled.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelPregled.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPregled.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelPregled.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelPregled.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelPregled.Size = new System.Drawing.Size(799, 382);
            this.tableLayoutPanelPregled.TabIndex = 0;
            // 
            // labelAgent
            // 
            this.labelAgent.AutoSize = true;
            this.labelAgent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAgent.Location = new System.Drawing.Point(3, 0);
            this.labelAgent.Name = "labelAgent";
            this.labelAgent.Size = new System.Drawing.Size(222, 30);
            this.labelAgent.TabIndex = 2;
            this.labelAgent.Text = "Agent:";
            this.labelAgent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFirmaObjekat
            // 
            this.labelFirmaObjekat.AutoSize = true;
            this.labelFirmaObjekat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFirmaObjekat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFirmaObjekat.Location = new System.Drawing.Point(231, 0);
            this.labelFirmaObjekat.Name = "labelFirmaObjekat";
            this.labelFirmaObjekat.Size = new System.Drawing.Size(294, 30);
            this.labelFirmaObjekat.TabIndex = 3;
            this.labelFirmaObjekat.Text = "Firma/objekat:";
            this.labelFirmaObjekat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSistem
            // 
            this.labelSistem.AutoSize = true;
            this.labelSistem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanelPregled.SetColumnSpan(this.labelSistem, 3);
            this.labelSistem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSistem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSistem.Location = new System.Drawing.Point(0, 30);
            this.labelSistem.Margin = new System.Windows.Forms.Padding(0);
            this.labelSistem.Name = "labelSistem";
            this.labelSistem.Size = new System.Drawing.Size(799, 30);
            this.labelSistem.TabIndex = 5;
            this.labelSistem.Text = "Sistemi";
            this.labelSistem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewStavkeSistemi
            // 
            this.dataGridViewStavkeSistemi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStavkeSistemi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStavkeSistemi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnBarcode,
            this.ColumnNaziv,
            this.ColumnZadovoljava,
            this.ColumnNapomenaStavke});
            this.tableLayoutPanelPregled.SetColumnSpan(this.dataGridViewStavkeSistemi, 3);
            this.dataGridViewStavkeSistemi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStavkeSistemi.Location = new System.Drawing.Point(3, 63);
            this.dataGridViewStavkeSistemi.Name = "dataGridViewStavkeSistemi";
            this.dataGridViewStavkeSistemi.RowHeadersVisible = false;
            this.dataGridViewStavkeSistemi.Size = new System.Drawing.Size(793, 140);
            this.dataGridViewStavkeSistemi.TabIndex = 6;
            // 
            // labelNapomena
            // 
            this.labelNapomena.AutoSize = true;
            this.labelNapomena.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanelPregled.SetColumnSpan(this.labelNapomena, 3);
            this.labelNapomena.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNapomena.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNapomena.Location = new System.Drawing.Point(0, 206);
            this.labelNapomena.Margin = new System.Windows.Forms.Padding(0);
            this.labelNapomena.Name = "labelNapomena";
            this.labelNapomena.Size = new System.Drawing.Size(799, 30);
            this.labelNapomena.TabIndex = 7;
            this.labelNapomena.Text = "Napomena pregleda";
            this.labelNapomena.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxNapomenaCitavogPregleda
            // 
            this.tableLayoutPanelPregled.SetColumnSpan(this.textBoxNapomenaCitavogPregleda, 3);
            this.textBoxNapomenaCitavogPregleda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNapomenaCitavogPregleda.Location = new System.Drawing.Point(3, 239);
            this.textBoxNapomenaCitavogPregleda.Multiline = true;
            this.textBoxNapomenaCitavogPregleda.Name = "textBoxNapomenaCitavogPregleda";
            this.textBoxNapomenaCitavogPregleda.Size = new System.Drawing.Size(793, 81);
            this.textBoxNapomenaCitavogPregleda.TabIndex = 8;
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel17.ColumnCount = 4;
            this.tableLayoutPanelPregled.SetColumnSpan(this.tableLayoutPanel17, 3);
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel17.Controls.Add(this.buttonOcisti, 0, 0);
            this.tableLayoutPanel17.Controls.Add(this.buttonSacuvaj, 3, 0);
            this.tableLayoutPanel17.Controls.Add(this.buttonPonisti, 2, 0);
            this.tableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel17.Location = new System.Drawing.Point(3, 326);
            this.tableLayoutPanel17.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 1;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(793, 41);
            this.tableLayoutPanel17.TabIndex = 9;
            // 
            // buttonPonisti
            // 
            this.buttonPonisti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPonisti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPonisti.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPonisti.Location = new System.Drawing.Point(579, 3);
            this.buttonPonisti.Name = "buttonPonisti";
            this.buttonPonisti.Size = new System.Drawing.Size(101, 35);
            this.buttonPonisti.TabIndex = 5;
            this.buttonPonisti.Text = "Poništi";
            this.buttonPonisti.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Location = new System.Drawing.Point(531, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 24);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // buttonOcisti
            // 
            this.buttonOcisti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOcisti.Image = global::projekat_2026.Properties.Resources.icons8_refresh_24;
            this.buttonOcisti.Location = new System.Drawing.Point(3, 3);
            this.buttonOcisti.Name = "buttonOcisti";
            this.buttonOcisti.Size = new System.Drawing.Size(47, 35);
            this.buttonOcisti.TabIndex = 8;
            this.buttonOcisti.UseVisualStyleBackColor = true;
            // 
            // buttonSacuvaj
            // 
            this.buttonSacuvaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSacuvaj.Image = global::projekat_2026.Properties.Resources.icons8_save_24;
            this.buttonSacuvaj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSacuvaj.Location = new System.Drawing.Point(686, 3);
            this.buttonSacuvaj.Name = "buttonSacuvaj";
            this.buttonSacuvaj.Size = new System.Drawing.Size(104, 35);
            this.buttonSacuvaj.TabIndex = 7;
            this.buttonSacuvaj.Text = "Sačuvaj";
            this.buttonSacuvaj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSacuvaj.UseVisualStyleBackColor = true;
            // 
            // ColumnBarcode
            // 
            this.ColumnBarcode.HeaderText = "Barcode";
            this.ColumnBarcode.Name = "ColumnBarcode";
            this.ColumnBarcode.ReadOnly = true;
            // 
            // ColumnNaziv
            // 
            this.ColumnNaziv.HeaderText = "Naziv";
            this.ColumnNaziv.Name = "ColumnNaziv";
            this.ColumnNaziv.ReadOnly = true;
            // 
            // ColumnZadovoljava
            // 
            this.ColumnZadovoljava.HeaderText = "Zadovoljava";
            this.ColumnZadovoljava.Name = "ColumnZadovoljava";
            // 
            // ColumnNapomenaStavke
            // 
            this.ColumnNapomenaStavke.HeaderText = "Napomena stavke";
            this.ColumnNapomenaStavke.Name = "ColumnNapomenaStavke";
            // 
            // FormPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 382);
            this.Controls.Add(this.tableLayoutPanelPregled);
            this.Name = "FormPregled";
            this.Text = "FormPregled";
            this.tableLayoutPanelPregled.ResumeLayout(false);
            this.tableLayoutPanelPregled.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStavkeSistemi)).EndInit();
            this.tableLayoutPanel17.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPregled;
        private System.Windows.Forms.Label labelSistem;
        private System.Windows.Forms.Label labelFirmaObjekat;
        private System.Windows.Forms.Label labelAgent;
        private System.Windows.Forms.DataGridView dataGridViewStavkeSistemi;
        private System.Windows.Forms.Label labelNapomena;
        private System.Windows.Forms.TextBox textBoxNapomenaCitavogPregleda;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
        private System.Windows.Forms.Button buttonOcisti;
        private System.Windows.Forms.Button buttonSacuvaj;
        private System.Windows.Forms.Button buttonPonisti;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNaziv;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnZadovoljava;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNapomenaStavke;
    }
}