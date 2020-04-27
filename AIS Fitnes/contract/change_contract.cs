using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AIS_Fitnes
{
    public partial class change_contract : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source=clients1.mdb";
        private OleDbConnection myConnection;
        string[] data;
        bool type;
        string[] hall_desc;
        string[] contract_desc;

        public change_contract(string[] data)
        {
            InitializeComponent();
            type = false;
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            this.data = data;
        }

        public change_contract()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            type = true;
        }

        private void change_contract_Load(object sender, EventArgs e)
        {
            if (!type)
            {
                client_load();
                clients_f.Text = data[2];
                clients_f_SelectionChangeCommitted(sender, e);

                master_load();
                master_f.Text = data[3];
                master_f_SelectionChangeCommitted(sender, e);

                contract_add();
                sub_title.Text = data[4];
                sub_title_SelectionChangeCommitted(sender, e);

                today.Text = data[1];
                                   
                date_start.Text = data[5];
                date_end.Text = data[6];
                all_price.Text = data[7];

                add.Text = "Изменить";
            }
            else
            {
                DateTime thisDay = DateTime.Today;
                today.Text = thisDay.ToString();
                client_load();
                master_load();

                add.Text = "Создать";

            }
          
        }

        private void client_load()
        {
            string query = "SELECT id, first_name, last_name, middle_name FROM Клиенты";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                clients_id.Items.Add(reader[0]);
                clients_n.Items.Add(reader[1]);
                clients_f.Items.Add(reader[2]);
                clients_o.Items.Add(reader[3]);
            }

            reader.Close();
        }

        private void subs_add()
        {
            string query = "SELECT id FROM Абонементы";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                sub_id.Items.Add(reader[0]);
            }

            reader.Close();

        }

        private void hall_add()
        {
            int i = 0;
            string query = "SELECT id, title, description FROM Залы";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            hall_desc = new string[100];

            while (reader.Read())
            {
                hall_id.Items.Add(reader[0]);
                hall_title.Items.Add(reader[1]);
                hall_desc[i] = reader[2].ToString();
                i++;
            }

            reader.Close();
        }

        private void hall_add_id(string title)
        {
            string query = "SELECT * FROM Залы WHERE title = '" + title + "'";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();

            hall_desc = new string[1];

            List<string[]> data = new List<string[]>();

            hall_id.Items.Clear();
            hall_title.Items.Clear();

            while (reader.Read())
            {
                hall_id.Items.Add(reader[0]);
                hall_title.Items.Add(reader[1].ToString());
                hall_desc[0] = reader[2].ToString();
            }

            hall_id.SelectedIndex = 0;
            hall_title.SelectedIndex = 0;
            hall_description.Text = hall_desc[0];

            reader.Close();
        }

        private void contract_add()
        {
            int i = 0;
            string query = "SELECT * FROM Абонементы";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            contract_desc = new string[100];

            while (reader.Read())
            {
                sub_id.Items.Add(reader[0]);
                sub_title.Items.Add(reader[1]);
                contract_desc[i] = reader[2].ToString();
                sub_duration.Items.Add(reader[3]);
                sub_price.Items.Add(reader[4]);

                i++;
            }

            reader.Close();
        }

        private void master_load()
        {
            string query = "SELECT id, first_name, last_name, middle_name, hall, price FROM Тренера";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                master_id.Items.Add(reader[0]);
                master_n.Items.Add(reader[1]);
                master_f.Items.Add(reader[2]);
                master_o.Items.Add(reader[3]);
                master_hall.Items.Add(reader[4]);
                master_price.Items.Add(reader[5]);
            }

            reader.Close();
        }

        private void date_end_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {

            if (!type)
            {
                string querry = "UPDATE Договора SET date_sub = '" + today.Text.ToString() + "', id_clients = '" + clients_id.Text.ToString() + "', name_clients = '" + 
                    clients_f.Text.ToString() + "', id_master = '" + master_id.Text.ToString() + "', name_master = '" + master_f.Text.ToString() + "', id_subscription = '" + 
                    sub_id.Text.ToString() + "', name_subscription = '" + sub_title.Text.ToString() + "', id_hall = '" + hall_id.Text.ToString() + "', name_hall = '" +
                    hall_title.Text.ToString() + "', date_start = '" + date_start.Text.ToString() + "', date_end = '" + date_end.Text.ToString() + "', price = '" + all_price.Text.ToString() + "' WHERE id = " + data[0];

                OleDbCommand command = new OleDbCommand(querry, myConnection);
                command.ExecuteNonQuery();

                myConnection.Close();

                Form contract = new contract();
                contract.Show();
                this.Close();
            }
            else
            {
                string querry = "INSERT INTO Договора (date_sub, id_clients, name_clients, id_master, name_master, id_subscription, name_subscription, id_hall, name_hall, date_start, date_end, price) " +
                "VALUES ('" + today.Text.ToString() + "','" + clients_id.Text.ToString() + "','" + clients_f.Text.ToString() + "','" + master_id.Text.ToString() + "','" + 
                master_f.Text.ToString() + "','" + sub_id.Text.ToString() + "','" + sub_title.Text.ToString() + "','" + hall_id.Text.ToString() + "','" + hall_title.Text.ToString() + "','" 
                + date_start.Text.ToString() + "','" + date_end.Text.ToString() + "','" + all_price.Text.ToString() + "')";

                OleDbCommand command = new OleDbCommand(querry, myConnection);
                command.ExecuteNonQuery();

                myConnection.Close();

                Form contract = new contract();
                contract.Show();
                this.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            myConnection.Close();
            Form contract = new contract();
            contract.Show();
            this.Close();
        }

        private void date_start_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                groupBox_hall.Enabled = true;

                master_id.Enabled = false;
                master_n.Enabled = false;
                master_f.Enabled = false;
                master_o.Enabled = false;

                hall_add();
            }
            else
            {
                groupBox_hall.Enabled = false;

                master_id.Enabled = true;
                master_n.Enabled = true;
                master_f.Enabled = true;
                master_o.Enabled = true;
            }
        }

        private void client_id_SelectionChangeCommitted(object sender, EventArgs e)
        {
            clients_n.SelectedIndex = clients_id.SelectedIndex;
            clients_f.SelectedIndex = clients_id.SelectedIndex;
            clients_o.SelectedIndex = clients_id.SelectedIndex;

            groupBox_master.Enabled = true;
        }

        private void clients_f_SelectionChangeCommitted(object sender, EventArgs e)
        {
            clients_id.SelectedIndex = clients_f.SelectedIndex;
            clients_n.SelectedIndex = clients_f.SelectedIndex;
            clients_o.SelectedIndex = clients_f.SelectedIndex;
        }

        private void clients_n_SelectionChangeCommitted(object sender, EventArgs e)
        {
            clients_id.SelectedIndex = clients_n.SelectedIndex;
            clients_f.SelectedIndex = clients_n.SelectedIndex;
            clients_o.SelectedIndex = clients_n.SelectedIndex;
        }

        private void clients_o_SelectionChangeCommitted(object sender, EventArgs e)
        {
            clients_id.SelectedIndex = clients_o.SelectedIndex;
            clients_f.SelectedIndex = clients_o.SelectedIndex;
            clients_n.SelectedIndex = clients_o.SelectedIndex;
        }

        private void master_id_SelectionChangeCommitted(object sender, EventArgs e)
        {
            master_n.SelectedIndex = master_id.SelectedIndex;
            master_f.SelectedIndex = master_id.SelectedIndex;
            master_o.SelectedIndex = master_id.SelectedIndex;
            master_hall.SelectedIndex = master_id.SelectedIndex;
            master_price.SelectedIndex = master_id.SelectedIndex;

            hall_add_id(master_hall.Text.ToString());
            groupBox_contract.Enabled = true;
            contract_add();
        }

        private void groupBox_master_Enter(object sender, EventArgs e)
        {

        }

        private void master_f_SelectionChangeCommitted(object sender, EventArgs e)
        {
            master_n.SelectedIndex = master_f.SelectedIndex;
            master_id.SelectedIndex = master_f.SelectedIndex;
            master_o.SelectedIndex = master_f.SelectedIndex;
            master_hall.SelectedIndex = master_f.SelectedIndex;
            master_price.SelectedIndex = master_f.SelectedIndex;

            hall_add_id(master_hall.Text.ToString());
        }

        private void master_n_SelectionChangeCommitted(object sender, EventArgs e)
        {
            master_f.SelectedIndex = master_n.SelectedIndex;
            master_id.SelectedIndex = master_n.SelectedIndex;
            master_o.SelectedIndex = master_n.SelectedIndex;
            master_hall.SelectedIndex = master_n.SelectedIndex;
            master_price.SelectedIndex = master_n.SelectedIndex;

            hall_add_id(master_hall.Text.ToString());
        }

        private void master_o_SelectionChangeCommitted(object sender, EventArgs e)
        {
            master_f.SelectedIndex = master_o.SelectedIndex;
            master_id.SelectedIndex = master_o.SelectedIndex;
            master_n.SelectedIndex = master_o.SelectedIndex;
            master_hall.SelectedIndex = master_o.SelectedIndex;
            master_price.SelectedIndex = master_o.SelectedIndex;

            hall_add_id(master_hall.Text.ToString());
        }

        private void hall_id_SelectionChangeCommitted(object sender, EventArgs e)
        {
            hall_title.SelectedIndex = hall_id.SelectedIndex;
            hall_description.Text = hall_desc[hall_id.SelectedIndex];

            groupBox_contract.Enabled = true;
            contract_add();
        }

        private void hall_title_SelectionChangeCommitted(object sender, EventArgs e)
        {
            hall_id.SelectedIndex = hall_title.SelectedIndex;
            hall_description.Text = hall_desc[hall_title.SelectedIndex];

            groupBox_contract.Enabled = true;
            contract_add();
        }

        private void sub_id_SelectionChangeCommitted(object sender, EventArgs e)
        {
            sub_title.SelectedIndex = sub_id.SelectedIndex;
            sub_description.Text = contract_desc[sub_id.SelectedIndex];
            sub_duration.SelectedIndex = sub_id.SelectedIndex;
            sub_price.SelectedIndex = sub_id.SelectedIndex;
        }

        private void sub_title_SelectionChangeCommitted(object sender, EventArgs e)
        {
            sub_id.SelectedIndex = sub_title.SelectedIndex;
            sub_description.Text = contract_desc[sub_title.SelectedIndex];
            sub_duration.SelectedIndex = sub_title.SelectedIndex;
            sub_price.SelectedIndex = sub_title.SelectedIndex;
        }

        private void date_start_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void date_start_Leave(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime();
            date = Convert.ToDateTime(date_start.Text.ToString());
            date_end.Text = date.AddMonths(1).ToString();

            if (master_price.Text != null)
            {
                all_price.Text = (Convert.ToInt32(master_price.Text) + Convert.ToInt32(sub_price.Text)).ToString();
            }
            else
            {
                all_price.Text = sub_price.Text.ToString();
            }

            Console.WriteLine(sub_price.Text);
        }
    }
}
