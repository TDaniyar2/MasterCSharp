﻿using System;
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
    public partial class Les8p2 : Form
    {
        public Les8p2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Les8p1 p1 = new Les8p1();
            p1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
