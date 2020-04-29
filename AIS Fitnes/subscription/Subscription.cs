using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS_Fitnes
{
    public partial class Subscription : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source=clients1.mdb";
        private OleDbConnection myConnection;

        public Subscription()
        {
            InitializeComponent();
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form mainmenu = Application.OpenForms[0];
            this.Close();
            mainmenu.Show();
        }

        private void Subscription_Load(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            dataGridView1.Rows.Clear();

            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            string query = "SELECT * FROM Абонементы ORDER BY id";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
            }

            reader.Close();
            myConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void del_Click(object sender, EventArgs e)
        {
            myConnection.Open();
            string query = "DELETE FROM Абонементы WHERE id = " + dataGridView1.CurrentRow.Cells[0].Value;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            myConnection.Close();

            LoadData();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Form addSubsсription = new addSubsсription();
            addSubsсription.Show();
            this.Close();
        }

        private void cha_Click(object sender, EventArgs e)
        {
            string[] arrayClient = new string[dataGridView1.ColumnCount];

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                arrayClient[i] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[i].Value.ToString();
            }

            change_subscription f = new change_subscription(arrayClient);
            f.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cha_Click(sender, e);
        }
    }
}
