namespace Videoteka
{
    partial class Clients
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
            this.BackB = new System.Windows.Forms.Button();
            this.dgvCl = new System.Windows.Forms.DataGridView();
            this.pRPantyiukhovDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._913_PR_PantyiukhovDataSet = new Videoteka._913_PR_PantyiukhovDataSet();
            this.AddB = new System.Windows.Forms.Button();
            this.EditB = new System.Windows.Forms.Button();
            this.DelB = new System.Windows.Forms.Button();
            this.labelCl = new System.Windows.Forms.Label();
            this.pRPantyiukhovDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.RefB = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middlenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfIssueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMarkDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.returnMarkDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cassetteID1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cassetteID2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cassetteID3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new Videoteka._913_PR_PantyiukhovDataSetTableAdapters.ClientsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRPantyiukhovDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._913_PR_PantyiukhovDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRPantyiukhovDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackB
            // 
            this.BackB.Location = new System.Drawing.Point(713, 12);
            this.BackB.Name = "BackB";
            this.BackB.Size = new System.Drawing.Size(75, 23);
            this.BackB.TabIndex = 1;
            this.BackB.Text = "Назад";
            this.BackB.UseVisualStyleBackColor = true;
            this.BackB.Click += new System.EventHandler(this.BackB_Click);
            // 
            // dgvCl
            // 
            this.dgvCl.AutoGenerateColumns = false;
            this.dgvCl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.secondnameDataGridViewTextBoxColumn,
            this.middlenameDataGridViewTextBoxColumn,
            this.houseAdressDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.passportDataDataGridViewTextBoxColumn,
            this.dateOfIssueDataGridViewTextBoxColumn,
            this.returnDateDataGridViewTextBoxColumn,
            this.paymentMarkDataGridViewCheckBoxColumn,
            this.returnMarkDataGridViewCheckBoxColumn,
            this.cassetteID1DataGridViewTextBoxColumn,
            this.cassetteID2DataGridViewTextBoxColumn,
            this.cassetteID3DataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn});
            this.dgvCl.DataSource = this.clientsBindingSource1;
            this.dgvCl.Location = new System.Drawing.Point(12, 59);
            this.dgvCl.Name = "dgvCl";
            this.dgvCl.Size = new System.Drawing.Size(776, 321);
            this.dgvCl.TabIndex = 2;
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
            this.EditB.Location = new System.Drawing.Point(182, 386);
            this.EditB.Name = "EditB";
            this.EditB.Size = new System.Drawing.Size(142, 51);
            this.EditB.TabIndex = 4;
            this.EditB.Text = "Изменить";
            this.EditB.UseVisualStyleBackColor = true;
            this.EditB.Click += new System.EventHandler(this.EditB_Click);
            // 
            // DelB
            // 
            this.DelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelB.Location = new System.Drawing.Point(355, 387);
            this.DelB.Name = "DelB";
            this.DelB.Size = new System.Drawing.Size(142, 51);
            this.DelB.TabIndex = 5;
            this.DelB.Text = "Удалить";
            this.DelB.UseVisualStyleBackColor = true;
            this.DelB.Click += new System.EventHandler(this.DelB_Click);
            // 
            // labelCl
            // 
            this.labelCl.AutoSize = true;
            this.labelCl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCl.Location = new System.Drawing.Point(333, 12);
            this.labelCl.Name = "labelCl";
            this.labelCl.Size = new System.Drawing.Size(88, 23);
            this.labelCl.TabIndex = 6;
            this.labelCl.Text = "Клиенты";
            // 
            // pRPantyiukhovDataSetBindingSource1
            // 
            this.pRPantyiukhovDataSetBindingSource1.DataSource = this._913_PR_PantyiukhovDataSet;
            this.pRPantyiukhovDataSetBindingSource1.Position = 0;
            // 
            // RefB
            // 
            this.RefB.Location = new System.Drawing.Point(13, 11);
            this.RefB.Name = "RefB";
            this.RefB.Size = new System.Drawing.Size(75, 23);
            this.RefB.TabIndex = 7;
            this.RefB.Text = "Обновить";
            this.RefB.UseVisualStyleBackColor = true;
            this.RefB.Click += new System.EventHandler(this.RefB_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(129, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "Фильтры клиентов";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(503, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Поиск:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(592, 402);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Экспорт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.pRPantyiukhovDataSetBindingSource;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // secondnameDataGridViewTextBoxColumn
            // 
            this.secondnameDataGridViewTextBoxColumn.DataPropertyName = "Secondname";
            this.secondnameDataGridViewTextBoxColumn.HeaderText = "Secondname";
            this.secondnameDataGridViewTextBoxColumn.Name = "secondnameDataGridViewTextBoxColumn";
            // 
            // middlenameDataGridViewTextBoxColumn
            // 
            this.middlenameDataGridViewTextBoxColumn.DataPropertyName = "Middlename";
            this.middlenameDataGridViewTextBoxColumn.HeaderText = "Middlename";
            this.middlenameDataGridViewTextBoxColumn.Name = "middlenameDataGridViewTextBoxColumn";
            // 
            // houseAdressDataGridViewTextBoxColumn
            // 
            this.houseAdressDataGridViewTextBoxColumn.DataPropertyName = "House_Adress";
            this.houseAdressDataGridViewTextBoxColumn.HeaderText = "House_Adress";
            this.houseAdressDataGridViewTextBoxColumn.Name = "houseAdressDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone_Number";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone_Number";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // passportDataDataGridViewTextBoxColumn
            // 
            this.passportDataDataGridViewTextBoxColumn.DataPropertyName = "Passport_Data";
            this.passportDataDataGridViewTextBoxColumn.HeaderText = "Passport_Data";
            this.passportDataDataGridViewTextBoxColumn.Name = "passportDataDataGridViewTextBoxColumn";
            // 
            // dateOfIssueDataGridViewTextBoxColumn
            // 
            this.dateOfIssueDataGridViewTextBoxColumn.DataPropertyName = "Date_Of_Issue";
            this.dateOfIssueDataGridViewTextBoxColumn.HeaderText = "Date_Of_Issue";
            this.dateOfIssueDataGridViewTextBoxColumn.Name = "dateOfIssueDataGridViewTextBoxColumn";
            // 
            // returnDateDataGridViewTextBoxColumn
            // 
            this.returnDateDataGridViewTextBoxColumn.DataPropertyName = "Return_Date";
            this.returnDateDataGridViewTextBoxColumn.HeaderText = "Return_Date";
            this.returnDateDataGridViewTextBoxColumn.Name = "returnDateDataGridViewTextBoxColumn";
            // 
            // paymentMarkDataGridViewCheckBoxColumn
            // 
            this.paymentMarkDataGridViewCheckBoxColumn.DataPropertyName = "Payment_Mark";
            this.paymentMarkDataGridViewCheckBoxColumn.HeaderText = "Payment_Mark";
            this.paymentMarkDataGridViewCheckBoxColumn.Name = "paymentMarkDataGridViewCheckBoxColumn";
            // 
            // returnMarkDataGridViewCheckBoxColumn
            // 
            this.returnMarkDataGridViewCheckBoxColumn.DataPropertyName = "Return_Mark";
            this.returnMarkDataGridViewCheckBoxColumn.HeaderText = "Return_Mark";
            this.returnMarkDataGridViewCheckBoxColumn.Name = "returnMarkDataGridViewCheckBoxColumn";
            // 
            // cassetteID1DataGridViewTextBoxColumn
            // 
            this.cassetteID1DataGridViewTextBoxColumn.DataPropertyName = "Cassette_ID_1";
            this.cassetteID1DataGridViewTextBoxColumn.HeaderText = "Cassette_ID_1";
            this.cassetteID1DataGridViewTextBoxColumn.Name = "cassetteID1DataGridViewTextBoxColumn";
            // 
            // cassetteID2DataGridViewTextBoxColumn
            // 
            this.cassetteID2DataGridViewTextBoxColumn.DataPropertyName = "Cassette_ID_2";
            this.cassetteID2DataGridViewTextBoxColumn.HeaderText = "Cassette_ID_2";
            this.cassetteID2DataGridViewTextBoxColumn.Name = "cassetteID2DataGridViewTextBoxColumn";
            // 
            // cassetteID3DataGridViewTextBoxColumn
            // 
            this.cassetteID3DataGridViewTextBoxColumn.DataPropertyName = "Cassette_ID_3";
            this.cassetteID3DataGridViewTextBoxColumn.HeaderText = "Cassette_ID_3";
            this.cassetteID3DataGridViewTextBoxColumn.Name = "cassetteID3DataGridViewTextBoxColumn";
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            // 
            // clientsBindingSource1
            // 
            this.clientsBindingSource1.DataMember = "Clients";
            this.clientsBindingSource1.DataSource = this.pRPantyiukhovDataSetBindingSource;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.RefB);
            this.Controls.Add(this.labelCl);
            this.Controls.Add(this.DelB);
            this.Controls.Add(this.EditB);
            this.Controls.Add(this.AddB);
            this.Controls.Add(this.dgvCl);
            this.Controls.Add(this.BackB);
            this.Name = "Clients";
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.Clients_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRPantyiukhovDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._913_PR_PantyiukhovDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRPantyiukhovDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackB;
        private System.Windows.Forms.DataGridView dgvCl;
        private System.Windows.Forms.Button DelB;
        private System.Windows.Forms.Label labelCl;
        public System.Windows.Forms.Button AddB;
        public System.Windows.Forms.Button EditB;
        private System.Windows.Forms.BindingSource pRPantyiukhovDataSetBindingSource;
        private _913_PR_PantyiukhovDataSet _913_PR_PantyiukhovDataSet;
        private System.Windows.Forms.BindingSource pRPantyiukhovDataSetBindingSource1;
        private System.Windows.Forms.Button RefB;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middlenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfIssueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn paymentMarkDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn returnMarkDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cassetteID1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cassetteID2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cassetteID3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private System.Windows.Forms.BindingSource clientsBindingSource1;
        private _913_PR_PantyiukhovDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
    }
}