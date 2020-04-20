using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS_Fitnes.trainers
{
    public partial class change_trainers : Form
    {
        public change_trainers(string[] data)
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form trainers = new trainers();
            trainers.Show();
            this.Close();
        }

        private void change_trainers_Load(object sender, EventArgs e)
        {

        }
    }
}
