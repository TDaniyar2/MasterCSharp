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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Page_2 page2 = new Page_2();
            page2.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Les1p1 p1 = new Les1p1();
            p1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            L3p1 l3 = new L3p1();
            l3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Les2p1 les2p1 = new Les2p1();
            les2p1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 t = new Form1();
            t.Show();
        }
    }
}
