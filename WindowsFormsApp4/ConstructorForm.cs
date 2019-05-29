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
    public partial class ConstructorForm : Form
    {
        string name;
        public ConstructorForm(string name)
        {
            InitializeComponent();
            this.name = name;
        }

        private void ConstructorForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            UserForm user = new UserForm(this.name);
            user.Show();
        }
    }
}
