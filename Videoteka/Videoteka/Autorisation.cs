using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Videoteka
{
    public partial class Autorisation : Form
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=169.254.131.3;Initial Catalog=913-PR-Pantyiukhov;User ID=stud1;Password=Student1$$");
        public Autorisation()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void but_exit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

            if (result == DialogResult.No)
            {
                Form Авторизация = new Autorisation();
                this.Hide();
                Авторизация.Show();
            }

        }

        private void but_login_Click(object sender, EventArgs e)
        {
            bool succses = false;
            
        try
        {


        const string comand = "Select * From Users WHERE Login=@Login AND Password=@Password";
        SqlCommand check = new SqlCommand(comand, con);
        check.Parameters.AddWithValue("@Login", text_login.Text);
        check.Parameters.AddWithValue("@Password", text_psswrd.Text);
        con.Open();

        using (var dataReader = check.ExecuteReader())
        {
        succses = dataReader.Read();
        }
        }
        finally
        {
            con.Close();
        }
        if (succses)
        {
        Menu M = new Menu();
                this.Hide();
                M.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect Login or/and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
