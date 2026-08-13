namespace projekat_2026
{
    partial class FormLogin
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
            tableLayoutPanelLogin = new System.Windows.Forms.TableLayoutPanel();
            labelObavestenje = new System.Windows.Forms.Label();
            tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            textBoxLoginEmail = new System.Windows.Forms.TextBox();
            labelLoginEmail = new System.Windows.Forms.Label();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            textBoxLoginPassword = new System.Windows.Forms.TextBox();
            labelLoginPassword = new System.Windows.Forms.Label();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            linkLabelRegistrujSe = new System.Windows.Forms.LinkLabel();
            buttonLogIn = new System.Windows.Forms.Button();
            errorProviderLogin = new System.Windows.Forms.ErrorProvider(components);
            tableLayoutPanelLogin.SuspendLayout();
            tableLayoutPanel16.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderLogin).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanelLogin
            // 
            tableLayoutPanelLogin.ColumnCount = 1;
            tableLayoutPanelLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanelLogin.Controls.Add(labelObavestenje, 0, 2);
            tableLayoutPanelLogin.Controls.Add(tableLayoutPanel16, 0, 0);
            tableLayoutPanelLogin.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanelLogin.Controls.Add(tableLayoutPanel2, 0, 3);
            tableLayoutPanelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanelLogin.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanelLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanelLogin.Name = "tableLayoutPanelLogin";
            tableLayoutPanelLogin.RowCount = 4;
            tableLayoutPanelLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            tableLayoutPanelLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            tableLayoutPanelLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            tableLayoutPanelLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            tableLayoutPanelLogin.Size = new System.Drawing.Size(287, 220);
            tableLayoutPanelLogin.TabIndex = 0;
            // 
            // labelObavestenje
            // 
            labelObavestenje.AutoSize = true;
            labelObavestenje.Dock = System.Windows.Forms.DockStyle.Fill;
            labelObavestenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            labelObavestenje.ForeColor = System.Drawing.Color.Red;
            labelObavestenje.Location = new System.Drawing.Point(4, 134);
            labelObavestenje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelObavestenje.Name = "labelObavestenje";
            labelObavestenje.Size = new System.Drawing.Size(279, 38);
            labelObavestenje.TabIndex = 24;
            labelObavestenje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel16
            // 
            tableLayoutPanel16.ColumnCount = 2;
            tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel16.Controls.Add(textBoxLoginEmail, 0, 1);
            tableLayoutPanel16.Controls.Add(labelLoginEmail, 0, 0);
            tableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel16.Location = new System.Drawing.Point(4, 3);
            tableLayoutPanel16.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel16.Name = "tableLayoutPanel16";
            tableLayoutPanel16.RowCount = 2;
            tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            tableLayoutPanel16.Size = new System.Drawing.Size(279, 61);
            tableLayoutPanel16.TabIndex = 20;
            // 
            // textBoxLoginEmail
            // 
            textBoxLoginEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            textBoxLoginEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            textBoxLoginEmail.Location = new System.Drawing.Point(4, 35);
            textBoxLoginEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxLoginEmail.Name = "textBoxLoginEmail";
            textBoxLoginEmail.Size = new System.Drawing.Size(251, 24);
            textBoxLoginEmail.TabIndex = 13;
            textBoxLoginEmail.Validating += TextBoxLoginEmail_Validating;
            // 
            // labelLoginEmail
            // 
            labelLoginEmail.AutoSize = true;
            labelLoginEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            labelLoginEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            labelLoginEmail.Location = new System.Drawing.Point(4, 0);
            labelLoginEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelLoginEmail.Name = "labelLoginEmail";
            labelLoginEmail.Size = new System.Drawing.Size(251, 32);
            labelLoginEmail.TabIndex = 14;
            labelLoginEmail.Text = "E-Mail";
            labelLoginEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(textBoxLoginPassword, 0, 1);
            tableLayoutPanel1.Controls.Add(labelLoginPassword, 0, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(4, 70);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            tableLayoutPanel1.Size = new System.Drawing.Size(279, 61);
            tableLayoutPanel1.TabIndex = 21;
            // 
            // textBoxLoginPassword
            // 
            textBoxLoginPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            textBoxLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            textBoxLoginPassword.Location = new System.Drawing.Point(4, 35);
            textBoxLoginPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxLoginPassword.Name = "textBoxLoginPassword";
            textBoxLoginPassword.Size = new System.Drawing.Size(251, 24);
            textBoxLoginPassword.TabIndex = 13;
            // 
            // labelLoginPassword
            // 
            labelLoginPassword.AutoSize = true;
            labelLoginPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            labelLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            labelLoginPassword.Location = new System.Drawing.Point(4, 0);
            labelLoginPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelLoginPassword.Name = "labelLoginPassword";
            labelLoginPassword.Size = new System.Drawing.Size(251, 32);
            labelLoginPassword.TabIndex = 14;
            labelLoginPassword.Text = "Lozinka";
            labelLoginPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.78571F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.21429F));
            tableLayoutPanel2.Controls.Add(linkLabelRegistrujSe, 0, 0);
            tableLayoutPanel2.Controls.Add(buttonLogIn, 1, 0);
            tableLayoutPanel2.Location = new System.Drawing.Point(4, 175);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new System.Drawing.Size(279, 43);
            tableLayoutPanel2.TabIndex = 23;
            // 
            // linkLabelRegistrujSe
            // 
            linkLabelRegistrujSe.AutoSize = true;
            linkLabelRegistrujSe.Dock = System.Windows.Forms.DockStyle.Fill;
            linkLabelRegistrujSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            linkLabelRegistrujSe.Location = new System.Drawing.Point(4, 0);
            linkLabelRegistrujSe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            linkLabelRegistrujSe.Name = "linkLabelRegistrujSe";
            linkLabelRegistrujSe.Size = new System.Drawing.Size(178, 43);
            linkLabelRegistrujSe.TabIndex = 0;
            linkLabelRegistrujSe.TabStop = true;
            linkLabelRegistrujSe.Text = "*Registruj se";
            // 
            // buttonLogIn
            // 
            buttonLogIn.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            buttonLogIn.Image = Properties.Resources.icons8_login_24;
            buttonLogIn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            buttonLogIn.Location = new System.Drawing.Point(190, 3);
            buttonLogIn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new System.Drawing.Size(85, 37);
            buttonLogIn.TabIndex = 1;
            buttonLogIn.Text = "Log in";
            buttonLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonLogIn.UseVisualStyleBackColor = true;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // errorProviderLogin
            // 
            errorProviderLogin.ContainerControl = this;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(287, 220);
            Controls.Add(tableLayoutPanelLogin);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormLogin";
            Text = "ZOP Login";
            FormClosing += FormLogin_FormClosing;
            tableLayoutPanelLogin.ResumeLayout(false);
            tableLayoutPanelLogin.PerformLayout();
            tableLayoutPanel16.ResumeLayout(false);
            tableLayoutPanel16.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderLogin).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        private System.Windows.Forms.TextBox textBoxLoginEmail;
        private System.Windows.Forms.Label labelLoginEmail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxLoginPassword;
        private System.Windows.Forms.Label labelLoginPassword;
        private System.Windows.Forms.Label labelObavestenje;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.LinkLabel linkLabelRegistrujSe;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.ErrorProvider errorProviderLogin;
    }
}
