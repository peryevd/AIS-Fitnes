﻿namespace AIS_Fitnes
{
    partial class addClient
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
            this.first_name = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.last_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.middle_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.birth_date = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // first_name
            // 
            this.first_name.Location = new System.Drawing.Point(120, 6);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(173, 20);
            this.first_name.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 13);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(29, 13);
            this.label.TabIndex = 1;
            this.label.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Фамилия";
            // 
            // last_name
            // 
            this.last_name.Location = new System.Drawing.Point(120, 32);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(173, 20);
            this.last_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Отчество";
            // 
            // middle_name
            // 
            this.middle_name.Location = new System.Drawing.Point(119, 58);
            this.middle_name.Name = "middle_name";
            this.middle_name.Size = new System.Drawing.Size(173, 20);
            this.middle_name.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дата рождения";
            // 
            // birth_date
            // 
            this.birth_date.Location = new System.Drawing.Point(120, 84);
            this.birth_date.Name = "birth_date";
            this.birth_date.Size = new System.Drawing.Size(173, 20);
            this.birth_date.TabIndex = 6;
            this.birth_date.MouseEnter += new System.EventHandler(this.birth_date_MouseEnter);
            this.birth_date.MouseLeave += new System.EventHandler(this.birth_date_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Телефон";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(120, 110);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(173, 20);
            this.phone.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "E-mail";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(119, 136);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(173, 20);
            this.email.TabIndex = 10;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(218, 178);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 12;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 226);
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
            this.Name = "addClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление клиента";
            this.Load += new System.EventHandler(this.addClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox first_name;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox last_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox middle_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox birth_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button button2;
    }
}