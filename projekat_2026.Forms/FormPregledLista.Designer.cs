namespace projekat_2026
{
    partial class FormPregledLista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            contextMenuStripPregledTabela = new System.Windows.Forms.ContextMenuStrip(components);
            detaljiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            izbrišiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tableLayoutPanelPregled = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            buttonSacuvaj = new System.Windows.Forms.Button();
            buttonObrisi = new System.Windows.Forms.Button();
            labelNapomena = new System.Windows.Forms.Label();
            labelSistem = new System.Windows.Forms.Label();
            labelFirmaObjekat = new System.Windows.Forms.Label();
            labelAgent = new System.Windows.Forms.Label();
            textBoxNapomenaCitavogPregleda = new System.Windows.Forms.TextBox();
            dateTimePickerDatumPregleda = new System.Windows.Forms.DateTimePicker();
            dataGridViewStavke = new System.Windows.Forms.DataGridView();
            contextMenuStripPregledTabela.SuspendLayout();
            tableLayoutPanelPregled.SuspendLayout();
            tableLayoutPanel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStavke).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStripPregledTabela
            // 
            contextMenuStripPregledTabela.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { detaljiToolStripMenuItem, izbrišiToolStripMenuItem });
            contextMenuStripPregledTabela.Name = "contextMenuStripPregledTabela";
            contextMenuStripPregledTabela.Size = new System.Drawing.Size(108, 48);
            // 
            // detaljiToolStripMenuItem
            // 
            detaljiToolStripMenuItem.Name = "detaljiToolStripMenuItem";
            detaljiToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            detaljiToolStripMenuItem.Text = "Detalji";
            // 
            // izbrišiToolStripMenuItem
            // 
            izbrišiToolStripMenuItem.Name = "izbrišiToolStripMenuItem";
            izbrišiToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            izbrišiToolStripMenuItem.Text = "Izbriši";
            // 
            // tableLayoutPanelPregled
            // 
            tableLayoutPanelPregled.ColumnCount = 3;
            tableLayoutPanelPregled.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.1433F));
            tableLayoutPanelPregled.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.8567F));
            tableLayoutPanelPregled.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 316F));
            tableLayoutPanelPregled.Controls.Add(tableLayoutPanel17, 0, 5);
            tableLayoutPanelPregled.Controls.Add(labelNapomena, 0, 3);
            tableLayoutPanelPregled.Controls.Add(labelSistem, 0, 1);
            tableLayoutPanelPregled.Controls.Add(labelFirmaObjekat, 1, 0);
            tableLayoutPanelPregled.Controls.Add(labelAgent, 0, 0);
            tableLayoutPanelPregled.Controls.Add(textBoxNapomenaCitavogPregleda, 0, 4);
            tableLayoutPanelPregled.Controls.Add(dateTimePickerDatumPregleda, 2, 0);
            tableLayoutPanelPregled.Controls.Add(dataGridViewStavke, 0, 2);
            tableLayoutPanelPregled.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanelPregled.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanelPregled.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanelPregled.Name = "tableLayoutPanelPregled";
            tableLayoutPanelPregled.RowCount = 6;
            tableLayoutPanelPregled.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanelPregled.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanelPregled.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            tableLayoutPanelPregled.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanelPregled.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            tableLayoutPanelPregled.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            tableLayoutPanelPregled.Size = new System.Drawing.Size(881, 421);
            tableLayoutPanelPregled.TabIndex = 1;
            // 
            // tableLayoutPanel17
            // 
            tableLayoutPanel17.BackColor = System.Drawing.SystemColors.ControlLight;
            tableLayoutPanel17.ColumnCount = 3;
            tableLayoutPanelPregled.SetColumnSpan(tableLayoutPanel17, 3);
            tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel17.Controls.Add(buttonSacuvaj, 2, 0);
            tableLayoutPanel17.Controls.Add(buttonObrisi, 1, 0);
            tableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel17.Location = new System.Drawing.Point(4, 364);
            tableLayoutPanel17.Margin = new System.Windows.Forms.Padding(4, 3, 4, 17);
            tableLayoutPanel17.Name = "tableLayoutPanel17";
            tableLayoutPanel17.RowCount = 1;
            tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel17.Size = new System.Drawing.Size(873, 40);
            tableLayoutPanel17.TabIndex = 9;
            // 
            // buttonSacuvaj
            // 
            buttonSacuvaj.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            buttonSacuvaj.Image = Properties.Resources.icons8_save_24;
            buttonSacuvaj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            buttonSacuvaj.Location = new System.Drawing.Point(749, 3);
            buttonSacuvaj.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonSacuvaj.Name = "buttonSacuvaj";
            buttonSacuvaj.Size = new System.Drawing.Size(120, 34);
            buttonSacuvaj.TabIndex = 7;
            buttonSacuvaj.Text = "Saèuvaj";
            buttonSacuvaj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSacuvaj.UseVisualStyleBackColor = true;
            buttonSacuvaj.Click += buttonSacuvaj_Click;
            // 
            // buttonObrisi
            // 
            buttonObrisi.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            buttonObrisi.Image = Properties.Resources.icons8_delete2_24;
            buttonObrisi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            buttonObrisi.Location = new System.Drawing.Point(594, 3);
            buttonObrisi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonObrisi.Name = "buttonObrisi";
            buttonObrisi.Size = new System.Drawing.Size(147, 34);
            buttonObrisi.TabIndex = 5;
            buttonObrisi.Text = "Obriši pregled";
            buttonObrisi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonObrisi.UseVisualStyleBackColor = true;
            buttonObrisi.Click += buttonObrisiPregled_Click;
            // 
            // labelNapomena
            // 
            labelNapomena.AutoSize = true;
            labelNapomena.BackColor = System.Drawing.SystemColors.ControlLight;
            tableLayoutPanelPregled.SetColumnSpan(labelNapomena, 3);
            labelNapomena.Dock = System.Windows.Forms.DockStyle.Fill;
            labelNapomena.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            labelNapomena.Location = new System.Drawing.Point(0, 230);
            labelNapomena.Margin = new System.Windows.Forms.Padding(0);
            labelNapomena.Name = "labelNapomena";
            labelNapomena.Size = new System.Drawing.Size(881, 35);
            labelNapomena.TabIndex = 7;
            labelNapomena.Text = "Napomena pregleda";
            labelNapomena.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSistem
            // 
            labelSistem.AutoSize = true;
            labelSistem.BackColor = System.Drawing.SystemColors.ControlLight;
            tableLayoutPanelPregled.SetColumnSpan(labelSistem, 3);
            labelSistem.Dock = System.Windows.Forms.DockStyle.Fill;
            labelSistem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            labelSistem.Location = new System.Drawing.Point(0, 35);
            labelSistem.Margin = new System.Windows.Forms.Padding(0);
            labelSistem.Name = "labelSistem";
            labelSistem.Size = new System.Drawing.Size(881, 35);
            labelSistem.TabIndex = 5;
            labelSistem.Text = "Sistemi";
            labelSistem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFirmaObjekat
            // 
            labelFirmaObjekat.AutoSize = true;
            labelFirmaObjekat.Dock = System.Windows.Forms.DockStyle.Fill;
            labelFirmaObjekat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            labelFirmaObjekat.Location = new System.Drawing.Point(247, 0);
            labelFirmaObjekat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelFirmaObjekat.Name = "labelFirmaObjekat";
            labelFirmaObjekat.Size = new System.Drawing.Size(313, 35);
            labelFirmaObjekat.TabIndex = 3;
            labelFirmaObjekat.Text = "Firma/objekat:";
            labelFirmaObjekat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAgent
            // 
            labelAgent.AutoSize = true;
            labelAgent.Dock = System.Windows.Forms.DockStyle.Fill;
            labelAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            labelAgent.Location = new System.Drawing.Point(4, 0);
            labelAgent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelAgent.Name = "labelAgent";
            labelAgent.Size = new System.Drawing.Size(235, 35);
            labelAgent.TabIndex = 2;
            labelAgent.Text = "Agent:";
            labelAgent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxNapomenaCitavogPregleda
            // 
            tableLayoutPanelPregled.SetColumnSpan(textBoxNapomenaCitavogPregleda, 3);
            textBoxNapomenaCitavogPregleda.Dock = System.Windows.Forms.DockStyle.Fill;
            textBoxNapomenaCitavogPregleda.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            textBoxNapomenaCitavogPregleda.Location = new System.Drawing.Point(4, 268);
            textBoxNapomenaCitavogPregleda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxNapomenaCitavogPregleda.Multiline = true;
            textBoxNapomenaCitavogPregleda.Name = "textBoxNapomenaCitavogPregleda";
            textBoxNapomenaCitavogPregleda.Size = new System.Drawing.Size(873, 90);
            textBoxNapomenaCitavogPregleda.TabIndex = 8;
            // 
            // dateTimePickerDatumPregleda
            // 
            dateTimePickerDatumPregleda.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            dateTimePickerDatumPregleda.Dock = System.Windows.Forms.DockStyle.Fill;
            dateTimePickerDatumPregleda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            dateTimePickerDatumPregleda.Location = new System.Drawing.Point(568, 3);
            dateTimePickerDatumPregleda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dateTimePickerDatumPregleda.Name = "dateTimePickerDatumPregleda";
            dateTimePickerDatumPregleda.Size = new System.Drawing.Size(309, 24);
            dateTimePickerDatumPregleda.TabIndex = 10;
            // 
            // dataGridViewStavke
            // 
            dataGridViewStavke.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanelPregled.SetColumnSpan(dataGridViewStavke, 3);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridViewStavke.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewStavke.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewStavke.Location = new System.Drawing.Point(3, 73);
            dataGridViewStavke.Name = "dataGridViewStavke";
            dataGridViewStavke.Size = new System.Drawing.Size(875, 154);
            dataGridViewStavke.TabIndex = 11;
            // 
            // FormPregledLista
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(881, 421);
            Controls.Add(tableLayoutPanelPregled);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormPregledLista";
            Text = "FormPregledLista";
            FormClosing += FormPregledLista_FormClosing;
            contextMenuStripPregledTabela.ResumeLayout(false);
            tableLayoutPanelPregled.ResumeLayout(false);
            tableLayoutPanelPregled.PerformLayout();
            tableLayoutPanel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewStavke).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPregledTabela;
        private System.Windows.Forms.ToolStripMenuItem detaljiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izbrišiToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPregled;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
        private System.Windows.Forms.Button buttonSacuvaj;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.Label labelNapomena;
        private System.Windows.Forms.Label labelSistem;
        private System.Windows.Forms.Label labelFirmaObjekat;
        private System.Windows.Forms.Label labelAgent;
        private System.Windows.Forms.TextBox textBoxNapomenaCitavogPregleda;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumPregleda;
        private System.Windows.Forms.DataGridView dataGridViewStavke;
    }
}
