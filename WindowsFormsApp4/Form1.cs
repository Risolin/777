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

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public partial class AuthForm : Form { }
 
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Параметр);

            Form auth; // null

            public Form1()
                {
                InitializeComponent();
                }

          

        private void button1_Click(object sender, EventArgs e)
        {
            int errors = 0;

            String message = "";


            if(textBox1.Text == "")
            {
                errors++;   
                message += "Пожалуйста введите имя\n";

            }
            if (textBox2.Text == "")
            {
                errors++;
                message += "Пожалуйста введите логин\n";

            }
            if (textBox3.Text == "")
            {
                errors++;
                message += "Пожалуйста введите пароль\n";

            }
            if (textBox4.Text == "")
            {
                errors++;
                message += "Подтвердите пароль\n";

            }
            if (textBox3.Text != textBox4.Text)
            {
                errors++;
                message += "Пароли не совпадают!\n";
            }
            if (errors>0)
            {
                MessageBox.Show(message);
            }
            else
            {
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
                    MessageBox.Show("Такой пользователь уже существует.");
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            auth = new AuthForm();
            auth.Show();
        }
    }
}
