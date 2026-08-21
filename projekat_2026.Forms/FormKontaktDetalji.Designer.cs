namespace projekat_2026
{
    partial class FormKontaktDetalji
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
            components = new System.ComponentModel.Container();
            tableLayoutPanelCenterContent = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            comboBoxAdresarStatus = new System.Windows.Forms.ComboBox();
            listBoxTelefon = new System.Windows.Forms.ListBox();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            labelNapomena = new System.Windows.Forms.Label();
            textBoxNapomena = new System.Windows.Forms.TextBox();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            labelImePrezime = new System.Windows.Forms.Label();
            textBoxImePrezime = new System.Windows.Forms.TextBox();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            labelEmail = new System.Windows.Forms.Label();
            textBoxEmail = new System.Windows.Forms.TextBox();
            buttonEmailDodaj = new System.Windows.Forms.Button();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            labelTelefon = new System.Windows.Forms.Label();
            textBoxTelefon = new System.Windows.Forms.TextBox();
            buttontelefonDodaj = new System.Windows.Forms.Button();
            listBoxEmail = new System.Windows.Forms.ListBox();
            tableLayoutPanelKontrole = new System.Windows.Forms.TableLayoutPanel();
            buttonSacuvaj = new System.Windows.Forms.Button();
            buttonPonisti = new System.Windows.Forms.Button();
            contextMenuStripObrisiEmail = new System.Windows.Forms.ContextMenuStrip(components);
            obrisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            contextMenuStripObrisiTelefon = new System.Windows.Forms.ContextMenuStrip(components);
            obrisiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            tableLayoutPanelCenterContent.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanelKontrole.SuspendLayout();
            contextMenuStripObrisiEmail.SuspendLayout();
            contextMenuStripObrisiTelefon.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelCenterContent
            // 
            tableLayoutPanelCenterContent.ColumnCount = 2;
            tableLayoutPanelCenterContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanelCenterContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanelCenterContent.Controls.Add(tableLayoutPanel5, 0, 3);
            tableLayoutPanelCenterContent.Controls.Add(listBoxTelefon, 1, 2);
            tableLayoutPanelCenterContent.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanelCenterContent.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanelCenterContent.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanelCenterContent.Controls.Add(tableLayoutPanel3, 1, 1);
            tableLayoutPanelCenterContent.Controls.Add(listBoxEmail, 0, 2);
            tableLayoutPanelCenterContent.Controls.Add(tableLayoutPanelKontrole, 1, 3);
            tableLayoutPanelCenterContent.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanelCenterContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            tableLayoutPanelCenterContent.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanelCenterContent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanelCenterContent.Name = "tableLayoutPanelCenterContent";
            tableLayoutPanelCenterContent.RowCount = 4;
            tableLayoutPanelCenterContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            tableLayoutPanelCenterContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            tableLayoutPanelCenterContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            tableLayoutPanelCenterContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            tableLayoutPanelCenterContent.Size = new System.Drawing.Size(592, 317);
            tableLayoutPanelCenterContent.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            tableLayoutPanel5.Controls.Add(comboBoxAdresarStatus, 0, 0);
            tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel5.Location = new System.Drawing.Point(4, 272);
            tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 12, 4, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new System.Drawing.Size(288, 42);
            tableLayoutPanel5.TabIndex = 9;
            // 
            // comboBoxAdresarStatus
            // 
            comboBoxAdresarStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            comboBoxAdresarStatus.FormattingEnabled = true;
            comboBoxAdresarStatus.Items.AddRange(new object[] { "Aktivan", "Neaktivan" });
            comboBoxAdresarStatus.Location = new System.Drawing.Point(3, 3);
            comboBoxAdresarStatus.Name = "comboBoxAdresarStatus";
            comboBoxAdresarStatus.Size = new System.Drawing.Size(124, 26);
            comboBoxAdresarStatus.TabIndex = 0;
            // 
            // listBoxTelefon
            // 
            listBoxTelefon.Dock = System.Windows.Forms.DockStyle.Fill;
            listBoxTelefon.FormattingEnabled = true;
            listBoxTelefon.ItemHeight = 18;
            listBoxTelefon.Location = new System.Drawing.Point(300, 163);
            listBoxTelefon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            listBoxTelefon.Name = "listBoxTelefon";
            listBoxTelefon.Size = new System.Drawing.Size(288, 94);
            listBoxTelefon.TabIndex = 7;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(labelNapomena, 0, 0);
            tableLayoutPanel4.Controls.Add(textBoxNapomena, 0, 1);
            tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel4.Location = new System.Drawing.Point(300, 3);
            tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.74468F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.25532F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel4.Size = new System.Drawing.Size(288, 74);
            tableLayoutPanel4.TabIndex = 5;
            // 
            // labelNapomena
            // 
            labelNapomena.AutoSize = true;
            labelNapomena.Dock = System.Windows.Forms.DockStyle.Fill;
            labelNapomena.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            labelNapomena.Location = new System.Drawing.Point(4, 0);
            labelNapomena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelNapomena.Name = "labelNapomena";
            labelNapomena.Size = new System.Drawing.Size(280, 33);
            labelNapomena.TabIndex = 1;
            labelNapomena.Text = "Napomena";
            labelNapomena.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textBoxNapomena
            // 
            textBoxNapomena.Dock = System.Windows.Forms.DockStyle.Fill;
            textBoxNapomena.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            textBoxNapomena.Location = new System.Drawing.Point(4, 36);
            textBoxNapomena.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxNapomena.Multiline = true;
            textBoxNapomena.Name = "textBoxNapomena";
            textBoxNapomena.Size = new System.Drawing.Size(280, 35);
            textBoxNapomena.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(labelImePrezime, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxImePrezime, 0, 1);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(4, 3);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.74468F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.25532F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel1.Size = new System.Drawing.Size(288, 74);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // labelImePrezime
            // 
            labelImePrezime.AutoSize = true;
            labelImePrezime.Dock = System.Windows.Forms.DockStyle.Fill;
            labelImePrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            labelImePrezime.Location = new System.Drawing.Point(4, 0);
            labelImePrezime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelImePrezime.Name = "labelImePrezime";
            labelImePrezime.Size = new System.Drawing.Size(280, 33);
            labelImePrezime.TabIndex = 1;
            labelImePrezime.Text = "Ime i prezime";
            labelImePrezime.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textBoxImePrezime
            // 
            textBoxImePrezime.Dock = System.Windows.Forms.DockStyle.Fill;
            textBoxImePrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            textBoxImePrezime.Location = new System.Drawing.Point(4, 36);
            textBoxImePrezime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxImePrezime.Name = "textBoxImePrezime";
            textBoxImePrezime.Size = new System.Drawing.Size(280, 24);
            textBoxImePrezime.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            tableLayoutPanel2.Controls.Add(labelEmail, 0, 0);
            tableLayoutPanel2.Controls.Add(textBoxEmail, 0, 1);
            tableLayoutPanel2.Controls.Add(buttonEmailDodaj, 1, 1);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(4, 83);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.74468F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.25532F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel2.Size = new System.Drawing.Size(288, 74);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            labelEmail.Location = new System.Drawing.Point(4, 0);
            labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new System.Drawing.Size(216, 33);
            labelEmail.TabIndex = 1;
            labelEmail.Text = "Dodaj E-Mail";
            labelEmail.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            textBoxEmail.Location = new System.Drawing.Point(4, 36);
            textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new System.Drawing.Size(216, 24);
            textBoxEmail.TabIndex = 1;
            // 
            // buttonEmailDodaj
            // 
            buttonEmailDodaj.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonEmailDodaj.Image = Properties.Resources.icons8_add_new_24;
            buttonEmailDodaj.Location = new System.Drawing.Point(228, 36);
            buttonEmailDodaj.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonEmailDodaj.Name = "buttonEmailDodaj";
            buttonEmailDodaj.Size = new System.Drawing.Size(56, 35);
            buttonEmailDodaj.TabIndex = 3;
            buttonEmailDodaj.UseVisualStyleBackColor = true;
            buttonEmailDodaj.Click += buttonDodajEmailUTexBox_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            tableLayoutPanel3.Controls.Add(labelTelefon, 0, 0);
            tableLayoutPanel3.Controls.Add(textBoxTelefon, 0, 1);
            tableLayoutPanel3.Controls.Add(buttontelefonDodaj, 1, 1);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(300, 83);
            tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.74468F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.25532F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel3.Size = new System.Drawing.Size(288, 74);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // labelTelefon
            // 
            labelTelefon.AutoSize = true;
            labelTelefon.Dock = System.Windows.Forms.DockStyle.Fill;
            labelTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            labelTelefon.Location = new System.Drawing.Point(4, 0);
            labelTelefon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelTelefon.Name = "labelTelefon";
            labelTelefon.Size = new System.Drawing.Size(216, 33);
            labelTelefon.TabIndex = 1;
            labelTelefon.Text = "Dodaj telefon";
            labelTelefon.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textBoxTelefon
            // 
            textBoxTelefon.Dock = System.Windows.Forms.DockStyle.Fill;
            textBoxTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            textBoxTelefon.Location = new System.Drawing.Point(4, 36);
            textBoxTelefon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxTelefon.Name = "textBoxTelefon";
            textBoxTelefon.Size = new System.Drawing.Size(216, 24);
            textBoxTelefon.TabIndex = 1;
            // 
            // buttontelefonDodaj
            // 
            buttontelefonDodaj.Dock = System.Windows.Forms.DockStyle.Fill;
            buttontelefonDodaj.Image = Properties.Resources.icons8_add_new_24;
            buttontelefonDodaj.Location = new System.Drawing.Point(228, 36);
            buttontelefonDodaj.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttontelefonDodaj.Name = "buttontelefonDodaj";
            buttontelefonDodaj.Size = new System.Drawing.Size(56, 35);
            buttontelefonDodaj.TabIndex = 3;
            buttontelefonDodaj.UseVisualStyleBackColor = true;
            buttontelefonDodaj.Click += buttonAdresarDodajTelefon_Click;
            // 
            // listBoxEmail
            // 
            listBoxEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            listBoxEmail.FormattingEnabled = true;
            listBoxEmail.ItemHeight = 18;
            listBoxEmail.Location = new System.Drawing.Point(4, 163);
            listBoxEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            listBoxEmail.Name = "listBoxEmail";
            listBoxEmail.Size = new System.Drawing.Size(288, 94);
            listBoxEmail.TabIndex = 6;
            // 
            // tableLayoutPanelKontrole
            // 
            tableLayoutPanelKontrole.ColumnCount = 3;
            tableLayoutPanelKontrole.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.9444447F));
            tableLayoutPanelKontrole.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.208334F));
            tableLayoutPanelKontrole.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.84722F));
            tableLayoutPanelKontrole.Controls.Add(buttonSacuvaj, 2, 0);
            tableLayoutPanelKontrole.Controls.Add(buttonPonisti, 1, 0);
            tableLayoutPanelKontrole.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanelKontrole.Location = new System.Drawing.Point(300, 272);
            tableLayoutPanelKontrole.Margin = new System.Windows.Forms.Padding(4, 12, 4, 3);
            tableLayoutPanelKontrole.Name = "tableLayoutPanelKontrole";
            tableLayoutPanelKontrole.RowCount = 1;
            tableLayoutPanelKontrole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanelKontrole.Size = new System.Drawing.Size(288, 42);
            tableLayoutPanelKontrole.TabIndex = 8;
            // 
            // buttonSacuvaj
            // 
            buttonSacuvaj.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonSacuvaj.Image = Properties.Resources.icons8_save_24;
            buttonSacuvaj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            buttonSacuvaj.Location = new System.Drawing.Point(183, 3);
            buttonSacuvaj.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonSacuvaj.Name = "buttonSacuvaj";
            buttonSacuvaj.Size = new System.Drawing.Size(101, 36);
            buttonSacuvaj.TabIndex = 0;
            buttonSacuvaj.Text = "Saèuvaj";
            buttonSacuvaj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSacuvaj.UseVisualStyleBackColor = true;
            buttonSacuvaj.Click += buttonSacuvaj_Click;
            // 
            // buttonPonisti
            // 
            buttonPonisti.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonPonisti.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            buttonPonisti.Location = new System.Drawing.Point(96, 3);
            buttonPonisti.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonPonisti.Name = "buttonPonisti";
            buttonPonisti.Size = new System.Drawing.Size(79, 36);
            buttonPonisti.TabIndex = 1;
            buttonPonisti.Text = "Poništi";
            buttonPonisti.UseVisualStyleBackColor = true;
            // 
            // contextMenuStripObrisiEmail
            // 
            contextMenuStripObrisiEmail.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { obrisiToolStripMenuItem });
            contextMenuStripObrisiEmail.Name = "contextMenuStripObrisiEmail";
            contextMenuStripObrisiEmail.Size = new System.Drawing.Size(106, 26);
            // 
            // obrisiToolStripMenuItem
            // 
            obrisiToolStripMenuItem.Name = "obrisiToolStripMenuItem";
            obrisiToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            obrisiToolStripMenuItem.Text = "Obrisi";
            // 
            // contextMenuStripObrisiTelefon
            // 
            contextMenuStripObrisiTelefon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { obrisiToolStripMenuItem1 });
            contextMenuStripObrisiTelefon.Name = "contextMenuStripObrisiTelefon";
            contextMenuStripObrisiTelefon.Size = new System.Drawing.Size(106, 26);
            // 
            // obrisiToolStripMenuItem1
            // 
            obrisiToolStripMenuItem1.Name = "obrisiToolStripMenuItem1";
            obrisiToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            obrisiToolStripMenuItem1.Text = "Obrisi";
            // 
            // FormKontaktDetalji
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(592, 317);
            Controls.Add(tableLayoutPanelCenterContent);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormKontaktDetalji";
            Text = "Kontakt";
            tableLayoutPanelCenterContent.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanelKontrole.ResumeLayout(false);
            contextMenuStripObrisiEmail.ResumeLayout(false);
            contextMenuStripObrisiTelefon.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCenterContent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelImePrezime;
        private System.Windows.Forms.TextBox textBoxImePrezime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonEmailDodaj;
        private System.Windows.Forms.ListBox listBoxTelefon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label labelNapomena;
        private System.Windows.Forms.TextBox textBoxNapomena;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.Button buttontelefonDodaj;
        private System.Windows.Forms.ListBox listBoxEmail;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripObrisiEmail;
        private System.Windows.Forms.ToolStripMenuItem obrisiToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripObrisiTelefon;
        private System.Windows.Forms.ToolStripMenuItem obrisiToolStripMenuItem1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelKontrole;
        private System.Windows.Forms.Button buttonSacuvaj;
        private System.Windows.Forms.Button buttonPonisti;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ComboBox comboBoxAdresarStatus;
    }
}
