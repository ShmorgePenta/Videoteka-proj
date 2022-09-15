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
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using System.Reflection;

namespace Videoteka
{
    public partial class Clients : Form
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=169.254.131.3;Initial Catalog=913-PR-Pantyiukhov;User ID=stud1;Password=Student1$$");
        public Clients()
        {
            InitializeComponent();
        }

        private void BackB_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            AddClients f = new AddClients();
            f.Text = "Добавить нового клиента";
            if (f.ShowDialog() == DialogResult.OK)
            {
                SqlDataAdapter yes = new SqlDataAdapter("insert into [Clients] ([Firstname], [Secondname], [Middlename], [House_Adress], [Phone_Number], [Passport_Data], [Date_Of_Issue], [Return_Date], [Payment_Mark], [Return_Mark], [Cassette_ID_1], [Cassette_ID_2], [Cassette_ID_3], [Employee_ID]) values ('" + f.FNTB.Text + "', '" + f.SNTB.Text + "', '" + f.MNTB.Text + "', '" + f.HATB.Text + "', '" + f.PNTB.Text + "', '" + f.PDTB.Text + "', '" + f.DoITB.Text + "', '" + f.DoRTB.Text + "', '" + f.PMTB.Text + "', '" + f.RMTB.Text + "', '" + f.IDCas1TB.Text + "', '" + f.IDCas2TB.Text + "', '" + f.IDCas3TB.Text + "', '" + f.IDETB.Text + "',)", con);
                DataTable dt = new DataTable();
                yes.Fill(dt);
                dgvCl.DataSource = yes;
                Clients_Load(sender, e);
                MessageBox.Show("Данные добавлены");
            }
        }
        void load_data()
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT*FROM [Clients]", con);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            dgvCl.DataSource = data;
        }
        private void Clients_Load(object sender, EventArgs e)
        {
            
        }

        private void EditB_Click(object sender, EventArgs e)
        {
            AddClients f = new AddClients();
            f.Text = "Изменить данные о клиенте";
            f.label1.Text = "Изменить данные о клиенте";
            f.AddB.Text = "Изменить";
            f.FNTB.Text = Convert.ToString(dgvCl[1, dgvCl.CurrentRow.Index].Value);
            f.SNTB.Text = Convert.ToString(dgvCl[2, dgvCl.CurrentRow.Index].Value);
            f.MNTB.Text = Convert.ToString(dgvCl[3, dgvCl.CurrentRow.Index].Value);
            f.HATB.Text = Convert.ToString(dgvCl[4, dgvCl.CurrentRow.Index].Value);
            f.PNTB.Text = Convert.ToString(dgvCl[5, dgvCl.CurrentRow.Index].Value);
            f.PDTB.Text = Convert.ToString(dgvCl[6, dgvCl.CurrentRow.Index].Value);
            f.DoITB.Text = Convert.ToString(dgvCl[7, dgvCl.CurrentRow.Index].Value);
            f.DoRTB.Text = Convert.ToString(dgvCl[8, dgvCl.CurrentRow.Index].Value);
            f.PMTB.Text = Convert.ToString(dgvCl[9, dgvCl.CurrentRow.Index].Value);
            f.RMTB.Text = Convert.ToString(dgvCl[10, dgvCl.CurrentRow.Index].Value);
            f.IDCas1TB.Text = Convert.ToString(dgvCl[11, dgvCl.CurrentRow.Index].Value);
            f.IDCas2TB.Text = Convert.ToString(dgvCl[12, dgvCl.CurrentRow.Index].Value);
            f.IDCas3TB.Text = Convert.ToString(dgvCl[13, dgvCl.CurrentRow.Index].Value);
            f.IDETB.Text = Convert.ToString(dgvCl[14, dgvCl.CurrentRow.Index].Value);
            if (f.ShowDialog() == DialogResult.OK)
            {
                SqlDataAdapter yes = new SqlDataAdapter("update [Clients] set [Firstname] = '" + f.FNTB.Text + "', [Secondname] = '" + f.SNTB.Text + "', [Middlename] = '" + f.MNTB.Text + "', [House_Adress] = '" + f.HATB.Text + "', [Phone_Number] = '" + f.PNTB.Text + "', [Passport_Data] = '" + f.PDTB.Text + "', [Date_Of_Issue] = '" + f.DoITB.Text + "', [Return_Date] = '" + f.DoRTB.Text + "', [Payment_Mark] = '" + f.PMTB.Text + "', [Return_Mark] = '" + f.RMTB.Text + "', [Cassette_ID_1] = '" + f.IDCas1TB.Text + "', [Cassette_ID_2] = '" + f.IDCas2TB.Text + "', [Cassette_ID_3] = '" + f.IDCas3TB.Text + "', [Employee_ID] = '" + f.IDETB.Text + "' where Client_ID =" + Convert.ToString(dgvCl[0, dgvCl.CurrentRow.Index].Value), con);
                DataTable dt = new DataTable();
                yes.Fill(dt);
                dgvCl.DataSource = yes;
                Clients_Load(sender, e);
                MessageBox.Show("Данные изменены");
            }
        }

        private void DelB_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select Client_ID from [Clients] Where [Client_ID]=" + Convert.ToString(dgvCl[0, dgvCl.CurrentRow.Index].Value), con);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dgvCl.DataSource = dt2;

            DialogResult result = MessageBox.Show("Действительно удалить?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (result == DialogResult.Yes)
            {
                SqlDataAdapter da = new SqlDataAdapter("delete from [Clients] where [Client_ID] = " + Convert.ToString(dgvCl[0, dgvCl.CurrentRow.Index].Value), con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCl.DataSource = da;
                load_data();

            }
        }

        private void RefB_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        SqlDataAdapter uno = new SqlDataAdapter("SELECT Clients.Firstname, Clients.Secondname, Clients.Middlename, Clients.House_Adress, Clients.Phone_Number, Clients.Passport_Data, Clients.Date_Of_Issue, Clients.Return_Date, Clients.Payment_Mark, Clients.Return_Mark, Clients.Cassette_ID_1, Clients.Cassette_ID_2, Clients.Cassette_ID_3", con);
                        DataSet dos = new DataSet();
                        uno.Fill(dos);
                        dgvCl.DataSource = dos.Tables[0];
                        break;
                    }
                case 1:
                    {
                        SqlDataAdapter uno = new SqlDataAdapter("SELECT Clients.Firstname, Clients.Secondname, Clients.Middlename, Clients.House_Adress, Clients.Phone_Number, Clients.Passport_Data, Clients.Date_Of_Issue, Clients.Return_Date, Clients.Payment_Mark, Clients.Return_Mark, Clients.Cassette_ID_1, Clients.Cassette_ID_2, Clients.Cassette_ID_3", con);
                        DataSet dos = new DataSet();
                        uno.Fill(dos);
                        dgvCl.DataSource = dos.Tables[0];
                        break;
                    }
                case 2:
                    {
                        SqlDataAdapter uno = new SqlDataAdapter("SELECT Clients.Firstname, Clients.Secondname, Clients.Middlename, Clients.House_Adress, Clients.Phone_Number, Clients.Passport_Data, Clients.Date_Of_Issue, Clients.Return_Date, Clients.Payment_Mark, Clients.Return_Mark, Clients.Cassette_ID_1, Clients.Cassette_ID_2, Clients.Cassette_ID_3", con);
                        DataSet dos = new DataSet();
                        uno.Fill(dos);
                        dgvCl.DataSource = dos.Tables[0];
                        break;
                    }
                case 3:
                    {
                        SqlDataAdapter uno = new SqlDataAdapter("SELECT Clients.Firstname, Clients.Secondname, Clients.Middlename, Clients.House_Adress, Clients.Phone_Number, Clients.Passport_Data, Clients.Date_Of_Issue, Clients.Return_Date, Clients.Payment_Mark, Clients.Return_Mark, Clients.Cassette_ID_1, Clients.Cassette_ID_2, Clients.Cassette_ID_3", con);
                        DataSet dos = new DataSet();
                        uno.Fill(dos);
                        dgvCl.DataSource = dos.Tables[0];
                        break;
                    }
                case 4:
                    {
                        SqlDataAdapter uno = new SqlDataAdapter("SELECT Clients.Firstname, Clients.Secondname, Clients.Middlename, Clients.House_Adress, Clients.Phone_Number, Clients.Passport_Data, Clients.Date_Of_Issue, Clients.Return_Date, Clients.Payment_Mark, Clients.Return_Mark, Clients.Cassette_ID_1, Clients.Cassette_ID_2, Clients.Cassette_ID_3", con);
                        DataSet dos = new DataSet();
                        uno.Fill(dos);
                        dgvCl.DataSource = dos.Tables[0];
                        break;
                    }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvCl.RowCount; i++)
            {
                dgvCl.Rows[i].Selected = false;
                for (int j = 0; j < dgvCl.ColumnCount; j++)
                    if (dgvCl.Rows[i].Cells[j].Value != null)
                    {
                        if (textBox1.Text != " " || textBox1.Text != String.Empty)
                        {
                            if (dgvCl.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBox1.Text.ToLower()))
                            {
                                if (!dgvCl.Rows[i].Visible)
                                {
                                    dgvCl.Rows[i].Visible = true;
                                }
                                dgvCl.Rows[i].Selected = true;
                                break;
                            }
                        }
                    }
            }
            for (int i = 0; i < dgvCl.RowCount; i++)
            {
                if (dgvCl.Rows[i].Selected != true)
                {
                    dgvCl.CurrentCell = null;
                    if (dgvCl.Rows[i].Cells[0].Value != null)
                    {

                        dgvCl.Rows[i].Visible = false;
                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateWord(@"D:\Курсач\Приложение\Videoteka\Videoteka\ЭкспортКлиенты.docx", @"D:\Курсач\Приложение\Videoteka\ЭкспортКлиенты.docx");
        }

        private void FindAndReplace(Word.Application wordApp, object ToFindText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHazma = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref ToFindText,
                ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundLike,
                ref nmatchAllForms, ref forward,
                ref wrap, ref format, ref replaceWithText,
                ref replace, ref matchKashida,
                ref matchDiactitics, ref matchAlefHazma,
                ref matchControl);
        }

        private void CreateWord(object filename, object SaveAs)
        {
            Word.Application wordApp = new Word.Application();
            object missing = Missing.Value;
            Word.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                                    ref missing, ref missing, ref missing,
                                                    ref missing, ref missing, ref missing,
                                                    ref missing, ref missing, ref missing,
                                                    ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();

                this.FindAndReplace(wordApp, "<Firstname>", Convert.ToString(dgvCl[1, dgvCl.CurrentRow.Index].Value));
                this.FindAndReplace(wordApp, "<Secondname>", Convert.ToString(dgvCl[2, dgvCl.CurrentRow.Index].Value));
                this.FindAndReplace(wordApp, "<Middlename>", Convert.ToString(dgvCl[3, dgvCl.CurrentRow.Index].Value));
                this.FindAndReplace(wordApp, "<House_Adress>", Convert.ToString(dgvCl[4, dgvCl.CurrentRow.Index].Value));
                this.FindAndReplace(wordApp, "<Phone_Number>", Convert.ToString(dgvCl[5, dgvCl.CurrentRow.Index].Value));
                this.FindAndReplace(wordApp, "<Passport_Data>", Convert.ToString(dgvCl[6, dgvCl.CurrentRow.Index].Value));
                this.FindAndReplace(wordApp, "<Date_Of_Issue>", Convert.ToString(dgvCl[7, dgvCl.CurrentRow.Index].Value));
                this.FindAndReplace(wordApp, "<Return_Date>", Convert.ToString(dgvCl[8, dgvCl.CurrentRow.Index].Value));
                this.FindAndReplace(wordApp, "<Payment_Mark>", Convert.ToBoolean(dgvCl[9, dgvCl.CurrentRow.Index].Value));
                this.FindAndReplace(wordApp, "<Return_Mark>", Convert.ToBoolean(dgvCl[10, dgvCl.CurrentRow.Index].Value));
                this.FindAndReplace(wordApp, "<Cassette_ID_1>, <Cassette_ID_2>, <Cassette_ID_3>", Convert.ToString(dgvCl[11, dgvCl.CurrentRow.Index].Value));


            }
            else
            {
                MessageBox.Show("Файл не найден!");
            }

            myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing);

            myWordDoc.Close();
            wordApp.Quit();
            MessageBox.Show("Файл успешно создан!");
        }

        private void Clients_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_913_PR_PantyiukhovDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this._913_PR_PantyiukhovDataSet.Clients);
            load_data();

        }
    }
}
