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
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;
using System.IO;

namespace Videoteka
{
    public partial class Cassettes : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=169.254.131.3;Initial Catalog=913-PR-Pantyiukhov;Persist Security Info=True;User ID=stud1;Password=Student1$$");
        public Cassettes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddCassettes f = new AddCassettes();
            f.Text = "Изменить данные о кассете";
            f.label1.Text = "Изменить данные о кассете";
            f.AddB.Text = "Изменить";
            f.FNTB.Text = Convert.ToString(dataGridView1[1, dataGridView1.CurrentRow.Index].Value);
            f.CYTB.Text = Convert.ToString(dataGridView1[2, dataGridView1.CurrentRow.Index].Value);
            f.ProdTB.Text = Convert.ToString(dataGridView1[3, dataGridView1.CurrentRow.Index].Value);
            f.CCTB.Text = Convert.ToString(dataGridView1[4, dataGridView1.CurrentRow.Index].Value);
            f.MATB.Text = Convert.ToString(dataGridView1[5, dataGridView1.CurrentRow.Index].Value);
            f.RDTB.Text = Convert.ToString(dataGridView1[6, dataGridView1.CurrentRow.Index].Value);
            f.IDGTB.Text = Convert.ToString(dataGridView1[7, dataGridView1.CurrentRow.Index].Value);
            f.PriceTB.Text = Convert.ToString(dataGridView1[8, dataGridView1.CurrentRow.Index].Value);
            if (f.ShowDialog() == DialogResult.OK)
            {
                SqlDataAdapter yes = new SqlDataAdapter("update [Cassettes] set [Film_Name] = '" + f.FNTB.Text + "', [Creation_Year] = '" + f.CYTB.Text + "', [Producer] = '" + f.ProdTB.Text + "', [Country] = '" + f.CCTB.Text + "', [Main_Actors] = '" + f.MATB.Text + "', [Record_Date] = '" + f.RDTB.Text + "', [Genre_ID] = '" + f.IDGTB.Text + "', [Price] = '" + f.PriceTB.Text + "' where Cassette_ID =" + Convert.ToString(dataGridView1[0, dataGridView1.CurrentRow.Index].Value), con);
                DataTable dt = new DataTable();
                yes.Fill(dt);
                dataGridView1.DataSource = yes;
                Cassettes_Load(sender, e);
                MessageBox.Show("Данные изменены");
            }
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            AddCassettes f = new AddCassettes();
            f.Text = "Добавить новую кассету";
            if (f.ShowDialog() == DialogResult.OK)
            {
                SqlDataAdapter yes = new SqlDataAdapter("insert into [Cassettes] ([Film_Name], [Creation_Year], [Producer], [Country], [Main_Actors], [Record_Date], [Genre_ID], [Price]) values ('" + f.FNTB.Text + "', '" + f.CYTB.Text + "', '" + f.ProdTB.Text + "', '" + f.CCTB.Text + "', '" + f.MATB.Text + "', '" + f.RDTB.Text + "', '" + f.IDGTB.Text + "', '" + f.PriceTB.Text + "')", con);
                DataTable dt = new DataTable();
                yes.Fill(dt);
                dataGridView1.DataSource = yes;
                Cassettes_Load(sender, e);
                MessageBox.Show("Данные добавлены");
            }
        }

        private void BackB_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void load_data()
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT*FROM [Cassettes]", con);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            dataGridView1.DataSource = data;
        }

        private void Cassettes_Load(object sender, EventArgs e)
        {
            
        }

        private void DelB_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select Cassette_ID from [Cassettes] Where [Cassette_ID]=" + Convert.ToString(dataGridView1[0, dataGridView1.CurrentRow.Index].Value), con);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;

            DialogResult result = MessageBox.Show("Действительно удалить?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                SqlDataAdapter da = new SqlDataAdapter("delete from [Cassettes] where [Cassette_ID] = " + Convert.ToString(dataGridView1[0, dataGridView1.CurrentRow.Index].Value), con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = da;
                load_data();

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        SqlDataAdapter uno = new SqlDataAdapter("SELECT Cassettes.Film_Name, Cassettes.Creation_Year, Cassettes.Producer, Cassettes.Country, Genres.Genre_Name From Cassettes JOIN Genres ON Cassettes.Genre_ID=Genres.Genre_ID WHERE Genres.Genre_Name='Биографический'", con);
                        DataSet dos = new DataSet();
                        uno.Fill(dos);
                        dataGridView1.DataSource = dos.Tables[0];
                        break;
                    }
                case 1:
                    {
                        SqlDataAdapter uno = new SqlDataAdapter("SELECT Cassettes.Film_Name, Cassettes.Creation_Year, Cassettes.Producer, Cassettes.Country, Genres.Genre_Name From Cassettes JOIN Genres ON Cassettes.Genre_ID=Genres.Genre_ID WHERE Genres.Genre_Name='Боевик'", con);
                        DataSet dos = new DataSet();
                        uno.Fill(dos);
                        dataGridView1.DataSource = dos.Tables[0];
                        break;
                    }
                case 2:
                    {
                        SqlDataAdapter uno = new SqlDataAdapter("SELECT Cassettes.Film_Name, Cassettes.Creation_Year, Cassettes.Producer, Cassettes.Country, Genres.Genre_Name From Cassettes JOIN Genres ON Cassettes.Genre_ID=Genres.Genre_ID WHERE Genres.Genre_Name='Драма'", con);
                        DataSet dos = new DataSet();
                        uno.Fill(dos);
                        dataGridView1.DataSource = dos.Tables[0];
                        break;
                    }
                case 3:
                    {
                        SqlDataAdapter uno = new SqlDataAdapter("SELECT Cassettes.Film_Name, Cassettes.Creation_Year, Cassettes.Producer, Cassettes.Country, Genres.Genre_Name From Cassettes JOIN Genres ON Cassettes.Genre_ID=Genres.Genre_ID WHERE Genres.Genre_Name='Комедия'", con);
                        DataSet dos = new DataSet();
                        uno.Fill(dos);
                        dataGridView1.DataSource = dos.Tables[0];
                        break;
                    }
                case 4:
                    {
                        SqlDataAdapter uno = new SqlDataAdapter("SELECT Cassettes.Film_Name, Cassettes.Creation_Year, Cassettes.Producer, Cassettes.Country, Genres.Genre_Name From Cassettes JOIN Genres ON Cassettes.Genre_ID=Genres.Genre_ID WHERE Genres.Genre_Name='Триллер'", con);
                        DataSet dos = new DataSet();
                        uno.Fill(dos);
                        dataGridView1.DataSource = dos.Tables[0];
                        break;
                    }
            }
        }

        private void RefB_Click(object sender, EventArgs e)
        {
            load_data();
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
            CreateWord(@"D:\Курсач\Приложение\Videoteka\Videoteka\ЭкспортКассеты.docx", @"D:\Курсач\Приложение\Videoteka\ЭкспортКассеты.docx");
        }
        
        private void FindAndReplace (Word.Application wordApp, object ToFindText, object replaceWithText)
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

        private void CreateWord (object filename, object SaveAs)
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

                this.FindAndReplace(wordApp, "<Film_Name>", Convert.ToString(dataGridView1[1, dataGridView1.CurrentRow.Index].Value));
                this.FindAndReplace(wordApp, "<Creation_Year>", Convert.ToString(dataGridView1[2, dataGridView1.CurrentRow.Index].Value));
                this.FindAndReplace(wordApp, "<Producer>", Convert.ToString(dataGridView1[3, dataGridView1.CurrentRow.Index].Value));
                this.FindAndReplace(wordApp, "<Creation_Country>", Convert.ToString(dataGridView1[4, dataGridView1.CurrentRow.Index].Value));
                this.FindAndReplace(wordApp, "<Main_Actors>", Convert.ToString(dataGridView1[5, dataGridView1.CurrentRow.Index].Value));
                this.FindAndReplace(wordApp, "<Record_Date>", Convert.ToString(dataGridView1[6, dataGridView1.CurrentRow.Index].Value));
                this.FindAndReplace(wordApp, "<Genre_ID>", Convert.ToString(dataGridView1[7, dataGridView1.CurrentRow.Index].Value));
                this.FindAndReplace(wordApp, "<Price>", Convert.ToString(dataGridView1[8, dataGridView1.CurrentRow.Index].Value));
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

        private void Cassettes_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_913_PR_PantyiukhovDataSet.Cassettes". При необходимости она может быть перемещена или удалена.
            this.cassettesTableAdapter.Fill(this._913_PR_PantyiukhovDataSet.Cassettes);
            load_data();

        }
    }
}
