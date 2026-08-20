using Microsoft.EntityFrameworkCore;
using projekat_2026.Core;
using projekat_2026.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace projekat_2026
{

    public partial class FormLogin : Form
    {
        private readonly DbContextOptions<AppDbContext> _dbOptions;

        private static readonly Regex EmailRegex = new Regex(
            @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
            RegexOptions.Compiled | RegexOptions.IgnoreCase
        );


        private static readonly Regex PwdRegex = new Regex(
            @"^[a-zA-Z0-9.,! $#]{0,16}$",
            RegexOptions.Compiled | RegexOptions.IgnoreCase
        );


        public FormLogin(DbContextOptions<AppDbContext> dbOptions)
        {
            InitializeComponent();
            _dbOptions = dbOptions;

            /*using var db = new AppDbContext(_dbOptions);
            var agentCount = db.Agents.Count();
            MessageBox.Show($"Agents in DB: {agentCount}");*/


            //forma izgled
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.WindowState = FormWindowState.Normal;


            textBoxLoginPassword.UseSystemPasswordChar = true;
            textBoxLoginPassword.MaxLength = 16;
            textBoxLoginEmail.Validating += TextBoxLoginEmail_Validating;
            textBoxLoginPassword.Validating += TextBoxLoginPassword_Validating;
        }

        private void TextBoxLoginPassword_Validating(object sender, CancelEventArgs e)
        {
            string pwdInput = textBoxLoginPassword.Text.Trim();



            if (string.IsNullOrEmpty(pwdInput))
            {
                errorProviderLogin.SetError(textBoxLoginPassword, "Lozinka je obavezna.");
                return;
            }

            if (!PwdRegex.IsMatch(pwdInput))
            {
                errorProviderLogin.SetError(textBoxLoginPassword, "Unesite validnu lozinku.");
            }
            else
            {
                errorProviderLogin.SetError(textBoxLoginPassword, string.Empty);
            }
        }

        private void TextBoxLoginEmail_Validating(object sender, CancelEventArgs e)
        {
            string emailInput = textBoxLoginEmail.Text.Trim();

            if (string.IsNullOrEmpty(emailInput))
            {
                errorProviderLogin.SetError(textBoxLoginEmail, "E-mail je obavezan.");
                return;
            }

            if (!EmailRegex.IsMatch(emailInput))
            {
                errorProviderLogin.SetError(textBoxLoginEmail, "Unesite validnu e-mail adresu. (e.g., user@domain.com).");
            }
            else
            {
                errorProviderLogin.SetError(textBoxLoginEmail, string.Empty);
            }
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                using var db = new AppDbContext(_dbOptions);
                var auth = new AuthService();

                var agent = db.Agents.FirstOrDefault(a => a.SluzbeniEmail == textBoxLoginEmail.Text);
                if (agent == null || !auth.VerifyPassword(textBoxLoginPassword.Text, agent.Pwd))
                {
                    labelObavestenje.Text = "Pogrešan e-mail ili lozinka.";
                    return;
                }

                FormMain formMain = new FormMain(_dbOptions, agent);

                formMain.FormClosed += (s, args) => this.Close();

                this.Hide();
                formMain.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
