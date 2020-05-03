using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS_Fitnes
{
    public partial class changeClients : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source=clients1.mdb";
        private OleDbConnection myConnection;
        bool type;

        public changeClients(string[] data)
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            label_ch.Text = "Изменить";
            add.BackgroundImage = Properties.Resources.edit;
            this.Text = "Изменение клиента";
            this.data = data;
            type = false;
        }

        public changeClients()
        {
            InitializeComponent();
            label_ch.Text = "Добавить";
            this.Text = "Добавление клиента";
            add.BackgroundImage = Properties.Resources.add;
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            type = true;
        }

        string[] data;

        private void changeClients_Load(object sender, EventArgs e)
        {
            sex.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            sex.AutoCompleteSource = AutoCompleteSource.ListItems;

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
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form clients = new clients();
            clients.Show();
            this.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {

            if (type)
            {
                string querry = "INSERT INTO Клиенты (first_name, last_name, middle_name, birth_date, sex, phone, email, address) " +
                "VALUES ('" + first_name.Text.ToString() + "','" + last_name.Text.ToString() + "','" + middle_name.Text.ToString() + "','" + birth_date.Text.ToString() + "','" + sex.Text.ToString() + "','"  + phone.Text.ToString() + "','" + email.Text.ToString() + "','" + address.Text.ToString() + "')";
                OleDbCommand command = new OleDbCommand(querry, myConnection);
                command.ExecuteNonQuery();

                myConnection.Close();
                Form clients = new clients();
                clients.Show();
                this.Close();
            }
            else
            {
                string querry = "UPDATE Клиенты SET first_name = '" + first_name.Text.ToString() + "', last_name = '" + last_name.Text.ToString() + "', middle_name = '" + middle_name.Text.ToString() + "', birth_date = '" + Convert.ToDateTime(birth_date.Text) + "', sex = '" + sex.Text + "', phone = '" + phone.Text.ToString() + "', email = '" + email.Text.ToString() + "', address = '" + address.Text.ToString() + "' WHERE id = " + data[0];

                OleDbCommand command = new OleDbCommand(querry, myConnection);
                command.ExecuteNonQuery();

                updateAll();
                myConnection.Close();
                Form clients = new clients();
                clients.Show();
                this.Close();
            }

        }

        private void first_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void updateAll()
        {
            string querry = "UPDATE Договора SET name_clients = '" + last_name.Text.ToString()  + "' WHERE id_clients = " + data[0];
            OleDbCommand command = new OleDbCommand(querry, myConnection);
            command.ExecuteNonQuery();
        }
    }
}
