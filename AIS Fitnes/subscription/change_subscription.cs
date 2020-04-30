using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS_Fitnes
{
    public partial class change_subscription : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source=clients1.mdb";
        private OleDbConnection myConnection;
        string[] data;

        public change_subscription(string[] data)
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            this.data = data;
        }

        private void change_subscription_Load(object sender, EventArgs e)
        {
            title.Text = data[1];
            description.Text = data[2];
            duration.Text = data[3];
            price.Text = data[4];

            duration_add();
        }

        private void duration_add()
        {
            string query = "SELECT Длительность FROM Длительность";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                duration.Items.Add(reader[0]);
            }

            reader.Close();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form Subscription = new Subscription();
            Subscription.Show();
            this.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string querry = "UPDATE Абонементы SET title = '" + title.Text.ToString() + "', description = '" + description.Text.ToString() + "', duration = '" + duration.Text.ToString() +  "', price = '" + price.Text.ToString() + "' WHERE id = " + data[0];

            OleDbCommand command = new OleDbCommand(querry, myConnection);
            command.ExecuteNonQuery();

            updateAll();

            myConnection.Close();
            Form Subscription = new Subscription();
            Subscription.Show();
            this.Close();
        }

        private void updateAll()
        {
            string querry = "UPDATE Договора SET name_subscription = '" + title.Text.ToString() + "' WHERE id_subscription = " + data[0];
            OleDbCommand command = new OleDbCommand(querry, myConnection);
            command.ExecuteNonQuery();
        }
    }
}
