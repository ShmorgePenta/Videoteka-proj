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
    public partial class AddClients : Form
    {
        public AddClients()
        {
            InitializeComponent();
        }

        private void CancelB_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            if (FNTB.Text == "" && SNTB.Text == "" && MNTB.Text == "" && HATB.Text == "" && PNTB.Text == "" && PDTB.Text == "" && DoITB.Text == "" && DoRTB.Text == "" && PMTB.Text == "" && RMTB.Text == "" && IDCas1TB.Text == "" && IDCas2TB.Text == "" && IDCas3TB.Text == "" && IDETB.Text == "") MessageBox.Show("Значения не введены");
            else this.DialogResult = DialogResult.OK;
        }
    }
}
