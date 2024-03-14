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
    public partial class Page_2 : Form
    {
        public Page_2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Page3Form page3 = new Page3Form();
            page3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Les4p1 les4p1 = new Les4p1();
            les4p1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Les5p1 p1 = new Les5p1();
            p1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Les6p1 p1 = new Les6p1();
            p1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 t = new Form1();
            t.Show();
        }
    }
}
