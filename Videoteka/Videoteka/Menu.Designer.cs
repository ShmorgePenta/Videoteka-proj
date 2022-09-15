
namespace Videoteka
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.menu_logout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Menu_exit = new System.Windows.Forms.Button();
            this.menu_cas = new System.Windows.Forms.Label();
            this.menu_cl = new System.Windows.Forms.Label();
            this.menu_empl = new System.Windows.Forms.Label();
            this.wellcum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Видеотека";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menu_logout
            // 
            this.menu_logout.Location = new System.Drawing.Point(628, 24);
            this.menu_logout.Name = "menu_logout";
            this.menu_logout.Size = new System.Drawing.Size(143, 23);
            this.menu_logout.TabIndex = 1;
            this.menu_logout.Text = "Сменить пользователя";
            this.menu_logout.UseVisualStyleBackColor = true;
            this.menu_logout.Click += new System.EventHandler(this.menu_logout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(287, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(49, 133);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(196, 194);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(297, 133);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(196, 194);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(573, 133);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(196, 194);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Menu_exit
            // 
            this.Menu_exit.Location = new System.Drawing.Point(360, 391);
            this.Menu_exit.Name = "Menu_exit";
            this.Menu_exit.Size = new System.Drawing.Size(75, 23);
            this.Menu_exit.TabIndex = 6;
            this.Menu_exit.Text = "Закрыть";
            this.Menu_exit.UseVisualStyleBackColor = true;
            this.Menu_exit.Click += new System.EventHandler(this.Menu_exit_Click);
            // 
            // menu_cas
            // 
            this.menu_cas.AutoSize = true;
            this.menu_cas.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menu_cas.Location = new System.Drawing.Point(107, 334);
            this.menu_cas.Name = "menu_cas";
            this.menu_cas.Size = new System.Drawing.Size(78, 21);
            this.menu_cas.TabIndex = 7;
            this.menu_cas.Text = "Кассеты";
            // 
            // menu_cl
            // 
            this.menu_cl.AutoSize = true;
            this.menu_cl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menu_cl.Location = new System.Drawing.Point(354, 334);
            this.menu_cl.Name = "menu_cl";
            this.menu_cl.Size = new System.Drawing.Size(81, 21);
            this.menu_cl.TabIndex = 8;
            this.menu_cl.Text = "Клиенты";
            // 
            // menu_empl
            // 
            this.menu_empl.AutoSize = true;
            this.menu_empl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menu_empl.Location = new System.Drawing.Point(624, 334);
            this.menu_empl.Name = "menu_empl";
            this.menu_empl.Size = new System.Drawing.Size(108, 21);
            this.menu_empl.TabIndex = 9;
            this.menu_empl.Text = "Сотрудники";
            // 
            // wellcum
            // 
            this.wellcum.AutoSize = true;
            this.wellcum.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wellcum.Location = new System.Drawing.Point(309, 98);
            this.wellcum.Name = "wellcum";
            this.wellcum.Size = new System.Drawing.Size(168, 21);
            this.wellcum.TabIndex = 10;
            this.wellcum.Text = "Добро пожаловать!";
            this.wellcum.Click += new System.EventHandler(this.label2_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wellcum);
            this.Controls.Add(this.menu_empl);
            this.Controls.Add(this.menu_cl);
            this.Controls.Add(this.menu_cas);
            this.Controls.Add(this.Menu_exit);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menu_logout);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button menu_logout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Menu_exit;
        private System.Windows.Forms.Label menu_cas;
        private System.Windows.Forms.Label menu_cl;
        private System.Windows.Forms.Label menu_empl;
        private System.Windows.Forms.Label wellcum;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.PictureBox pictureBox4;
    }
}