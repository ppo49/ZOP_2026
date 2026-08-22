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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            tableLayoutPanelPregled = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            buttonSacuvaj = new System.Windows.Forms.Button();
            buttonPonisti = new System.Windows.Forms.Button();
            labelNapomena = new System.Windows.Forms.Label();
            labelSistem = new System.Windows.Forms.Label();
            labelFirmaObjekat = new System.Windows.Forms.Label();
            labelAgent = new System.Windows.Forms.Label();
            textBoxNapomenaCitavogPregleda = new System.Windows.Forms.TextBox();
            dateTimePickerDatumPregleda = new System.Windows.Forms.DateTimePicker();
            dataGridViewPregledStavke = new System.Windows.Forms.DataGridView();
            tableLayoutPanelPregled.SuspendLayout();
            tableLayoutPanel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPregledStavke).BeginInit();
            SuspendLayout();
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
            tableLayoutPanelPregled.Controls.Add(dataGridViewPregledStavke, 0, 2);
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
            tableLayoutPanelPregled.Size = new System.Drawing.Size(860, 397);
            tableLayoutPanelPregled.TabIndex = 0;
            // 
            // tableLayoutPanel17
            // 
            tableLayoutPanel17.BackColor = System.Drawing.SystemColors.ControlLight;
            tableLayoutPanel17.ColumnCount = 3;
            tableLayoutPanelPregled.SetColumnSpan(tableLayoutPanel17, 3);
            tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel17.Controls.Add(buttonSacuvaj, 2, 0);
            tableLayoutPanel17.Controls.Add(buttonPonisti, 1, 0);
            tableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel17.Location = new System.Drawing.Point(4, 340);
            tableLayoutPanel17.Margin = new System.Windows.Forms.Padding(4, 3, 4, 17);
            tableLayoutPanel17.Name = "tableLayoutPanel17";
            tableLayoutPanel17.RowCount = 1;
            tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel17.Size = new System.Drawing.Size(852, 40);
            tableLayoutPanel17.TabIndex = 9;
            // 
            // buttonSacuvaj
            // 
            buttonSacuvaj.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            buttonSacuvaj.Image = Properties.Resources.icons8_save_24;
            buttonSacuvaj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            buttonSacuvaj.Location = new System.Drawing.Point(728, 3);
            buttonSacuvaj.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonSacuvaj.Name = "buttonSacuvaj";
            buttonSacuvaj.Size = new System.Drawing.Size(120, 34);
            buttonSacuvaj.TabIndex = 7;
            buttonSacuvaj.Text = "Saèuvaj";
            buttonSacuvaj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSacuvaj.UseVisualStyleBackColor = true;
            buttonSacuvaj.Click += buttonSacuvaj_Click;
            // 
            // buttonPonisti
            // 
            buttonPonisti.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonPonisti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            buttonPonisti.Image = Properties.Resources.icons8_delete2_24;
            buttonPonisti.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            buttonPonisti.Location = new System.Drawing.Point(603, 3);
            buttonPonisti.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonPonisti.Name = "buttonPonisti";
            buttonPonisti.Size = new System.Drawing.Size(117, 34);
            buttonPonisti.TabIndex = 5;
            buttonPonisti.Text = "Poništi";
            buttonPonisti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonPonisti.UseVisualStyleBackColor = true;
            buttonPonisti.Click += buttonPonisti_Click;
            // 
            // labelNapomena
            // 
            labelNapomena.AutoSize = true;
            labelNapomena.BackColor = System.Drawing.SystemColors.ControlLight;
            tableLayoutPanelPregled.SetColumnSpan(labelNapomena, 3);
            labelNapomena.Dock = System.Windows.Forms.DockStyle.Fill;
            labelNapomena.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            labelNapomena.Location = new System.Drawing.Point(0, 215);
            labelNapomena.Margin = new System.Windows.Forms.Padding(0);
            labelNapomena.Name = "labelNapomena";
            labelNapomena.Size = new System.Drawing.Size(860, 35);
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
            labelSistem.Size = new System.Drawing.Size(860, 35);
            labelSistem.TabIndex = 5;
            labelSistem.Text = "Sistemi";
            labelSistem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFirmaObjekat
            // 
            labelFirmaObjekat.AutoSize = true;
            labelFirmaObjekat.Dock = System.Windows.Forms.DockStyle.Fill;
            labelFirmaObjekat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            labelFirmaObjekat.Location = new System.Drawing.Point(238, 0);
            labelFirmaObjekat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelFirmaObjekat.Name = "labelFirmaObjekat";
            labelFirmaObjekat.Size = new System.Drawing.Size(301, 35);
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
            labelAgent.Size = new System.Drawing.Size(226, 35);
            labelAgent.TabIndex = 2;
            labelAgent.Text = "Agent:";
            labelAgent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxNapomenaCitavogPregleda
            // 
            tableLayoutPanelPregled.SetColumnSpan(textBoxNapomenaCitavogPregleda, 3);
            textBoxNapomenaCitavogPregleda.Dock = System.Windows.Forms.DockStyle.Fill;
            textBoxNapomenaCitavogPregleda.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            textBoxNapomenaCitavogPregleda.Location = new System.Drawing.Point(4, 253);
            textBoxNapomenaCitavogPregleda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxNapomenaCitavogPregleda.Multiline = true;
            textBoxNapomenaCitavogPregleda.Name = "textBoxNapomenaCitavogPregleda";
            textBoxNapomenaCitavogPregleda.Size = new System.Drawing.Size(852, 81);
            textBoxNapomenaCitavogPregleda.TabIndex = 8;
            // 
            // dateTimePickerDatumPregleda
            // 
            dateTimePickerDatumPregleda.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            dateTimePickerDatumPregleda.Dock = System.Windows.Forms.DockStyle.Fill;
            dateTimePickerDatumPregleda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            dateTimePickerDatumPregleda.Location = new System.Drawing.Point(547, 3);
            dateTimePickerDatumPregleda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dateTimePickerDatumPregleda.Name = "dateTimePickerDatumPregleda";
            dateTimePickerDatumPregleda.Size = new System.Drawing.Size(309, 24);
            dateTimePickerDatumPregleda.TabIndex = 10;
            // 
            // dataGridViewPregledStavke
            // 
            dataGridViewPregledStavke.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewPregledStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanelPregled.SetColumnSpan(dataGridViewPregledStavke, 3);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridViewPregledStavke.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPregledStavke.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewPregledStavke.Location = new System.Drawing.Point(3, 73);
            dataGridViewPregledStavke.Name = "dataGridViewPregledStavke";
            dataGridViewPregledStavke.Size = new System.Drawing.Size(854, 139);
            dataGridViewPregledStavke.TabIndex = 11;
            // 
            // FormPregled
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(860, 397);
            Controls.Add(tableLayoutPanelPregled);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormPregled";
            Text = "FormPregled";
            FormClosing += FormPregled_FormClosing;
            tableLayoutPanelPregled.ResumeLayout(false);
            tableLayoutPanelPregled.PerformLayout();
            tableLayoutPanel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPregledStavke).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPregled;
        private System.Windows.Forms.Label labelSistem;
        private System.Windows.Forms.Label labelFirmaObjekat;
        private System.Windows.Forms.Label labelAgent;
        private System.Windows.Forms.Label labelNapomena;
        private System.Windows.Forms.TextBox textBoxNapomenaCitavogPregleda;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
        private System.Windows.Forms.Button buttonSacuvaj;
        private System.Windows.Forms.Button buttonPonisti;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumPregleda;
        private System.Windows.Forms.DataGridView dataGridViewPregledStavke;
    }
}
