using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekat_2026
{
    internal class ClassDizajnFormi
    {
        public void setAllTextBoxesReadOnly(Control container, bool isReadOnly)
        {
            foreach (Control ctrl in container.Controls)
            {
                if (ctrl is TextBox textBox)
                {
                    textBox.ReadOnly = isReadOnly;
                }
                else if (ctrl.HasChildren)
                {
                    setAllTextBoxesReadOnly(ctrl, isReadOnly);
                }
            }
        }


        public void clearTabPageContent(Control container)
        {
            foreach (Control ctrl in container.Controls)
            {
                if (ctrl is TextBox textBox)
                {
                    textBox.Clear();
                }
                else if (ctrl is DataGridView dgv)
                {
                    dgv.DataSource = null;

                }

                if (ctrl.HasChildren)
                {
                    clearTabPageContent(ctrl);
                }
            }


        }


        public static void SelectRowOnRightClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (sender is DataGridView dgv)
            {

                if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    dgv.ClearSelection();
                    dgv.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        public bool isEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool isTelefon(string telefon)
        {
            string pattern = @"^(\+381|0)[6-9]\d{7,8}$";

            if (Regex.IsMatch(telefon, pattern, RegexOptions.IgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        



    }
}
