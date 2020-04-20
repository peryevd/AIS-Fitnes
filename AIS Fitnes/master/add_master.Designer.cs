namespace AIS_Fitnes
{
    partial class add_master
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
            this.phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.birth_date = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.middle_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.last_name = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.first_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(215, 184);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 26;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "E-mail";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(116, 142);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(173, 20);
            this.email.TabIndex = 24;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Телефон";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(117, 116);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(173, 20);
            this.phone.TabIndex = 22;
            this.phone.TextChanged += new System.EventHandler(this.phone_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Дата рождения";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // birth_date
            // 
            this.birth_date.Location = new System.Drawing.Point(117, 90);
            this.birth_date.Name = "birth_date";
            this.birth_date.Size = new System.Drawing.Size(173, 20);
            this.birth_date.TabIndex = 20;
            this.birth_date.TextChanged += new System.EventHandler(this.birth_date_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Отчество";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // middle_name
            // 
            this.middle_name.Location = new System.Drawing.Point(116, 64);
            this.middle_name.Name = "middle_name";
            this.middle_name.Size = new System.Drawing.Size(173, 20);
            this.middle_name.TabIndex = 18;
            this.middle_name.TextChanged += new System.EventHandler(this.middle_name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Фамилия";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // last_name
            // 
            this.last_name.Location = new System.Drawing.Point(117, 38);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(173, 20);
            this.last_name.TabIndex = 16;
            this.last_name.TextChanged += new System.EventHandler(this.last_name_TextChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(9, 19);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(29, 13);
            this.label.TabIndex = 15;
            this.label.Text = "Имя";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // first_name
            // 
            this.first_name.Location = new System.Drawing.Point(117, 12);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(173, 20);
            this.first_name.TabIndex = 14;
            this.first_name.TextChanged += new System.EventHandler(this.first_name_TextChanged);
            // 
            // add_master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 222);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.birth_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.middle_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.label);
            this.Controls.Add(this.first_name);
            this.Name = "add_master";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить тренера";
            this.Load += new System.EventHandler(this.add_master_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox birth_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox middle_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox last_name;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox first_name;
    }
}