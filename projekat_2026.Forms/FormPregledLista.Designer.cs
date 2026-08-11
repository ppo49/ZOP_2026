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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanelPregledLista = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewPreglediObjekta = new System.Windows.Forms.DataGridView();
            this.listViewObavestenjaZaObjekat = new System.Windows.Forms.ListView();
            this.toolStripDetaljiPregled = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAzurirajPregled = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonObrisiObjekat = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPocetna = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStripPregledTabela = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detaljiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izbrišiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelPregledLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPreglediObjekta)).BeginInit();
            this.toolStripDetaljiPregled.SuspendLayout();
            this.contextMenuStripPregledTabela.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelPregledLista
            // 
            this.tableLayoutPanelPregledLista.ColumnCount = 1;
            this.tableLayoutPanelPregledLista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPregledLista.Controls.Add(this.toolStripDetaljiPregled, 0, 0);
            this.tableLayoutPanelPregledLista.Controls.Add(this.dataGridViewPreglediObjekta, 0, 1);
            this.tableLayoutPanelPregledLista.Controls.Add(this.listViewObavestenjaZaObjekat, 0, 2);
            this.tableLayoutPanelPregledLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPregledLista.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelPregledLista.Name = "tableLayoutPanelPregledLista";
            this.tableLayoutPanelPregledLista.RowCount = 3;
            this.tableLayoutPanelPregledLista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelPregledLista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.74258F));
            this.tableLayoutPanelPregledLista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.25743F));
            this.tableLayoutPanelPregledLista.Size = new System.Drawing.Size(369, 421);
            this.tableLayoutPanelPregledLista.TabIndex = 0;
            // 
            // dataGridViewPreglediObjekta
            // 
            this.dataGridViewPreglediObjekta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPreglediObjekta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPreglediObjekta.Location = new System.Drawing.Point(3, 33);
            this.dataGridViewPreglediObjekta.Name = "dataGridViewPreglediObjekta";
            this.dataGridViewPreglediObjekta.Size = new System.Drawing.Size(363, 290);
            this.dataGridViewPreglediObjekta.TabIndex = 0;
            // 
            // listViewObavestenjaZaObjekat
            // 
            this.listViewObavestenjaZaObjekat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewObavestenjaZaObjekat.HideSelection = false;
            this.listViewObavestenjaZaObjekat.Location = new System.Drawing.Point(3, 329);
            this.listViewObavestenjaZaObjekat.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.listViewObavestenjaZaObjekat.Name = "listViewObavestenjaZaObjekat";
            this.listViewObavestenjaZaObjekat.Size = new System.Drawing.Size(363, 72);
            this.listViewObavestenjaZaObjekat.TabIndex = 1;
            this.listViewObavestenjaZaObjekat.UseCompatibleStateImageBehavior = false;
            // 
            // toolStripDetaljiPregled
            // 
            this.toolStripDetaljiPregled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripDetaljiPregled.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonRefresh,
            this.toolStripButtonAzurirajPregled,
            this.toolStripButtonObrisiObjekat,
            this.toolStripButtonPrint,
            this.toolStripButtonPocetna});
            this.toolStripDetaljiPregled.Location = new System.Drawing.Point(0, 0);
            this.toolStripDetaljiPregled.Name = "toolStripDetaljiPregled";
            this.toolStripDetaljiPregled.Size = new System.Drawing.Size(369, 30);
            this.toolStripDetaljiPregled.TabIndex = 5;
            this.toolStripDetaljiPregled.Text = "toolStrip1";
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefresh.Image = global::projekat_2026.Properties.Resources.icons8_refresh_24;
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(23, 27);
            this.toolStripButtonRefresh.Text = "Refresh";
            // 
            // toolStripButtonAzurirajPregled
            // 
            this.toolStripButtonAzurirajPregled.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAzurirajPregled.Image = global::projekat_2026.Properties.Resources.icons8_edit_file_24;
            this.toolStripButtonAzurirajPregled.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAzurirajPregled.Name = "toolStripButtonAzurirajPregled";
            this.toolStripButtonAzurirajPregled.Size = new System.Drawing.Size(23, 27);
            this.toolStripButtonAzurirajPregled.Text = "Detalji";
            // 
            // toolStripButtonObrisiObjekat
            // 
            this.toolStripButtonObrisiObjekat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonObrisiObjekat.Image = global::projekat_2026.Properties.Resources.icons8_delete_file_24;
            this.toolStripButtonObrisiObjekat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonObrisiObjekat.Name = "toolStripButtonObrisiObjekat";
            this.toolStripButtonObrisiObjekat.Size = new System.Drawing.Size(23, 27);
            this.toolStripButtonObrisiObjekat.Text = "Izbriši pregled";
            // 
            // toolStripButtonPrint
            // 
            this.toolStripButtonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPrint.Image = global::projekat_2026.Properties.Resources.icons8_print_24;
            this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrint.Name = "toolStripButtonPrint";
            this.toolStripButtonPrint.Size = new System.Drawing.Size(23, 27);
            this.toolStripButtonPrint.Text = "Print";
            // 
            // toolStripButtonPocetna
            // 
            this.toolStripButtonPocetna.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPocetna.Image = global::projekat_2026.Properties.Resources.icons8_login_24;
            this.toolStripButtonPocetna.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPocetna.Name = "toolStripButtonPocetna";
            this.toolStripButtonPocetna.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripButtonPocetna.Size = new System.Drawing.Size(23, 27);
            this.toolStripButtonPocetna.Text = "Početna";
            // 
            // contextMenuStripPregledTabela
            // 
            this.contextMenuStripPregledTabela.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detaljiToolStripMenuItem,
            this.izbrišiToolStripMenuItem});
            this.contextMenuStripPregledTabela.Name = "contextMenuStripPregledTabela";
            this.contextMenuStripPregledTabela.Size = new System.Drawing.Size(108, 48);
            // 
            // detaljiToolStripMenuItem
            // 
            this.detaljiToolStripMenuItem.Name = "detaljiToolStripMenuItem";
            this.detaljiToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.detaljiToolStripMenuItem.Text = "Detalji";
            // 
            // izbrišiToolStripMenuItem
            // 
            this.izbrišiToolStripMenuItem.Name = "izbrišiToolStripMenuItem";
            this.izbrišiToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.izbrišiToolStripMenuItem.Text = "Izbriši";
            // 
            // FormPregledLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 421);
            this.Controls.Add(this.tableLayoutPanelPregledLista);
            this.Name = "FormPregledLista";
            this.Text = "FormPregledLista";
            this.tableLayoutPanelPregledLista.ResumeLayout(false);
            this.tableLayoutPanelPregledLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPreglediObjekta)).EndInit();
            this.toolStripDetaljiPregled.ResumeLayout(false);
            this.toolStripDetaljiPregled.PerformLayout();
            this.contextMenuStripPregledTabela.ResumeLayout(false);
            this.ResumeLayout(false);

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