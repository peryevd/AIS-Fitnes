namespace AIS_Fitnes
{
    partial class changeClients
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
            this.button2 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.middle_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.last_name = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.first_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.address = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.birth_date = new System.Windows.Forms.MaskedTextBox();
            this.phone = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(429, 351);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 26;
            this.add.Text = "Сохранить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "E-mail:";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(129, 58);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(336, 20);
            this.email.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Телефон:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Дата рождения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Отчество:";
            // 
            // middle_name
            // 
            this.middle_name.Location = new System.Drawing.Point(129, 82);
            this.middle_name.Name = "middle_name";
            this.middle_name.Size = new System.Drawing.Size(336, 20);
            this.middle_name.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Фамилия:";
            // 
            // last_name
            // 
            this.last_name.Location = new System.Drawing.Point(129, 30);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(336, 20);
            this.last_name.TabIndex = 16;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(21, 59);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(32, 13);
            this.label.TabIndex = 15;
            this.label.Text = "Имя:";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // first_name
            // 
            this.first_name.Location = new System.Drawing.Point(129, 56);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(336, 20);
            this.first_name.TabIndex = 14;
            this.first_name.TextChanged += new System.EventHandler(this.first_name_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Пол:";
            // 
            // sex
            // 
            this.sex.FormattingEnabled = true;
            this.sex.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.sex.Location = new System.Drawing.Point(344, 128);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(121, 21);
            this.sex.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.birth_date);
            this.groupBox1.Controls.Add(this.last_name);
            this.groupBox1.Controls.Add(this.first_name);
            this.groupBox1.Controls.Add(this.sex);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.middle_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 174);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Личные данные";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Controls.Add(this.phone);
            this.groupBox2.Controls.Add(this.address);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.email);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(15, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 135);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Контакты";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(129, 84);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(336, 20);
            this.address.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Адрес:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // birth_date
            // 
            this.birth_date.Location = new System.Drawing.Point(129, 129);
            this.birth_date.Mask = "00/00/0000";
            this.birth_date.Name = "birth_date";
            this.birth_date.Size = new System.Drawing.Size(60, 20);
            this.birth_date.TabIndex = 30;
            this.birth_date.ValidatingType = typeof(System.DateTime);
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(129, 29);
            this.phone.Mask = "0 (999) 000-00-00";
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(96, 20);
            this.phone.TabIndex = 31;
            // 
            // changeClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(513, 386);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.add);
            this.Name = "changeClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиент";
            this.Load += new System.EventHandler(this.changeClients_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox middle_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox last_name;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox first_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox sex;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox birth_date;
        private System.Windows.Forms.MaskedTextBox phone;
    }
}