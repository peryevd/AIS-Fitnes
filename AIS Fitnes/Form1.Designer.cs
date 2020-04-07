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
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

