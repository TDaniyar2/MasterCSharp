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
    public partial class Page3Form : Form
    {
        public Page3Form()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Les9p1 p1 = new Les9p1();
            p1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Page_2 page2 = new Page_2();
            page2.Show();
        }

        private void Page3Form_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Les7p1 p1 = new Les7p1();
            p1.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Les8p1 p1 = new Les8p1();
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
