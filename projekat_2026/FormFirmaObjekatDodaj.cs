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
    public partial class FormFirmaObjekatDodaj : Form
    {
        public FormFirmaObjekatDodaj()
        {
            InitializeComponent();
        }

        private void tableLayoutPanelFirmaObjekat_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.LightGray,1)){

                Rectangle rect = e.CellBounds;


                e.Graphics.DrawLine(pen, rect.Left, rect.Bottom - 1, rect.Right, rect.Bottom - 1);

            }
        }


    }
}
