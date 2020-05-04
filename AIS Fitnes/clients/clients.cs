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
    public partial class clients : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source=clients1.mdb";
        private OleDbConnection myConnection;

        public clients()
        {
            InitializeComponent();
            LoadData();
        }

        private void clients_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.ColumnHeadersDefaultCellStyle.Font.FontFamily, 9f, FontStyle.Bold); //жирный курсив размера 16
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray; //цвет текста
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black; //цвет ячейки
        }

        private void LoadData()
        {
            dataGridView1.Rows.Clear();

            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            string query = "SELECT * FROM Клиенты ORDER BY id";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[9]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = DateTime.Parse(reader[4].ToString()).ToShortDateString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();
            }

            reader.Close();
            myConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
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
            btn_change_Click(sender, e);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            changeClients f = new changeClients();
            f.Show();
            this.Close();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            string[] arrayClient = new string[dataGridView1.ColumnCount];

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                arrayClient[i] = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[i].Value.ToString();
            }

            changeClients f = new changeClients(arrayClient);
            f.Show();
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form mainmenu = Application.OpenForms[0];
            this.Close();
            mainmenu.Show();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            const string message = "Вы уверены, что хотите удалить выбранного пользователя?";
            const string caption = "Удаление";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                myConnection.Open();
                string query = "DELETE FROM Клиенты WHERE id = " + dataGridView1.CurrentRow.Cells[0].Value;
                OleDbCommand command = new OleDbCommand(query, myConnection);
                OleDbDataReader reader = command.ExecuteReader();
                myConnection.Close();

                LoadData();
            }
        }
    }  
}
