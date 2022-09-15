
namespace Videoteka
{
    partial class Cassettes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.BackB = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pRPantyiukhovDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._913_PR_PantyiukhovDataSet = new Videoteka._913_PR_PantyiukhovDataSet();
            this.AddB = new System.Windows.Forms.Button();
            this.EditB = new System.Windows.Forms.Button();
            this.DelB = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.RefB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ExportB = new System.Windows.Forms.Button();
            this.cassettesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cassetteIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainActorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cassettesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cassettesTableAdapter = new Videoteka._913_PR_PantyiukhovDataSetTableAdapters.CassettesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRPantyiukhovDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._913_PR_PantyiukhovDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cassettesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cassettesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(381, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кассеты";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BackB
            // 
            this.BackB.Location = new System.Drawing.Point(748, 11);
            this.BackB.Name = "BackB";
            this.BackB.Size = new System.Drawing.Size(75, 23);
            this.BackB.TabIndex = 1;
            this.BackB.Text = "Назад";
            this.BackB.UseVisualStyleBackColor = true;
            this.BackB.Click += new System.EventHandler(this.BackB_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cassetteIDDataGridViewTextBoxColumn,
            this.filmNameDataGridViewTextBoxColumn,
            this.creationYearDataGridViewTextBoxColumn,
            this.producerDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.mainActorsDataGridViewTextBoxColumn,
            this.recordDateDataGridViewTextBoxColumn,
            this.genreIDDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cassettesBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(811, 337);
            this.dataGridView1.TabIndex = 2;
            // 
            // pRPantyiukhovDataSetBindingSource
            // 
            this.pRPantyiukhovDataSetBindingSource.DataSource = this._913_PR_PantyiukhovDataSet;
            this.pRPantyiukhovDataSetBindingSource.Position = 0;
            // 
            // _913_PR_PantyiukhovDataSet
            // 
            this._913_PR_PantyiukhovDataSet.DataSetName = "_913_PR_PantyiukhovDataSet";
            this._913_PR_PantyiukhovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddB
            // 
            this.AddB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddB.Location = new System.Drawing.Point(12, 387);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(142, 51);
            this.AddB.TabIndex = 3;
            this.AddB.Text = "Добавить";
            this.AddB.UseVisualStyleBackColor = true;
            this.AddB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // EditB
            // 
            this.EditB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditB.Location = new System.Drawing.Point(185, 387);
            this.EditB.Name = "EditB";
            this.EditB.Size = new System.Drawing.Size(142, 51);
            this.EditB.TabIndex = 4;
            this.EditB.Text = "Изменить";
            this.EditB.UseVisualStyleBackColor = true;
            this.EditB.Click += new System.EventHandler(this.button2_Click);
            // 
            // DelB
            // 
            this.DelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelB.Location = new System.Drawing.Point(361, 387);
            this.DelB.Name = "DelB";
            this.DelB.Size = new System.Drawing.Size(142, 51);
            this.DelB.TabIndex = 5;
            this.DelB.Text = "Удалить";
            this.DelB.UseVisualStyleBackColor = true;
            this.DelB.Click += new System.EventHandler(this.DelB_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Биографический",
            "Боевик",
            "Драма",
            "Комедия",
            "Триллер"});
            this.comboBox1.Location = new System.Drawing.Point(130, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Выбрать жанр";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // RefB
            // 
            this.RefB.Location = new System.Drawing.Point(12, 11);
            this.RefB.Name = "RefB";
            this.RefB.Size = new System.Drawing.Size(75, 23);
            this.RefB.TabIndex = 7;
            this.RefB.Text = "Обновить";
            this.RefB.UseVisualStyleBackColor = true;
            this.RefB.Click += new System.EventHandler(this.RefB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(516, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Поиск:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(591, 402);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ExportB
            // 
            this.ExportB.Location = new System.Drawing.Point(748, 400);
            this.ExportB.Name = "ExportB";
            this.ExportB.Size = new System.Drawing.Size(75, 23);
            this.ExportB.TabIndex = 10;
            this.ExportB.Text = "Экспорт";
            this.ExportB.UseVisualStyleBackColor = true;
            this.ExportB.Click += new System.EventHandler(this.button1_Click);
            // 
            // cassettesBindingSource
            // 
            this.cassettesBindingSource.DataMember = "Cassettes";
            this.cassettesBindingSource.DataSource = this.pRPantyiukhovDataSetBindingSource;
            // 
            // cassetteIDDataGridViewTextBoxColumn
            // 
            this.cassetteIDDataGridViewTextBoxColumn.DataPropertyName = "Cassette_ID";
            this.cassetteIDDataGridViewTextBoxColumn.HeaderText = "Cassette_ID";
            this.cassetteIDDataGridViewTextBoxColumn.Name = "cassetteIDDataGridViewTextBoxColumn";
            // 
            // filmNameDataGridViewTextBoxColumn
            // 
            this.filmNameDataGridViewTextBoxColumn.DataPropertyName = "Film_Name";
            this.filmNameDataGridViewTextBoxColumn.HeaderText = "Film_Name";
            this.filmNameDataGridViewTextBoxColumn.Name = "filmNameDataGridViewTextBoxColumn";
            // 
            // creationYearDataGridViewTextBoxColumn
            // 
            this.creationYearDataGridViewTextBoxColumn.DataPropertyName = "Creation_Year";
            this.creationYearDataGridViewTextBoxColumn.HeaderText = "Creation_Year";
            this.creationYearDataGridViewTextBoxColumn.Name = "creationYearDataGridViewTextBoxColumn";
            // 
            // producerDataGridViewTextBoxColumn
            // 
            this.producerDataGridViewTextBoxColumn.DataPropertyName = "Producer";
            this.producerDataGridViewTextBoxColumn.HeaderText = "Producer";
            this.producerDataGridViewTextBoxColumn.Name = "producerDataGridViewTextBoxColumn";
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // mainActorsDataGridViewTextBoxColumn
            // 
            this.mainActorsDataGridViewTextBoxColumn.DataPropertyName = "Main_Actors";
            this.mainActorsDataGridViewTextBoxColumn.HeaderText = "Main_Actors";
            this.mainActorsDataGridViewTextBoxColumn.Name = "mainActorsDataGridViewTextBoxColumn";
            // 
            // recordDateDataGridViewTextBoxColumn
            // 
            this.recordDateDataGridViewTextBoxColumn.DataPropertyName = "Record_Date";
            this.recordDateDataGridViewTextBoxColumn.HeaderText = "Record_Date";
            this.recordDateDataGridViewTextBoxColumn.Name = "recordDateDataGridViewTextBoxColumn";
            // 
            // genreIDDataGridViewTextBoxColumn
            // 
            this.genreIDDataGridViewTextBoxColumn.DataPropertyName = "Genre_ID";
            this.genreIDDataGridViewTextBoxColumn.HeaderText = "Genre_ID";
            this.genreIDDataGridViewTextBoxColumn.Name = "genreIDDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // cassettesBindingSource1
            // 
            this.cassettesBindingSource1.DataMember = "Cassettes";
            this.cassettesBindingSource1.DataSource = this.pRPantyiukhovDataSetBindingSource;
            // 
            // cassettesTableAdapter
            // 
            this.cassettesTableAdapter.ClearBeforeFill = true;
            // 
            // Cassettes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 451);
            this.Controls.Add(this.ExportB);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RefB);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.DelB);
            this.Controls.Add(this.EditB);
            this.Controls.Add(this.AddB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BackB);
            this.Controls.Add(this.label1);
            this.Name = "Cassettes";
            this.Text = "Кассеты";
            this.Load += new System.EventHandler(this.Cassettes_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRPantyiukhovDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._913_PR_PantyiukhovDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cassettesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cassettesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddB;
        private System.Windows.Forms.Button EditB;
        private System.Windows.Forms.Button DelB;
        private System.Windows.Forms.BindingSource pRPantyiukhovDataSetBindingSource;
        private _913_PR_PantyiukhovDataSet _913_PR_PantyiukhovDataSet;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button RefB;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ExportB;
        private System.Windows.Forms.DataGridViewTextBoxColumn cassetteIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainActorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cassettesBindingSource;
        private System.Windows.Forms.BindingSource cassettesBindingSource1;
        private _913_PR_PantyiukhovDataSetTableAdapters.CassettesTableAdapter cassettesTableAdapter;
    }
}