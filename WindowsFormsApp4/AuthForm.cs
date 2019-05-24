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

        }
    }
}
