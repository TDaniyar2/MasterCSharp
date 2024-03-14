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
    public partial class Les3p2 : Form
    {
        public Les3p2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            L3p1 l3 = new L3p1();
            l3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Les3p3 les3p3 = new Les3p3();
            les3p3.Show();
        }
    }
}
