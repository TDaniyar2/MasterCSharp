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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();

            loginbox.Text = "Введите почту";
            loginbox.ForeColor = Color.Black;
        }

        private void loginbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

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

        private void RegForm_Load(object sender, EventArgs e)
        {

        }

        private void loginbox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void password_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            if (loginbox.Text == "Введите почту")
            {
                MessageBox.Show("Введите почту");
                return;
            }

            if (password.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            if (checkUser())
                return;

            DB db = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`) VALUES (@login, @password);", db.GetConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginbox.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт был создан");
            else
                MessageBox.Show("Аккаунт не был создан");

            db.closeConnection();
        }

        public Boolean checkUser()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginbox.Text;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже авторизован");
                return true;
            }

            else
                return false;
        }

        private void backtolog_Click(object sender, EventArgs e)
        {
            this.Hide();
            MasterCSharp loginform = new MasterCSharp();
            loginform.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
