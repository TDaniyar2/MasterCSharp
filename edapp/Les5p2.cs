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
    public partial class Les5p2 : Form
    {
        public Les5p2()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Les5p1 p1 = new Les5p1();
            p1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
