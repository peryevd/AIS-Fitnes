using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS_Fitnes
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form clients = new clients();
            clients.Show();
            this.Hide();
        }

        private void button_subscription_Click(object sender, EventArgs e)
        {
            Form subscription = new Subscription();
            subscription.Show();
            this.Hide();
        }

        private void button_trainer_Click(object sender, EventArgs e)
        {
            Form master = new master();
            master.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form contract = new contract();
            contract.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form stats = new stats();
            stats.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form hall = new hall();
            hall.Show();
            this.Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form info = new info();
            info.Show();
            this.Hide();
        }
    }
}
