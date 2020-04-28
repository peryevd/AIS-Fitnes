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
    public partial class change_master : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source=clients1.mdb";
        private OleDbConnection myConnection;
        string[] data;
        bool type;

        public change_master(string[] data)
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            this.data = data;
            add.Text = "Изменить";
            type = false;
        }

        public change_master()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            add.Text = "Cоздать";
            type = true;
        }

        private void change_master_Load(object sender, EventArgs e)
        {
            if (!type)
            {
                first_name.Text = data[1];
                last_name.Text = data[2];
                middle_name.Text = data[3];
                birth_date.Text = data[4];
                sex.Text = data[5];
                phone.Text = data[6];
                email.Text = data[7];
                address.Text = data[8];
                hall.Text = data[9];
                price.Text = data[10];
                load_hall();
            }
            else
            {
                load_hall();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form master = new master();
            master.Show();
            this.Hide();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (type)
            {
                string querry = "INSERT INTO Тренера (first_name, last_name, middle_name, birth_date, sex, phone, email, address, hall, price) " +
                "VALUES ('" + first_name.Text.ToString() + "','" + last_name.Text.ToString() + "','" + middle_name.Text.ToString() + "','" +
                birth_date.Text.ToString() + "','" + sex.Text.ToString() + "','" + phone.Text.ToString() + "','" + email.Text.ToString() + "','" +
                address.Text.ToString() + "','" + hall.Text.ToString() + "','" + price.Text.ToString() + "')";

                OleDbCommand command = new OleDbCommand(querry, myConnection);
                command.ExecuteNonQuery();

                myConnection.Close();
                Form master = new master();
                master.Show();
                this.Close();
            }
            else
            {
                string querry = "UPDATE Тренера SET first_name = '" + first_name.Text.ToString() + "', last_name = '" + last_name.Text.ToString() +
                "', middle_name = '" + middle_name.Text.ToString() + "', birth_date = '" + Convert.ToDateTime(birth_date.Text) + "', sex = '"
                + sex.Text.ToString() + "', phone = '" + phone.Text.ToString() + "', email = '" + email.Text.ToString() + "', address = '" + address.Text.ToString()
                + "', hall = '" + hall.Text.ToString() + "', price = '" + price.Text.ToString() + "' WHERE id = " + data[0];

                OleDbCommand command = new OleDbCommand(querry, myConnection);
                command.ExecuteNonQuery();

                myConnection.Close();
                Form master = new master();
                master.Show();
                this.Close();
            }
        }

        private void load_hall()
        {
            int i = 0;
            string query = "SELECT title FROM Залы";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                hall.Items.Add(reader[0].ToString());
            }

            reader.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
