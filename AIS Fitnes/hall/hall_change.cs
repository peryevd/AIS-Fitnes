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
    public partial class hall_change : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source=clients1.mdb";
        private OleDbConnection myConnection;
        bool type;
        string[] data;

        public hall_change(string[] data)
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            type = true;
            this.data = data;
        }

        public hall_change()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            type = false;
        }

        private void hall_change_Load(object sender, EventArgs e)
        {
            if (!type)
            {
                label4.Text = "Создать";
                button1.BackgroundImage = Properties.Resources.add;
                this.Text = "Создание зала";
            }
            else
            {
                label4.Text = "Изменить";
                button1.BackgroundImage = Properties.Resources.edit;
                title.Text = data[1];
                this.Text = "Изменение зала";
                description.Text = data[2];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form hall = new hall();
            hall.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!type)
            {
                string querry = "INSERT INTO Залы (title, description) " +
                "VALUES ('" + title.Text.ToString() + "','" + description.Text.ToString() + "')";
                OleDbCommand command = new OleDbCommand(querry, myConnection);
                command.ExecuteNonQuery();

                myConnection.Close();
                Form hall = new hall();
                hall.Show();
                this.Close();
            }
            else
            {
                string querry = "UPDATE Залы SET title = '" + title.Text.ToString() + "', description = '" + description.Text.ToString() + "' WHERE id = " + data[0];

                OleDbCommand command = new OleDbCommand(querry, myConnection);
                command.ExecuteNonQuery();
                updateAll();
                myConnection.Close();

                Form hall = new hall();
                hall.Show();
                this.Close();
            }
        }

        private void updateAll()
        {
            string querry = "UPDATE Договора SET name_hall = '" + title.Text.ToString() +  "' WHERE id_hall = " + data[0];
            OleDbCommand command = new OleDbCommand(querry, myConnection);
            command.ExecuteNonQuery();

            querry = "UPDATE Тренера SET hall = '" + title.Text.ToString() + "' WHERE hall = '" + data[1] + "'";
            command = new OleDbCommand(querry, myConnection);
            command.ExecuteNonQuery();
        }
    }
}
