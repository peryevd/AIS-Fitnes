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

        private void MainMenu_Load(object sender, EventArgs e)
        {
           
        }

        private void button_client_Click(object sender, EventArgs e)
        {
            Form clients = new clients();
            clients.Show();
            this.Hide();
        }

        private void button_hall_Click(object sender, EventArgs e)
        {
            Form hall = new hall();
            hall.Show();
            this.Hide();
        }

        private void button_stats_Click(object sender, EventArgs e)
        {
            Form stats = new stats();
            stats.Show();
            this.Hide();
        }

        private void button_info_Click(object sender, EventArgs e)
        {
            Form info = new info();
            info.Show();
            this.Hide();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            const string message = "Вы уверены, что хотите завершить работу?";
            const string caption = "Завершение работы";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button_contract_Click(object sender, EventArgs e)
        {
            Form contract = new contract();
            contract.Show();
            this.Hide();
        }
    }
}
