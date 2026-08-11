namespace projekat_2026
{
    partial class FormSistemDodaj
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
            this.tableLayoutPanelCenterContnet = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSacuvaj = new System.Windows.Forms.Button();
            this.buttonPonisti = new System.Windows.Forms.Button();
            this.textBoxSistem = new System.Windows.Forms.TextBox();
            this.labelSistem = new System.Windows.Forms.Label();
            this.tableLayoutPanelCenterContnet.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelCenterContnet
            // 
            this.tableLayoutPanelCenterContnet.ColumnCount = 1;
            this.tableLayoutPanelCenterContnet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCenterContnet.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanelCenterContnet.Controls.Add(this.textBoxSistem, 0, 1);
            this.tableLayoutPanelCenterContnet.Controls.Add(this.labelSistem, 0, 0);
            this.tableLayoutPanelCenterContnet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCenterContnet.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelCenterContnet.Name = "tableLayoutPanelCenterContnet";
            this.tableLayoutPanelCenterContnet.RowCount = 3;
            this.tableLayoutPanelCenterContnet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.98305F));
            this.tableLayoutPanelCenterContnet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.01695F));
            this.tableLayoutPanelCenterContnet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelCenterContnet.Size = new System.Drawing.Size(314, 119);
            this.tableLayoutPanelCenterContnet.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.buttonSacuvaj, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.buttonPonisti, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 15);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(308, 40);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // buttonSacuvaj
            // 
            this.buttonSacuvaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSacuvaj.Image = global::projekat_2026.Properties.Resources.icons8_save_24;
            this.buttonSacuvaj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSacuvaj.Location = new System.Drawing.Point(201, 3);
            this.buttonSacuvaj.Name = "buttonSacuvaj";
            this.buttonSacuvaj.Size = new System.Drawing.Size(104, 34);
            this.buttonSacuvaj.TabIndex = 7;
            this.buttonSacuvaj.Text = "Sačuvaj";
            this.buttonSacuvaj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSacuvaj.UseVisualStyleBackColor = true;
            // 
            // buttonPonisti
            // 
            this.buttonPonisti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPonisti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPonisti.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPonisti.Location = new System.Drawing.Point(92, 3);
            this.buttonPonisti.Name = "buttonPonisti";
            this.buttonPonisti.Size = new System.Drawing.Size(103, 34);
            this.buttonPonisti.TabIndex = 5;
            this.buttonPonisti.Text = "Poništi";
            this.buttonPonisti.UseVisualStyleBackColor = true;
            // 
            // textBoxSistem
            // 
            this.textBoxSistem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSistem.Location = new System.Drawing.Point(3, 24);
            this.textBoxSistem.Multiline = true;
            this.textBoxSistem.Name = "textBoxSistem";
            this.textBoxSistem.Size = new System.Drawing.Size(308, 27);
            this.textBoxSistem.TabIndex = 3;
            // 
            // labelSistem
            // 
            this.labelSistem.AutoSize = true;
            this.labelSistem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelSistem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSistem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSistem.Location = new System.Drawing.Point(3, 0);
            this.labelSistem.Name = "labelSistem";
            this.labelSistem.Size = new System.Drawing.Size(308, 21);
            this.labelSistem.TabIndex = 2;
            this.labelSistem.Text = "Novi sistem";
            this.labelSistem.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // FormSistemDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 119);
            this.Controls.Add(this.tableLayoutPanelCenterContnet);
            this.Name = "FormSistemDodaj";
            this.Text = "FormSistemDodaj";
            this.tableLayoutPanelCenterContnet.ResumeLayout(false);
            this.tableLayoutPanelCenterContnet.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCenterContnet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button buttonSacuvaj;
        private System.Windows.Forms.Button buttonPonisti;
        private System.Windows.Forms.TextBox textBoxSistem;
        private System.Windows.Forms.Label labelSistem;
    }
}