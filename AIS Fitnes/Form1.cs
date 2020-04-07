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
    }
}
