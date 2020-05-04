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

        private void secure()
        {
            while (data2.Count != count_subscr.Count)
            {
                if (data2.Count > count_subscr.Count)
                {
                    data2.RemoveAt(data2.Count-1);
                }
                else
                {
                    count_subscr.RemoveAt(count_subscr.Count-1);
                }
            }                      
        }

        private void draw(List<string> data2, List<int> count_subscr, int type)
        {
            Chart1.Series.Clear();
            // Форматировать диаграмму
            //Chart1.BackColor = Color.Gray;
            //Chart1.BackSecondaryColor = Color.WhiteSmoke;
           //Chart1.BackGradientStyle = GradientStyle.DiagonalRight;

            Chart1.BorderlineDashStyle = ChartDashStyle.Solid;
            Chart1.BorderlineColor = Color.Gray;
            Chart1.BorderSkin.SkinStyle = BorderSkinStyle.Emboss;

            // Форматировать область диаграммы
            //Chart1.ChartAreas[0].BackColor = Color.Wheat;

            //Добавить и форматировать заголовок
            //Chart1.Titles[1].Font = new Font("Utopia", 16);

            if (type == 0)
            {
                Chart1.Series.Add(new Series("График")
                {
                    ChartType = SeriesChartType.Pie

                }) ;
                Chart1.ChartAreas[0].Area3DStyle.Enable3D = false;

                Chart1.Titles.Clear();
                Chart1.Titles.Add("Купленные абонементы");
            }
            if (type == 1)
            {
                Chart1.Series.Add(new Series("График")
                {
                    
                });
                Chart1.ChartAreas[0].Area3DStyle.Enable3D = false;

                Chart1.Titles.Clear();
                Chart1.Titles.Add("Занятость тренеров");
            }
            if (type == 2)
            {
                Chart1.Series.Add(new Series("График")
                {
                    ChartType = SeriesChartType.Line
                });
                Chart1.ChartAreas[0].Area3DStyle.Enable3D = true;

                Chart1.Titles.Clear();
                Chart1.Titles.Add("Заполненость залов");
            }

            // Salary series data
            //double[] yValues = { 2222, 2724, 2720, 3263, 2445 };
            //string[] xValues = { "France", "Canada", "Germany", "USA", "Italy" };

            secure();
            Chart1.Series["График"].Points.DataBindXY(data2, count_subscr);

            //Chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
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

            count_subscription();
            data1 = data1.Distinct().ToList();

            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            for (int i = 0; i < data1.Count; i++)
            {
                query = "SELECT title FROM Абонементы WHERE id = " + data1[i];
                command = new OleDbCommand(query, myConnection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    data2.Add(Convert.ToString(reader[0]));
                }
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

            count_subscription();
            data1 = data1.Distinct().ToList();

            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            for (int i = 0; i < data1.Count; i++)
            {
                query = "SELECT title FROM Залы WHERE id = " + data1[i];
                command = new OleDbCommand(query, myConnection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    data2.Add(Convert.ToString(reader[0]));
                }
            }

            reader.Close();
            myConnection.Close();
        }

        private void LoadDataMaster()
        {
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            string query = "SELECT id_master FROM Договора ORDER BY id";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                data1.Add(Convert.ToInt32(reader[0]));
            }

            reader.Close();
            myConnection.Close();

            count_subscription();
            data1 = data1.Distinct().ToList();

            myConnection = new OleDbConnection(connectString);
            myConnection.Open();

            for (int i = 0; i < data1.Count; i++)
            {
                query = "SELECT last_name FROM Тренера WHERE id = " + data1[i];
                command = new OleDbCommand(query, myConnection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    data2.Add(Convert.ToString(reader[0]));
                }
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
    
            draw(data2, count_subscr, 0);
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

            draw(data2, count_subscr, 2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            data1.Clear();
            data2.Clear();
            count_subscr.Clear();

            LoadDataMaster();

            draw(data2, count_subscr, 1);
        }

        private void Chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
