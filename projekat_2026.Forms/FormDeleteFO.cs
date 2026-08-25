using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekat_2026
{
    public partial class FormDeleteFO : Form
    {
        string _firmaObjekatIme;
        public FormDeleteFO(string firmaObjekatIme)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            _firmaObjekatIme = firmaObjekatIme;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxProvera.Text.Trim() == _firmaObjekatIme)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Neispravan unos imena firme/objekta, Brisanje obustavljeno",
                    "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxProvera.Focus();
                textBoxProvera.SelectAll();
            }
        }
    }
}
