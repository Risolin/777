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
    public partial class FurnitureForm : Form
    {
        public FurnitureForm()
        {
            InitializeComponent();
        }

        private void FurnitureForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "soloveva_OlifirDataSet7.Фурнитура". При необходимости она может быть перемещена или удалена.
            this.фурнитураTableAdapter1.Fill(this.soloveva_OlifirDataSet7.Фурнитура);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "soloveva_OlifirDataSet.Фурнитура". При необходимости она может быть перемещена или удалена.
            // this.фурнитураTableAdapter.Fill(this.soloveva_OlifirDataSet.Фурнитура);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
