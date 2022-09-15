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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void CancelB_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            if (SNTB.Text == "" && FNTB.Text == "" && MNTB.Text == "" && ATB.Text == "" && GTB.Text == "" && PNTB.Text == "" && PDTB.Text == "" && IDPTB.Text == "") MessageBox.Show("Значения не введены");
            else this.DialogResult = DialogResult.OK;
        }
    }
}
