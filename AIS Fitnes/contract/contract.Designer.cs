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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_sub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_clients = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_trainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_subscription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cha = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
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
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(730, 238);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Width = 25;
            // 
            // date_sub
            // 
            this.date_sub.HeaderText = "Дата создания";
            this.date_sub.Name = "date_sub";
            this.date_sub.ReadOnly = true;
            this.date_sub.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // name_clients
            // 
            this.name_clients.HeaderText = "Клиент";
            this.name_clients.Name = "name_clients";
            this.name_clients.ReadOnly = true;
            this.name_clients.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // name_trainer
            // 
            this.name_trainer.HeaderText = "Тренер";
            this.name_trainer.Name = "name_trainer";
            this.name_trainer.ReadOnly = true;
            this.name_trainer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // name_subscription
            // 
            this.name_subscription.HeaderText = "Абонемент";
            this.name_subscription.Name = "name_subscription";
            this.name_subscription.ReadOnly = true;
            this.name_subscription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // date_start
            // 
            this.date_start.HeaderText = "Начало действия";
            this.date_start.Name = "date_start";
            this.date_start.ReadOnly = true;
            this.date_start.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // date_end
            // 
            this.date_end.HeaderText = "Конец действия";
            this.date_end.Name = "date_end";
            this.date_end.ReadOnly = true;
            this.date_end.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // price
            // 
            this.price.HeaderText = "Цена";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Добавить";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Изменить";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Удалить";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(701, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Домой";
            // 
            // cha
            // 
            this.cha.BackgroundImage = global::AIS_Fitnes.Properties.Resources.edit;
            this.cha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cha.FlatAppearance.BorderSize = 0;
            this.cha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cha.Location = new System.Drawing.Point(131, 283);
            this.cha.Name = "cha";
            this.cha.Size = new System.Drawing.Size(50, 50);
            this.cha.TabIndex = 10;
            this.cha.UseVisualStyleBackColor = true;
            this.cha.Click += new System.EventHandler(this.cha_Click);
            // 
            // del
            // 
            this.del.BackgroundImage = global::AIS_Fitnes.Properties.Resources.bin;
            this.del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.del.FlatAppearance.BorderSize = 0;
            this.del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del.Location = new System.Drawing.Point(251, 283);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(50, 50);
            this.del.TabIndex = 9;
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // add
            // 
            this.add.BackgroundImage = global::AIS_Fitnes.Properties.Resources.add;
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Location = new System.Drawing.Point(12, 283);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(50, 50);
            this.add.TabIndex = 6;
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::AIS_Fitnes.Properties.Resources.home;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(646, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 343);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cha);
            this.Controls.Add(this.del);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "contract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Договора";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
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