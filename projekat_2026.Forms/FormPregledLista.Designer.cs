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
            tableLayoutPanelPregledLista = new System.Windows.Forms.TableLayoutPanel();
            toolStripDetaljiPregled = new System.Windows.Forms.ToolStrip();
            toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            toolStripButtonAzurirajPregled = new System.Windows.Forms.ToolStripButton();
            toolStripButtonObrisiObjekat = new System.Windows.Forms.ToolStripButton();
            toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            toolStripButtonPocetna = new System.Windows.Forms.ToolStripButton();
            dataGridViewPreglediObjekta = new System.Windows.Forms.DataGridView();
            listViewObavestenjaZaObjekat = new System.Windows.Forms.ListView();
            contextMenuStripPregledTabela = new System.Windows.Forms.ContextMenuStrip(components);
            detaljiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            izbrišiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tableLayoutPanelPregledLista.SuspendLayout();
            toolStripDetaljiPregled.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPreglediObjekta).BeginInit();
            contextMenuStripPregledTabela.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelPregledLista
            // 
            tableLayoutPanelPregledLista.ColumnCount = 1;
            tableLayoutPanelPregledLista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanelPregledLista.Controls.Add(toolStripDetaljiPregled, 0, 0);
            tableLayoutPanelPregledLista.Controls.Add(dataGridViewPreglediObjekta, 0, 1);
            tableLayoutPanelPregledLista.Controls.Add(listViewObavestenjaZaObjekat, 0, 2);
            tableLayoutPanelPregledLista.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanelPregledLista.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanelPregledLista.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanelPregledLista.Name = "tableLayoutPanelPregledLista";
            tableLayoutPanelPregledLista.RowCount = 3;
            tableLayoutPanelPregledLista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanelPregledLista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.74258F));
            tableLayoutPanelPregledLista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.25743F));
            tableLayoutPanelPregledLista.Size = new System.Drawing.Size(430, 486);
            tableLayoutPanelPregledLista.TabIndex = 0;
            // 
            // toolStripDetaljiPregled
            // 
            toolStripDetaljiPregled.Dock = System.Windows.Forms.DockStyle.Fill;
            toolStripDetaljiPregled.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripButtonRefresh, toolStripButtonAzurirajPregled, toolStripButtonObrisiObjekat, toolStripButtonPrint, toolStripButtonPocetna });
            toolStripDetaljiPregled.Location = new System.Drawing.Point(0, 0);
            toolStripDetaljiPregled.Name = "toolStripDetaljiPregled";
            toolStripDetaljiPregled.Size = new System.Drawing.Size(430, 35);
            toolStripDetaljiPregled.TabIndex = 5;
            toolStripDetaljiPregled.Text = "toolStrip1";
            // 
            // toolStripButtonRefresh
            // 
            toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButtonRefresh.Image = Properties.Resources.icons8_refresh_24;
            toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            toolStripButtonRefresh.Size = new System.Drawing.Size(23, 32);
            toolStripButtonRefresh.Text = "Refresh";
            // 
            // toolStripButtonAzurirajPregled
            // 
            toolStripButtonAzurirajPregled.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButtonAzurirajPregled.Image = Properties.Resources.icons8_edit_folder_24;
            toolStripButtonAzurirajPregled.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonAzurirajPregled.Name = "toolStripButtonAzurirajPregled";
            toolStripButtonAzurirajPregled.Size = new System.Drawing.Size(23, 32);
            toolStripButtonAzurirajPregled.Text = "Detalji";
            // 
            // toolStripButtonObrisiObjekat
            // 
            toolStripButtonObrisiObjekat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButtonObrisiObjekat.Image = Properties.Resources.icons8_delete_file_24;
            toolStripButtonObrisiObjekat.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonObrisiObjekat.Name = "toolStripButtonObrisiObjekat";
            toolStripButtonObrisiObjekat.Size = new System.Drawing.Size(23, 32);
            toolStripButtonObrisiObjekat.Text = "Izbriši pregled";
            // 
            // toolStripButtonPrint
            // 
            toolStripButtonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButtonPrint.Image = Properties.Resources.icons8_print_24;
            toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonPrint.Name = "toolStripButtonPrint";
            toolStripButtonPrint.Size = new System.Drawing.Size(23, 32);
            toolStripButtonPrint.Text = "Print";
            // 
            // toolStripButtonPocetna
            // 
            toolStripButtonPocetna.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButtonPocetna.Image = Properties.Resources.icons8_login_24;
            toolStripButtonPocetna.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonPocetna.Name = "toolStripButtonPocetna";
            toolStripButtonPocetna.RightToLeft = System.Windows.Forms.RightToLeft.No;
            toolStripButtonPocetna.Size = new System.Drawing.Size(23, 32);
            toolStripButtonPocetna.Text = "Poèetna";
            // 
            // dataGridViewPreglediObjekta
            // 
            dataGridViewPreglediObjekta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPreglediObjekta.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewPreglediObjekta.Location = new System.Drawing.Point(4, 38);
            dataGridViewPreglediObjekta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dataGridViewPreglediObjekta.Name = "dataGridViewPreglediObjekta";
            dataGridViewPreglediObjekta.Size = new System.Drawing.Size(422, 335);
            dataGridViewPreglediObjekta.TabIndex = 0;
            // 
            // listViewObavestenjaZaObjekat
            // 
            listViewObavestenjaZaObjekat.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewObavestenjaZaObjekat.Location = new System.Drawing.Point(4, 379);
            listViewObavestenjaZaObjekat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 23);
            listViewObavestenjaZaObjekat.Name = "listViewObavestenjaZaObjekat";
            listViewObavestenjaZaObjekat.Size = new System.Drawing.Size(422, 84);
            listViewObavestenjaZaObjekat.TabIndex = 1;
            listViewObavestenjaZaObjekat.UseCompatibleStateImageBehavior = false;
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
            // FormPregledLista
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(430, 486);
            Controls.Add(tableLayoutPanelPregledLista);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormPregledLista";
            Text = "FormPregledLista";
            tableLayoutPanelPregledLista.ResumeLayout(false);
            tableLayoutPanelPregledLista.PerformLayout();
            toolStripDetaljiPregled.ResumeLayout(false);
            toolStripDetaljiPregled.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPreglediObjekta).EndInit();
            contextMenuStripPregledTabela.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPregledLista;
        private System.Windows.Forms.DataGridView dataGridViewPreglediObjekta;
        private System.Windows.Forms.ListView listViewObavestenjaZaObjekat;
        private System.Windows.Forms.ToolStrip toolStripDetaljiPregled;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.ToolStripButton toolStripButtonAzurirajPregled;
        private System.Windows.Forms.ToolStripButton toolStripButtonObrisiObjekat;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
        private System.Windows.Forms.ToolStripButton toolStripButtonPocetna;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPregledTabela;
        private System.Windows.Forms.ToolStripMenuItem detaljiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izbrišiToolStripMenuItem;
    }
}
