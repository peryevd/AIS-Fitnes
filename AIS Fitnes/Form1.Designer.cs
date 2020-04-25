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
            this.button_client = new System.Windows.Forms.Button();
            this.button_trainer = new System.Windows.Forms.Button();
            this.button_subscription = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_client
            // 
            this.button_client.Location = new System.Drawing.Point(12, 12);
            this.button_client.Name = "button_client";
            this.button_client.Size = new System.Drawing.Size(175, 74);
            this.button_client.TabIndex = 0;
            this.button_client.Text = "Клиенты";
            this.button_client.UseVisualStyleBackColor = true;
            this.button_client.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_trainer
            // 
            this.button_trainer.Location = new System.Drawing.Point(12, 92);
            this.button_trainer.Name = "button_trainer";
            this.button_trainer.Size = new System.Drawing.Size(175, 74);
            this.button_trainer.TabIndex = 1;
            this.button_trainer.Text = "Тренера";
            this.button_trainer.UseVisualStyleBackColor = true;
            this.button_trainer.Click += new System.EventHandler(this.button_trainer_Click);
            // 
            // button_subscription
            // 
            this.button_subscription.Location = new System.Drawing.Point(12, 172);
            this.button_subscription.Name = "button_subscription";
            this.button_subscription.Size = new System.Drawing.Size(175, 74);
            this.button_subscription.TabIndex = 1;
            this.button_subscription.Text = "Абонементы";
            this.button_subscription.UseVisualStyleBackColor = true;
            this.button_subscription.Click += new System.EventHandler(this.button_subscription_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 74);
            this.button1.TabIndex = 2;
            this.button1.Text = "Договора";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(613, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 74);
            this.button2.TabIndex = 3;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 74);
            this.button3.TabIndex = 4;
            this.button3.Text = "Диаграммы";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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

        }

        #endregion

        private System.Windows.Forms.Button button_client;
        private System.Windows.Forms.Button button_trainer;
        private System.Windows.Forms.Button button_subscription;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

