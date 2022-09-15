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

    public partial class Employees : Form
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=169.254.131.3;Initial Catalog=913-PR-Pantyiukhov;User ID=stud1;Password=Student1$$");
        public Employees()
        {
            InitializeComponent();
        }

        private void BackB_Click(object sender, EventArgs e)
        {            
            this.Hide();           
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            AddEmployee f = new AddEmployee();
            f.Text = "Добавить нового сотрудника";
            if (f.ShowDialog() == DialogResult.OK)
            {
                SqlDataAdapter yes = new SqlDataAdapter("insert into [Employees] ([Lastname], [Firstname], [Middlename], [Age], [Gender], [Phone_Number], [Passport_Data], [Position_ID]) values ('" + f.SNTB.Text + "', '" + f.FNTB.Text + "', '" + f.MNTB.Text + "', '" + f.ATB.Text + "', '" + f.GTB.Text + "', '" + f.PNTB.Text + "', '" + f.PDTB.Text + "', '" + f.IDPTB.Text + "')", con);
                DataTable dt = new DataTable();
                yes.Fill(dt);
                dataGridView1.DataSource = yes;
                Сотрудники_Load(sender, e);
                MessageBox.Show("Данные добавлены");
            }
        }

        void load_data()
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT*FROM [Employees]", con);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            dataGridView1.DataSource = data;
        }

        private void Сотрудники_Load(object sender, EventArgs e)
        {
            
        }

        private void EditB_Click(object sender, EventArgs e)
        {
            AddEmployee f = new AddEmployee();
            f.Text = "Изменить данные о сотруднике";
            f.label1.Text = "Изменить данные о сотруднике";
            f.AddB.Text = "Изменить";
            f.SNTB.Text = Convert.ToString(dataGridView1[1, dataGridView1.CurrentRow.Index].Value);
            f.FNTB.Text = Convert.ToString(dataGridView1[2, dataGridView1.CurrentRow.Index].Value);
            f.MNTB.Text = Convert.ToString(dataGridView1[3, dataGridView1.CurrentRow.Index].Value);
            f.ATB.Text = Convert.ToString(dataGridView1[4, dataGridView1.CurrentRow.Index].Value);
            f.GTB.Text = Convert.ToString(dataGridView1[5, dataGridView1.CurrentRow.Index].Value);
            f.PNTB.Text = Convert.ToString(dataGridView1[6, dataGridView1.CurrentRow.Index].Value);
            f.PDTB.Text = Convert.ToString(dataGridView1[7, dataGridView1.CurrentRow.Index].Value);
            f.IDPTB.Text = Convert.ToString(dataGridView1[8, dataGridView1.CurrentRow.Index].Value);
            if (f.ShowDialog() == DialogResult.OK)
            {
                SqlDataAdapter yes = new SqlDataAdapter("update [Employees] set [Lastname] = '" + f.SNTB.Text + "', [Firstname] = '" + f.FNTB.Text + "', [Middlename] = '" + f.MNTB.Text + "', [Age] = '" + f.ATB.Text + "', [Gender] = '" + f.GTB.Text + "', [Phone_Number] = '" + f.PNTB.Text + "', [Passport_Data] = '" + f.PDTB.Text + "', [Position_ID] = '" + f.IDPTB.Text + "' where Employee_ID =" + Convert.ToString(dataGridView1[0, dataGridView1.CurrentRow.Index].Value), con);
                DataTable dt = new DataTable();
                yes.Fill(dt);
                dataGridView1.DataSource = yes;
                Сотрудники_Load(sender, e);
                MessageBox.Show("Данные изменены");
            }
        }

        private void DelB_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select Employee_ID from [Employees] Where [Employee_ID]=" + Convert.ToString(dataGridView1[0, dataGridView1.CurrentRow.Index].Value), con);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;

            DialogResult result = MessageBox.Show("Действительно удалить?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (result == DialogResult.Yes)
            {
                SqlDataAdapter da = new SqlDataAdapter("delete from [Employees] where [Employee_ID] = " + Convert.ToString(dataGridView1[0, dataGridView1.CurrentRow.Index].Value), con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = da;
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
                        SqlDataAdapter uno = new SqlDataAdapter("SELECT Employees.Employee_ID, Employees.Lastname, Employees.Firstname, Employees.Middlename, Employees.Age, Employees.Gender, Employees.Phone_Number, Employees.Passport_Data, Positions.Position_ID, Positions.Position_Name, Positions.Salary From Employees JOIN Positions ON Employees.Position_ID = Positions.Position_ID WHERE Positions.Position_Name='Менеджер-кассир '", con);
                        DataSet dos = new DataSet();
                        uno.Fill(dos);
                        dataGridView1.DataSource = dos.Tables[0];
                        break;
                    }
                case 1:
                    {
                        SqlDataAdapter uno = new SqlDataAdapter("SELECT Employees.Employee_ID, Employees.Lastname, Employees.Firstname, Employees.Middlename, Employees.Age, Employees.Gender, Employees.Phone_Number, Employees.Passport_Data, Positions.Position_ID, Positions.Position_Name, Positions.Salary From Employees JOIN Positions ON Employees.Position_ID = Positions.Position_ID WHERE Positions.Position_Name='Складской работник'", con);
                        DataSet dos = new DataSet();
                        uno.Fill(dos);
                        dataGridView1.DataSource = dos.Tables[0];
                        break;
                    }
                case 2:
                    {
                        SqlDataAdapter uno = new SqlDataAdapter("SELECT Employees.Employee_ID, Employees.Lastname, Employees.Firstname, Employees.Middlename, Employees.Age, Employees.Gender, Employees.Phone_Number, Employees.Passport_Data, Positions.Position_ID, Positions.Position_Name, Positions.Salary From Employees JOIN Positions ON Employees.Position_ID = Positions.Position_ID WHERE Positions.Position_Name='Бухгалтер '", con);
                        DataSet dos = new DataSet();
                        uno.Fill(dos);
                        dataGridView1.DataSource = dos.Tables[0];
                        break;
                    }
                case 3:
                    {
                        SqlDataAdapter uno = new SqlDataAdapter("SELECT Employees.Employee_ID, Employees.Lastname, Employees.Firstname, Employees.Middlename, Employees.Age, Employees.Gender, Employees.Phone_Number, Employees.Passport_Data, Positions.Position_ID, Positions.Position_Name, Positions.Salary From Employees JOIN Positions ON Employees.Position_ID = Positions.Position_ID WHERE Positions.Position_Name='Программист'", con);
                        DataSet dos = new DataSet();
                        uno.Fill(dos);
                        dataGridView1.DataSource = dos.Tables[0];
                        break;
                    }
                case 4:
                    {
                        SqlDataAdapter uno = new SqlDataAdapter("SELECT Employees.Employee_ID, Employees.Lastname, Employees.Firstname, Employees.Middlename, Employees.Age, Employees.Gender, Employees.Phone_Number, Employees.Passport_Data, Positions.Position_ID, Positions.Position_Name, Positions.Salary From Employees JOIN Positions ON Employees.Position_ID = Positions.Position_ID WHERE Positions.Position_Name='Уборщик'", con);
                        DataSet dos = new DataSet();
                        uno.Fill(dos);
                        dataGridView1.DataSource = dos.Tables[0];
                        break;
                    }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                    {
                        if (textBox1.Text != " " || textBox1.Text != String.Empty)
                        {
                            if (dataGridView1.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBox1.Text.ToLower()))
                            {
                                if (!dataGridView1.Rows[i].Visible)
                                {
                                    dataGridView1.Rows[i].Visible = true;
                                }
                                dataGridView1.Rows[i].Selected = true;
                                break;
                            }
                        }
                    }
            }
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Selected != true)
                {
                    dataGridView1.CurrentCell = null;
                    if (dataGridView1.Rows[i].Cells[0].Value != null)
                    {

                        dataGridView1.Rows[i].Visible = false;
                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateWord(@"D:\Курсач\Приложение\Videoteka\Videoteka\ЭкспортСотрудники.docx", @"D:\Курсач\Приложение\Videoteka\ЭкспортСотрудники.docx");
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

                this.FindAndReplace(wordApp, "<Lastname>", Convert.ToString(dataGridView1[1, dataGridView1.CurrentRow.Index].Value));
                this.FindAndReplace(wordApp, "<Firstname>", Convert.ToString(dataGridView1[2, dataGridView1.CurrentRow.Index].Value));
                this.FindAndReplace(wordApp, "<Middlename>", Convert.ToString(dataGridView1[3, dataGridView1.CurrentRow.Index].Value));
                this.FindAndReplace(wordApp, "<Age>", Convert.ToString(dataGridView1[4, dataGridView1.CurrentRow.Index].Value));
                this.FindAndReplace(wordApp, "<Gender>", Convert.ToString(dataGridView1[5, dataGridView1.CurrentRow.Index].Value));
                this.FindAndReplace(wordApp, "<Phone_Number>", Convert.ToString(dataGridView1[6, dataGridView1.CurrentRow.Index].Value));
                this.FindAndReplace(wordApp, "<Passport_Data>", Convert.ToString(dataGridView1[7, dataGridView1.CurrentRow.Index].Value));
                this.FindAndReplace(wordApp, "<Position_ID>", Convert.ToString(dataGridView1[8, dataGridView1.CurrentRow.Index].Value));
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

        private void Employees_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_913_PR_PantyiukhovDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this._913_PR_PantyiukhovDataSet.Employees);
            load_data();

        }
    }
}
