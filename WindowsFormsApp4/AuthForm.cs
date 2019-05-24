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

        Form auth; // null
    
        public AuthForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Hide();
            connection.Open();
            try

            {

                SqlCommand command = new SqlCommand("INSERT INTO users (login,password,role,name) VALUES (@login,@password,@role,@name)", connection);

                command.Parameters.AddWithValue("@login", textBox2.Text);

                command.Parameters.AddWithValue("@password", textBox3.Text);

                command.Parameters.AddWithValue("@role", "User");

                command.Parameters.AddWithValue("@name", textBox1.Text);

                int regged = Convert.ToInt32(command.ExecuteNonQuery());

                connection.Close();

                MessageBox.Show("Пользователь успешно зарегистрировался!\n");

            }
            catch

            {

                MessageBox.Show("Такой пользователь существует!\n");


            }
        }
}
