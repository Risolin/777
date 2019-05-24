using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class UserForm : Form
    {
        String name;

        public UserForm(String name)
        {
            InitializeComponent();
            this.name = name;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Добро пожаловать," + this.name;
        }
    }
}
