using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Videoteka
{
    public partial class AddCassettes : Form
    {
        public AddCassettes()
        {
            InitializeComponent();
        }

        private void CancelB_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            if (FNTB.Text == "" && CYTB.Text == "" && ProdTB.Text == "" && CCTB.Text == "" && MATB.Text == "" && RDTB.Text == "" && IDGTB.Text == "" && PriceTB.Text == "") MessageBox.Show("Значения не введены");
            else this.DialogResult = DialogResult.OK;
        }
    }
}
