using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class AuthForm : Form { 
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.Параметр);

        public AuthForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form newForm = new Form1();
            newForm.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            String login = textBox1.Text;
            String pass = textBox2.Text;

            SqlCommand command = new SqlCommand("SELECT * FROM Пользователь WHERE Логин = '" + login + "' AND Пароль = '" + pass + "'", connection);
            SqlDataReader reader = command.ExecuteReader();

            String role = "", name = "";
            while (reader.Read())

            {

                role = reader[3].ToString();

                name = reader[4].ToString();

            }

            Form form = null;

            switch (role)

            {

                case "User":

                    form = new UserForm(name);

                    Hide();

                    form.Show();

                    break;

                case "Director":

                    form = new AdminForm();

                    Hide();

                    form.Show();

                    break;

                case "Ware":

                    form = new WareForm();

                    Hide();

                    form.Show();

                    break;

                case "Manager":

                    form = new ManadgerForm();

                    Hide();

                    form.Show();

                    break;

                default:

                    MessageBox.Show("Роль не установлена или пользователь не найден!");

                    break;
 
            }
            reader.Close();
            connection.Close();
        }
    }
}
