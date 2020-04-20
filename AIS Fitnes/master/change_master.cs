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

        public change_master(string[] data)
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            this.data = data;
        }

        private void change_master_Load(object sender, EventArgs e)
        {
            first_name.Text = data[1];
            last_name.Text = data[2];
            middle_name.Text = data[3];
            birth_date.Text = data[4];
            phone.Text = data[5];
            email.Text = data[6];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form master = new master();
            master.Show();
            this.Hide();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string querry = "UPDATE Тренера SET first_name = '" + first_name.Text.ToString() + "', last_name = '" + last_name.Text.ToString() + "', middle_name = '" + middle_name.Text.ToString() + "', birth_date = '" + Convert.ToDateTime(birth_date.Text) + "', phone = '" + phone.Text.ToString() + "', email = '" + email.Text.ToString() + "' WHERE id = " + data[0];

            OleDbCommand command = new OleDbCommand(querry, myConnection);
            command.ExecuteNonQuery();

            myConnection.Close();
            Form master = new master();
            master.Show();
            this.Close();
        }
    }
}
