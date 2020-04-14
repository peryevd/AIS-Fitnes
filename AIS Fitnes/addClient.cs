using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS_Fitnes
{
    public partial class addClient : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source=clients1.mdb";
        private OleDbConnection myConnection;

        public addClient()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();

            birth_date.Text = "dd.mm.yyyy";
            birth_date.ForeColor = Color.Gray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string querry = "INSERT INTO Клиенты (first_name, last_name, middle_name, birth_date, phone, email) " +
                "VALUES ('"+ first_name.Text.ToString() +"','" + last_name.Text.ToString() + "','" + middle_name.Text.ToString() + "','" + birth_date.Text.ToString() + "','" + phone.Text.ToString() + "','" + email.Text.ToString() + "')";
            OleDbCommand command = new OleDbCommand(querry, myConnection);
            command.ExecuteNonQuery();

            myConnection.Close();
            Form clients = new clients();
            clients.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form clients = new clients();
            clients.Show();
            this.Close();
        }

        private void addClient_Load(object sender, EventArgs e)
        {

        }

        private void birth_date_MouseEnter(object sender, EventArgs e)
        {
            birth_date.Text = null;
            birth_date.ForeColor = Color.Black;
        }

        private void birth_date_MouseLeave(object sender, EventArgs e)
        {
            birth_date.Text = "dd.mm.yyyy";
            birth_date.ForeColor = Color.Gray;
        }
    }
}
