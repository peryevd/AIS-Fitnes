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
    public partial class contract : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source=clients1.mdb";
        private OleDbConnection myConnection;

        public contract()
        {
            InitializeComponent();
            LoadData();
        }

        private void contract_Load(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            dataGridView1.Rows.Clear();

            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            string query = "SELECT * FROM Договора ORDER BY id";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[13]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[3].ToString();
                data[data.Count - 1][3] = reader[5].ToString();
                data[data.Count - 1][4] = reader[7].ToString();
                data[data.Count - 1][5] = reader[10].ToString();
                data[data.Count - 1][6] = reader[11].ToString();
                data[data.Count - 1][7] = reader[12].ToString();
            }

            reader.Close();
            myConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void add_Click(object sender, EventArgs e)
        {
            change_contract f = new change_contract();
            f.Show();
            this.Close();
        }

        private void del_Click(object sender, EventArgs e)
        {
            myConnection.Open();
            string query = "DELETE FROM Договора WHERE id = " + dataGridView1.CurrentRow.Cells[0].Value;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            myConnection.Close();

            LoadData();
        }

        private void cha_Click(object sender, EventArgs e)
        {
            string[] arrayClient = new string[dataGridView1.ColumnCount];

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                arrayClient[i] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[i].Value.ToString();
            }

            change_contract f = new change_contract(arrayClient);
            f.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form mainmenu = Application.OpenForms[0];
            this.Close();
            mainmenu.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                            if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                            {
                                dataGridView1.Rows[i].Selected = true;
                                //dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                                break;
                            }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cha_Click(sender, e);
        }
    }
}
