using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.OleDb;
using System.Threading;

namespace AIS_Fitnes
{
    public partial class stats : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source=clients1.mdb";
        private OleDbConnection myConnection;
        List<int> data1 = new List<int>();
        List<string> data2 = new List<string>();
        List<int> count_subscr = new List<int>(); 

        public stats()
        {
            InitializeComponent();
        }

        private void stats_Load(object sender, EventArgs e)
        {          
            
        }

        private void draw(List<string> data2, List<int> count_subscr, bool type)
        {
            Chart1.Series.Clear();
            // Форматировать диаграмму
            Chart1.BackColor = Color.Gray;
            Chart1.BackSecondaryColor = Color.WhiteSmoke;
            Chart1.BackGradientStyle = GradientStyle.DiagonalRight;

            Chart1.BorderlineDashStyle = ChartDashStyle.Solid;
            Chart1.BorderlineColor = Color.Gray;
            Chart1.BorderSkin.SkinStyle = BorderSkinStyle.Emboss;

            // Форматировать область диаграммы
            Chart1.ChartAreas[0].BackColor = Color.Wheat;

            // Добавить и форматировать заголовок
            Chart1.Titles.Clear();
            Chart1.Titles.Add("Купленные абонементы");
            //Chart1.Titles[1].Font = new Font("Utopia", 16);

            if (type)
            {
                Chart1.Series.Add(new Series("ColumnSeries")
                {
                    ChartType = SeriesChartType.Pie
                });
            }
            else
            {
                Chart1.Series.Add(new Series("ColumnSeries")
                {
                    
                });
            }
           

            // Salary series data
            //double[] yValues = { 2222, 2724, 2720, 3263, 2445 };
            //string[] xValues = { "France", "Canada", "Germany", "USA", "Italy" };
            Chart1.Series["ColumnSeries"].Points.DataBindXY(data2, count_subscr);

            Chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
        }

        private void LoadDataSub()
        {
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            string query = "SELECT id_subscription FROM Договора ORDER BY id";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
               data1.Add(Convert.ToInt32(reader[0]));
            }

            reader.Close();
            myConnection.Close();

            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            query = "SELECT title FROM Абонементы ORDER BY id";
            command = new OleDbCommand(query, myConnection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                data2.Add(Convert.ToString(reader[0]));
            }

            reader.Close();
            myConnection.Close();
        }

        private void LoadDataHall()
        {
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            string query = "SELECT id_hall FROM Договора ORDER BY id";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                data1.Add(Convert.ToInt32(reader[0]));
            }

            reader.Close();
            myConnection.Close();

            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            query = "SELECT title FROM Залы ORDER BY id";
            command = new OleDbCommand(query, myConnection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                data2.Add(Convert.ToString(reader[0]));
            }

            reader.Close();
            myConnection.Close();
        }

        private void count_subscription()
        {
            var lst = data1.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
            int i = 0;

            foreach (var x in lst)
            {
                //Console.WriteLine("Символ " + x.Key + " встречается " + x.Value + " раз");
                count_subscr.Add(x.Value);
                i++;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            data1.Clear();
            data2.Clear();
            count_subscr.Clear();

            LoadDataSub();
            count_subscription();
            draw(data2, count_subscr, false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form mainmenu = Application.OpenForms[0];
            this.Close();
            mainmenu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            data1.Clear();
            data2.Clear();
            count_subscr.Clear();

            LoadDataHall();
            count_subscription();
            draw(data2, count_subscr, true);
        }
    }
}
