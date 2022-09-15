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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Menu_exit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

            if (result == DialogResult.No)
            {
                Form Меню = new Menu();
                Меню.Show();
                this.Hide();
            }
        }

        private void menu_logout_Click(object sender, EventArgs e)
        {           
            Form Авторизация = new Autorisation();
            Авторизация.Show();
            Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form Кассеты = new Cassettes();
            Кассеты.Show();           
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form Клиенты = new Clients();
            Клиенты.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form Сотрудники = new Employees();            
            Сотрудники.Show();

        }
    }
}
