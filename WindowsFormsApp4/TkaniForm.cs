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
    public partial class TkaniForm : Form
    {
        public TkaniForm()
        {
            InitializeComponent();
        }

        private void TkaniForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "soloveva_OlifirDataSet6.Ткани". При необходимости она может быть перемещена или удалена.
            this.тканиTableAdapter1.Fill(this.soloveva_OlifirDataSet6.Ткани);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "soloveva_OlifirDataSet2.Ткани". При необходимости она может быть перемещена или удалена.
          //  this.тканиTableAdapter.Fill(this.soloveva_OlifirDataSet2.Ткани);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
