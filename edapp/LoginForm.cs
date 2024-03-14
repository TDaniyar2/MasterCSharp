using MySql.Data.MySqlClient;
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
    public partial class MasterCSharp : Form
    {
        public MasterCSharp()
        {
            InitializeComponent();

            this.password.AutoSize = false;
            this.password.Size = new Size(this.password.Size.Width, 40);

            loginbox.Text = "Введите почту";
            loginbox.ForeColor = Color.Black;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelcenter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String loginUser = loginbox.Text;
            String passUser = password.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
                MessageBox.Show("Пользователь не зарегистрирован");


        }

        private void loginbox_Enter(object sender, EventArgs e)
        {
            if (loginbox.Text == "Введите почту")
                loginbox.Text = "";
        }

        private void loginbox_Leave(object sender, EventArgs e)
        {
            if (loginbox.Text == "")
            {
                loginbox.Text = "Введите почту";
                loginbox.ForeColor = Color.Black;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegForm registerForm = new RegForm();
            registerForm.Show();

        }
    }
}
