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

        public change_contract(string[] data)
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            this.data = data;
        }

        private void change_contract_Load(object sender, EventArgs e)
        {
            comboBox1.Text = data[1];
            comboBox2.Text = data[2];
            comboBox3.Text = data[3];
            date_start.Text = data[4];
            date_end.Text = data[5];

            client_load();
            subs_add();
            hall_add();
        }

        private void client_load()
        {
            string query = "SELECT id FROM Клиенты";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0]);
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
                comboBox2.Items.Add(reader[0]);
            }

            reader.Close();

        }

        private void hall_add()
        {
            string query = "SELECT id FROM Залы";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                comboBox3.Items.Add(reader[0]);
            }

            reader.Close();
        }

        private void date_end_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            string querry = "UPDATE Договора SET id_clients = '" + comboBox1.Text.ToString() + "', id_subscription = '" + comboBox2.Text.ToString() + "', id_hall = '" + comboBox3.Text.ToString() + "', date_start = '" + date_start.Text.ToString() + "', date_end = '" + date_end.Text.ToString()  + "' WHERE id = " + data[0];

            OleDbCommand command = new OleDbCommand(querry, myConnection);
            command.ExecuteNonQuery();

            myConnection.Close();
            Form contract = new contract();
            contract.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myConnection.Close();
            Form contract = new contract();
            contract.Show();
            this.Close();
        }
    }
}
