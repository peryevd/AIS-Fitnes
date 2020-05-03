namespace AIS_Fitnes
{
    partial class change_contract
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
            this.sub_id = new System.Windows.Forms.ComboBox();
            this.clients_id = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id_client = new System.Windows.Forms.Label();
            this.hall_id = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.clients_o = new System.Windows.Forms.ComboBox();
            this.clients_n = new System.Windows.Forms.ComboBox();
            this.clients_f = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox_master = new System.Windows.Forms.GroupBox();
            this.master_price = new System.Windows.Forms.ComboBox();
            this.master_hall = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.master_o = new System.Windows.Forms.ComboBox();
            this.master_n = new System.Windows.Forms.ComboBox();
            this.master_f = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.master_id = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox_contract = new System.Windows.Forms.GroupBox();
            this.sub_price = new System.Windows.Forms.ComboBox();
            this.sub_duration = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.sub_description = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sub_title = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox_hall = new System.Windows.Forms.GroupBox();
            this.hall_description = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.hall_title = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.today = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.all_price = new System.Windows.Forms.TextBox();
            this.date_end = new System.Windows.Forms.MaskedTextBox();
            this.date_start = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox_master.SuspendLayout();
            this.groupBox_contract.SuspendLayout();
            this.groupBox_hall.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // sub_id
            // 
            this.sub_id.FormattingEnabled = true;
            this.sub_id.Location = new System.Drawing.Point(92, 19);
            this.sub_id.Name = "sub_id";
            this.sub_id.Size = new System.Drawing.Size(237, 21);
            this.sub_id.TabIndex = 39;
            this.sub_id.SelectionChangeCommitted += new System.EventHandler(this.sub_id_SelectionChangeCommitted);
            // 
            // clients_id
            // 
            this.clients_id.FormattingEnabled = true;
            this.clients_id.Location = new System.Drawing.Point(92, 22);
            this.clients_id.Name = "clients_id";
            this.clients_id.Size = new System.Drawing.Size(237, 21);
            this.clients_id.TabIndex = 38;
            this.clients_id.SelectionChangeCommitted += new System.EventHandler(this.client_id_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Дата окончания";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Дата начала";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "ID";
            // 
            // id_client
            // 
            this.id_client.AutoSize = true;
            this.id_client.Location = new System.Drawing.Point(9, 25);
            this.id_client.Name = "id_client";
            this.id_client.Size = new System.Drawing.Size(18, 13);
            this.id_client.TabIndex = 30;
            this.id_client.Text = "ID";
            // 
            // hall_id
            // 
            this.hall_id.FormattingEnabled = true;
            this.hall_id.Location = new System.Drawing.Point(90, 19);
            this.hall_id.Name = "hall_id";
            this.hall_id.Size = new System.Drawing.Size(237, 21);
            this.hall_id.TabIndex = 42;
            this.hall_id.SelectionChangeCommitted += new System.EventHandler(this.hall_id_SelectionChangeCommitted);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.clients_o);
            this.groupBox1.Controls.Add(this.clients_n);
            this.groupBox1.Controls.Add(this.clients_f);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.clients_id);
            this.groupBox1.Controls.Add(this.id_client);
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 153);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Клиент";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 117);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 44;
            this.label16.Tag = "";
            this.label16.Text = "Отчество";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 43;
            this.label15.Tag = "";
            this.label15.Text = "Имя";
            // 
            // clients_o
            // 
            this.clients_o.FormattingEnabled = true;
            this.clients_o.Location = new System.Drawing.Point(92, 114);
            this.clients_o.Name = "clients_o";
            this.clients_o.Size = new System.Drawing.Size(237, 21);
            this.clients_o.TabIndex = 42;
            this.clients_o.SelectionChangeCommitted += new System.EventHandler(this.clients_o_SelectionChangeCommitted);
            // 
            // clients_n
            // 
            this.clients_n.FormattingEnabled = true;
            this.clients_n.Location = new System.Drawing.Point(92, 87);
            this.clients_n.Name = "clients_n";
            this.clients_n.Size = new System.Drawing.Size(237, 21);
            this.clients_n.TabIndex = 41;
            this.clients_n.SelectionChangeCommitted += new System.EventHandler(this.clients_n_SelectionChangeCommitted);
            // 
            // clients_f
            // 
            this.clients_f.FormattingEnabled = true;
            this.clients_f.Location = new System.Drawing.Point(92, 60);
            this.clients_f.Name = "clients_f";
            this.clients_f.Size = new System.Drawing.Size(237, 21);
            this.clients_f.TabIndex = 40;
            this.clients_f.SelectionChangeCommitted += new System.EventHandler(this.clients_f_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 39;
            this.label5.Tag = "";
            this.label5.Text = "Фамилия";
            // 
            // groupBox_master
            // 
            this.groupBox_master.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox_master.Controls.Add(this.master_price);
            this.groupBox_master.Controls.Add(this.master_hall);
            this.groupBox_master.Controls.Add(this.checkBox1);
            this.groupBox_master.Controls.Add(this.label21);
            this.groupBox_master.Controls.Add(this.label20);
            this.groupBox_master.Controls.Add(this.label6);
            this.groupBox_master.Controls.Add(this.label7);
            this.groupBox_master.Controls.Add(this.master_o);
            this.groupBox_master.Controls.Add(this.master_n);
            this.groupBox_master.Controls.Add(this.master_f);
            this.groupBox_master.Controls.Add(this.label17);
            this.groupBox_master.Controls.Add(this.master_id);
            this.groupBox_master.Controls.Add(this.label18);
            this.groupBox_master.Enabled = false;
            this.groupBox_master.Location = new System.Drawing.Point(353, 4);
            this.groupBox_master.Name = "groupBox_master";
            this.groupBox_master.Size = new System.Drawing.Size(335, 221);
            this.groupBox_master.TabIndex = 44;
            this.groupBox_master.TabStop = false;
            this.groupBox_master.Text = "Тренер";
            this.groupBox_master.Enter += new System.EventHandler(this.groupBox_master_Enter);
            // 
            // master_price
            // 
            this.master_price.Enabled = false;
            this.master_price.FormattingEnabled = true;
            this.master_price.Location = new System.Drawing.Point(92, 187);
            this.master_price.Name = "master_price";
            this.master_price.Size = new System.Drawing.Size(237, 21);
            this.master_price.TabIndex = 57;
            // 
            // master_hall
            // 
            this.master_hall.Enabled = false;
            this.master_hall.FormattingEnabled = true;
            this.master_hall.Location = new System.Drawing.Point(92, 160);
            this.master_hall.Name = "master_hall";
            this.master_hall.Size = new System.Drawing.Size(237, 21);
            this.master_hall.TabIndex = 56;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(235, 8);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 17);
            this.checkBox1.TabIndex = 55;
            this.checkBox1.Text = "Не требуется";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(11, 163);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(26, 13);
            this.label21.TabIndex = 53;
            this.label21.Text = "Зал";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(11, 190);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 13);
            this.label20.TabIndex = 49;
            this.label20.Text = "Стоимость";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 52;
            this.label6.Tag = "";
            this.label6.Text = "Отчество";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 51;
            this.label7.Tag = "";
            this.label7.Text = "Имя";
            // 
            // master_o
            // 
            this.master_o.FormattingEnabled = true;
            this.master_o.Location = new System.Drawing.Point(92, 133);
            this.master_o.Name = "master_o";
            this.master_o.Size = new System.Drawing.Size(237, 21);
            this.master_o.TabIndex = 50;
            this.master_o.SelectionChangeCommitted += new System.EventHandler(this.master_o_SelectionChangeCommitted);
            // 
            // master_n
            // 
            this.master_n.FormattingEnabled = true;
            this.master_n.Location = new System.Drawing.Point(92, 106);
            this.master_n.Name = "master_n";
            this.master_n.Size = new System.Drawing.Size(237, 21);
            this.master_n.TabIndex = 49;
            this.master_n.SelectionChangeCommitted += new System.EventHandler(this.master_n_SelectionChangeCommitted);
            // 
            // master_f
            // 
            this.master_f.FormattingEnabled = true;
            this.master_f.Location = new System.Drawing.Point(92, 79);
            this.master_f.Name = "master_f";
            this.master_f.Size = new System.Drawing.Size(237, 21);
            this.master_f.TabIndex = 48;
            this.master_f.SelectionChangeCommitted += new System.EventHandler(this.master_f_SelectionChangeCommitted);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 79);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 47;
            this.label17.Tag = "";
            this.label17.Text = "Фамилия";
            // 
            // master_id
            // 
            this.master_id.FormattingEnabled = true;
            this.master_id.Location = new System.Drawing.Point(92, 41);
            this.master_id.Name = "master_id";
            this.master_id.Size = new System.Drawing.Size(237, 21);
            this.master_id.TabIndex = 46;
            this.master_id.SelectionChangeCommitted += new System.EventHandler(this.master_id_SelectionChangeCommitted);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 44);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(18, 13);
            this.label18.TabIndex = 45;
            this.label18.Text = "ID";
            // 
            // groupBox_contract
            // 
            this.groupBox_contract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox_contract.Controls.Add(this.sub_price);
            this.groupBox_contract.Controls.Add(this.sub_duration);
            this.groupBox_contract.Controls.Add(this.label11);
            this.groupBox_contract.Controls.Add(this.label10);
            this.groupBox_contract.Controls.Add(this.sub_description);
            this.groupBox_contract.Controls.Add(this.label9);
            this.groupBox_contract.Controls.Add(this.sub_title);
            this.groupBox_contract.Controls.Add(this.label8);
            this.groupBox_contract.Controls.Add(this.sub_id);
            this.groupBox_contract.Controls.Add(this.label1);
            this.groupBox_contract.Enabled = false;
            this.groupBox_contract.Location = new System.Drawing.Point(353, 231);
            this.groupBox_contract.Name = "groupBox_contract";
            this.groupBox_contract.Size = new System.Drawing.Size(335, 273);
            this.groupBox_contract.TabIndex = 45;
            this.groupBox_contract.TabStop = false;
            this.groupBox_contract.Text = "Абонемент";
            // 
            // sub_price
            // 
            this.sub_price.Enabled = false;
            this.sub_price.FormattingEnabled = true;
            this.sub_price.Location = new System.Drawing.Point(92, 240);
            this.sub_price.Name = "sub_price";
            this.sub_price.Size = new System.Drawing.Size(237, 21);
            this.sub_price.TabIndex = 49;
            // 
            // sub_duration
            // 
            this.sub_duration.Enabled = false;
            this.sub_duration.FormattingEnabled = true;
            this.sub_duration.Location = new System.Drawing.Point(92, 214);
            this.sub_duration.Name = "sub_duration";
            this.sub_duration.Size = new System.Drawing.Size(237, 21);
            this.sub_duration.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "Цена";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Длительность";
            // 
            // sub_description
            // 
            this.sub_description.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sub_description.Enabled = false;
            this.sub_description.Location = new System.Drawing.Point(92, 73);
            this.sub_description.Multiline = true;
            this.sub_description.Name = "sub_description";
            this.sub_description.Size = new System.Drawing.Size(237, 129);
            this.sub_description.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Описание";
            // 
            // sub_title
            // 
            this.sub_title.FormattingEnabled = true;
            this.sub_title.Location = new System.Drawing.Point(92, 46);
            this.sub_title.Name = "sub_title";
            this.sub_title.Size = new System.Drawing.Size(237, 21);
            this.sub_title.TabIndex = 41;
            this.sub_title.SelectionChangeCommitted += new System.EventHandler(this.sub_title_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Название";
            // 
            // groupBox_hall
            // 
            this.groupBox_hall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox_hall.Controls.Add(this.hall_description);
            this.groupBox_hall.Controls.Add(this.label14);
            this.groupBox_hall.Controls.Add(this.hall_title);
            this.groupBox_hall.Controls.Add(this.label12);
            this.groupBox_hall.Controls.Add(this.hall_id);
            this.groupBox_hall.Controls.Add(this.label13);
            this.groupBox_hall.Enabled = false;
            this.groupBox_hall.Location = new System.Drawing.Point(12, 231);
            this.groupBox_hall.Name = "groupBox_hall";
            this.groupBox_hall.Size = new System.Drawing.Size(335, 213);
            this.groupBox_hall.TabIndex = 45;
            this.groupBox_hall.TabStop = false;
            this.groupBox_hall.Text = "Зал";
            // 
            // hall_description
            // 
            this.hall_description.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hall_description.Enabled = false;
            this.hall_description.Location = new System.Drawing.Point(90, 73);
            this.hall_description.Multiline = true;
            this.hall_description.Name = "hall_description";
            this.hall_description.Size = new System.Drawing.Size(237, 129);
            this.hall_description.TabIndex = 45;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 44;
            this.label14.Text = "Описание";
            // 
            // hall_title
            // 
            this.hall_title.FormattingEnabled = true;
            this.hall_title.Location = new System.Drawing.Point(90, 46);
            this.hall_title.Name = "hall_title";
            this.hall_title.Size = new System.Drawing.Size(237, 21);
            this.hall_title.TabIndex = 43;
            this.hall_title.SelectionChangeCommitted += new System.EventHandler(this.hall_title_SelectionChangeCommitted);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "Название";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "ID";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox5.Controls.Add(this.today);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(12, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(335, 62);
            this.groupBox5.TabIndex = 46;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Договор";
            // 
            // today
            // 
            this.today.Location = new System.Drawing.Point(92, 25);
            this.today.Mask = "00/00/0000";
            this.today.Name = "today";
            this.today.Size = new System.Drawing.Size(235, 20);
            this.today.TabIndex = 54;
            this.today.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Дата создания";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox6.Controls.Add(this.label24);
            this.groupBox6.Controls.Add(this.all_price);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.date_end);
            this.groupBox6.Controls.Add(this.date_start);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Location = new System.Drawing.Point(12, 450);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(335, 151);
            this.groupBox6.TabIndex = 47;
            this.groupBox6.TabStop = false;
            // 
            // all_price
            // 
            this.all_price.Enabled = false;
            this.all_price.Location = new System.Drawing.Point(119, 67);
            this.all_price.Name = "all_price";
            this.all_price.Size = new System.Drawing.Size(173, 20);
            this.all_price.TabIndex = 52;
            // 
            // date_end
            // 
            this.date_end.Location = new System.Drawing.Point(119, 41);
            this.date_end.Mask = "00/00/0000";
            this.date_end.Name = "date_end";
            this.date_end.Size = new System.Drawing.Size(173, 20);
            this.date_end.TabIndex = 51;
            this.date_end.ValidatingType = typeof(System.DateTime);
            // 
            // date_start
            // 
            this.date_start.Location = new System.Drawing.Point(119, 15);
            this.date_start.Mask = "00/00/0000";
            this.date_start.Name = "date_start";
            this.date_start.Size = new System.Drawing.Size(173, 20);
            this.date_start.TabIndex = 50;
            this.date_start.ValidatingType = typeof(System.DateTime);
            this.date_start.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.date_start_MaskInputRejected);
            this.date_start.Leave += new System.EventHandler(this.date_start_Leave);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 70);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 13);
            this.label19.TabIndex = 49;
            this.label19.Text = "Итоговая цена";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::AIS_Fitnes.Properties.Resources.electronics;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(285, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 52);
            this.button1.TabIndex = 48;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::AIS_Fitnes.Properties.Resources.ui;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(353, 517);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 65);
            this.button2.TabIndex = 37;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // add
            // 
            this.add.BackgroundImage = global::AIS_Fitnes.Properties.Resources.edit;
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Location = new System.Drawing.Point(617, 520);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(65, 65);
            this.add.TabIndex = 36;
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(364, 588);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(39, 13);
            this.label22.TabIndex = 50;
            this.label22.Text = "Назад";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(624, 588);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(58, 13);
            this.label23.TabIndex = 51;
            this.label23.Text = "Изменить";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(231, 113);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(48, 13);
            this.label24.TabIndex = 52;
            this.label24.Text = "Рассчет";
            // 
            // change_contract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 615);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox_hall);
            this.Controls.Add(this.groupBox_contract);
            this.Controls.Add(this.groupBox_master);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.add);
            this.Name = "change_contract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Договор";
            this.Load += new System.EventHandler(this.change_contract_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_master.ResumeLayout(false);
            this.groupBox_master.PerformLayout();
            this.groupBox_contract.ResumeLayout(false);
            this.groupBox_contract.PerformLayout();
            this.groupBox_hall.ResumeLayout(false);
            this.groupBox_hall.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sub_id;
        private System.Windows.Forms.ComboBox clients_id;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label id_client;
        private System.Windows.Forms.ComboBox hall_id;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox clients_f;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox_master;
        private System.Windows.Forms.GroupBox groupBox_contract;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox sub_title;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox sub_description;
        private System.Windows.Forms.GroupBox groupBox_hall;
        private System.Windows.Forms.TextBox hall_description;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox hall_title;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox clients_o;
        private System.Windows.Forms.ComboBox clients_n;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox master_o;
        private System.Windows.Forms.ComboBox master_n;
        private System.Windows.Forms.ComboBox master_f;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox master_id;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.MaskedTextBox today;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox master_price;
        private System.Windows.Forms.ComboBox master_hall;
        private System.Windows.Forms.ComboBox sub_price;
        private System.Windows.Forms.ComboBox sub_duration;
        private System.Windows.Forms.MaskedTextBox date_end;
        private System.Windows.Forms.MaskedTextBox date_start;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox all_price;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
    }
}