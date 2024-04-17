using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Fun.Connection;

namespace Diplom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataBase dataBase = new DataBase();

            private void go_Click(object sender, EventArgs e)
        {
            var loginUser = textBox1.Text;
            var passUser = md5.hashPassword(textBox2.Text);

            DataTable table = NewMethod(loginUser, passUser); if (table.Rows.Count == 1)
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (username1.Text == "user1")
            {
                User1 u1 = new User1();
                this.Hide();
                u1.ShowDialog();
                this.Show();
            }
            if (username1.Text == "user2")
            {
                User2 u2 = new User2();
                this.Hide();
                u2.ShowDialog();
                this.Show();
            }
            {
                Ticket TB = new Ticket();
                TB.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует!", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                eror q = new eror();
                q.Show();
                this.Hide();
            }
        }
        private DataTable NewMethod(string loginUser, string passUser)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select ID, login, pass, role from users where lohin = '{loginUser}' and pass = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        private void username1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
