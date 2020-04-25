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
    public partial class add_contract : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source=clients1.mdb";
        private OleDbConnection myConnection;
        public add_contract()
        {
            InitializeComponent();
        }

        private void add_contract_Load(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
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

        private void add_Click(object sender, EventArgs e)
        {
            string querry = "INSERT INTO Договора (id_clients, id_subscription, id_hall, date_start, date_end) " +
            "VALUES ('" + comboBox1.Text.ToString() + "','" + comboBox2.Text.ToString() + "','" + comboBox3.Text.ToString() + "','" + date_start.Text.ToString() + "','" + date_end.Text.ToString() + "')";
            OleDbCommand command = new OleDbCommand(querry, myConnection);
            command.ExecuteNonQuery();

            myConnection.Close();

            Form contract = new contract();
            contract.Show();
            this.Close();

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

        private void button2_Click(object sender, EventArgs e)
        {
            myConnection.Close();

            Form contract = new contract();
            contract.Show();
            this.Close();
        }
    }
}
