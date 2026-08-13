using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
