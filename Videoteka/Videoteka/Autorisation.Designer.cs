
namespace Videoteka
{
    partial class Autorisation
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autorisation));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Label();
            this.text_login = new System.Windows.Forms.TextBox();
            this.psswrd = new System.Windows.Forms.Label();
            this.text_psswrd = new System.Windows.Forms.TextBox();
            this.but_login = new System.Windows.Forms.Button();
            this.but_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(258, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(302, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Авторизация";
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(268, 313);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(71, 23);
            this.Login.TabIndex = 2;
            this.Login.Text = "Логин:";
            // 
            // text_login
            // 
            this.text_login.Location = new System.Drawing.Point(363, 313);
            this.text_login.Name = "text_login";
            this.text_login.Size = new System.Drawing.Size(151, 20);
            this.text_login.TabIndex = 3;
            // 
            // psswrd
            // 
            this.psswrd.AutoSize = true;
            this.psswrd.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.psswrd.Location = new System.Drawing.Point(258, 351);
            this.psswrd.Name = "psswrd";
            this.psswrd.Size = new System.Drawing.Size(81, 23);
            this.psswrd.TabIndex = 4;
            this.psswrd.Text = "Пароль:";
            // 
            // text_psswrd
            // 
            this.text_psswrd.Location = new System.Drawing.Point(363, 351);
            this.text_psswrd.Name = "text_psswrd";
            this.text_psswrd.Size = new System.Drawing.Size(151, 20);
            this.text_psswrd.TabIndex = 5;
            this.text_psswrd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // but_login
            // 
            this.but_login.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_login.Location = new System.Drawing.Point(272, 393);
            this.but_login.Name = "but_login";
            this.but_login.Size = new System.Drawing.Size(104, 45);
            this.but_login.TabIndex = 6;
            this.but_login.Text = "Войти";
            this.but_login.UseVisualStyleBackColor = true;
            this.but_login.Click += new System.EventHandler(this.but_login_Click);
            // 
            // but_exit
            // 
            this.but_exit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_exit.Location = new System.Drawing.Point(410, 393);
            this.but_exit.Name = "but_exit";
            this.but_exit.Size = new System.Drawing.Size(104, 45);
            this.but_exit.TabIndex = 7;
            this.but_exit.Text = "Закрыть";
            this.but_exit.UseVisualStyleBackColor = true;
            this.but_exit.Click += new System.EventHandler(this.but_exit_Click);
            // 
            // Autorisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.but_exit);
            this.Controls.Add(this.but_login);
            this.Controls.Add(this.text_psswrd);
            this.Controls.Add(this.psswrd);
            this.Controls.Add(this.text_login);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Autorisation";
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label psswrd;
        private System.Windows.Forms.Button but_login;
        private System.Windows.Forms.Button but_exit;
        public System.Windows.Forms.TextBox text_login;
        public System.Windows.Forms.TextBox text_psswrd;
    }
}

