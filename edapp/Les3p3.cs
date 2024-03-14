using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace edapp
{
    public partial class Les3p3 : Form
    {
        public Les3p3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Les3p4 les3p4 = new Les3p4();
            les3p4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Les3p2 les3p2 = new Les3p2();
            les3p2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
