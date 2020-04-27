namespace AIS_Fitnes
{
    partial class contract
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
            this.cha = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_sub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_clients = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_trainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_subscription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cha
            // 
            this.cha.Location = new System.Drawing.Point(864, 77);
            this.cha.Name = "cha";
            this.cha.Size = new System.Drawing.Size(130, 32);
            this.cha.TabIndex = 10;
            this.cha.Text = "Изменить";
            this.cha.UseVisualStyleBackColor = true;
            this.cha.Click += new System.EventHandler(this.cha_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(864, 115);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(130, 32);
            this.del.TabIndex = 9;
            this.del.Text = "Удалить";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.date_sub,
            this.name_clients,
            this.name_trainer,
            this.name_subscription,
            this.date_start,
            this.date_end,
            this.price});
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(846, 238);
            this.dataGridView1.TabIndex = 8;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(864, 39);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(130, 32);
            this.add.TabIndex = 6;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(864, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Главное меню";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Поиск";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // date_sub
            // 
            this.date_sub.HeaderText = "Дата создания";
            this.date_sub.Name = "date_sub";
            // 
            // name_clients
            // 
            this.name_clients.HeaderText = "Клиент";
            this.name_clients.Name = "name_clients";
            // 
            // name_trainer
            // 
            this.name_trainer.HeaderText = "Тренер";
            this.name_trainer.Name = "name_trainer";
            // 
            // name_subscription
            // 
            this.name_subscription.HeaderText = "Абонемент";
            this.name_subscription.Name = "name_subscription";
            // 
            // date_start
            // 
            this.date_start.HeaderText = "Начало действия";
            this.date_start.Name = "date_start";
            // 
            // date_end
            // 
            this.date_end.HeaderText = "Конец действия";
            this.date_end.Name = "date_end";
            // 
            // price
            // 
            this.price.HeaderText = "Цена";
            this.price.Name = "price";
            // 
            // contract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cha);
            this.Controls.Add(this.del);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.button1);
            this.Name = "contract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Договор";
            this.Load += new System.EventHandler(this.contract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cha;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_sub;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_clients;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_trainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_subscription;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_start;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_end;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}