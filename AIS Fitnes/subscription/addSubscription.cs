﻿using System;
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
    public partial class addSubsсription : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source=clients1.mdb";
        private OleDbConnection myConnection;

        public addSubsсription()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void addSubsсription_Load(object sender, EventArgs e)
        {
            duration_add();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string querry = "INSERT INTO Абонементы (title, description, duration, price) " +
    "VALUES ('" + title.Text.ToString() + "','" + description.Text.ToString() + "','" + duration.Text.ToString() +  "','" + price.Text.ToString() + "')";
            OleDbCommand command = new OleDbCommand(querry, myConnection);
            command.ExecuteNonQuery();

            myConnection.Close();
            Form Subscription = new Subscription();
            Subscription.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Subscription = new Subscription();
            Subscription.Show();
            this.Close();
        }

        private void duration_add()
        {
            string query = "SELECT Длительность FROM Длительность";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                duration.Items.Add(reader[0]);
            }

            reader.Close();

        }
    }
}
