namespace AIS_Fitnes
{
    partial class MainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_subscription = new System.Windows.Forms.Button();
            this.button_trainer = new System.Windows.Forms.Button();
            this.button_client = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Клиент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Тренер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Договора";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Абонементы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(710, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Диаграммы";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImage = global::AIS_Fitnes.Properties.Resources.growth;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(703, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 85);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = global::AIS_Fitnes.Properties.Resources.logout__1_;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Location = new System.Drawing.Point(703, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 85);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::AIS_Fitnes.Properties.Resources.edit;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(12, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 85);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button_subscription
            // 
            this.button_subscription.BackColor = System.Drawing.Color.White;
            this.button_subscription.BackgroundImage = global::AIS_Fitnes.Properties.Resources.contract;
            this.button_subscription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_subscription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_subscription.Location = new System.Drawing.Point(12, 324);
            this.button_subscription.Name = "button_subscription";
            this.button_subscription.Size = new System.Drawing.Size(85, 85);
            this.button_subscription.TabIndex = 1;
            this.button_subscription.UseVisualStyleBackColor = false;
            this.button_subscription.Click += new System.EventHandler(this.button_subscription_Click);
            // 
            // button_trainer
            // 
            this.button_trainer.BackColor = System.Drawing.Color.White;
            this.button_trainer.BackgroundImage = global::AIS_Fitnes.Properties.Resources.gym;
            this.button_trainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_trainer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_trainer.Location = new System.Drawing.Point(12, 116);
            this.button_trainer.Name = "button_trainer";
            this.button_trainer.Size = new System.Drawing.Size(85, 85);
            this.button_trainer.TabIndex = 1;
            this.button_trainer.UseVisualStyleBackColor = false;
            this.button_trainer.Click += new System.EventHandler(this.button_trainer_Click);
            // 
            // button_client
            // 
            this.button_client.BackColor = System.Drawing.Color.White;
            this.button_client.BackgroundImage = global::AIS_Fitnes.Properties.Resources.support;
            this.button_client.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_client.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_client.Location = new System.Drawing.Point(12, 12);
            this.button_client.Name = "button_client";
            this.button_client.Size = new System.Drawing.Size(85, 85);
            this.button_client.TabIndex = 0;
            this.button_client.UseVisualStyleBackColor = false;
            this.button_client.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_subscription);
            this.Controls.Add(this.button_trainer);
            this.Controls.Add(this.button_client);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_client;
        private System.Windows.Forms.Button button_trainer;
        private System.Windows.Forms.Button button_subscription;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

