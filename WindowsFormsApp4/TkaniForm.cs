using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Data.SqlClient;

using System.Drawing;

using System.IO;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class TkaniForm : Form
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.Параметр);
        WareForm ware;
        DataSet changes;
        DataSet ds;
        SqlDataAdapter sda;

        public TkaniForm()
        {
            InitializeComponent();
        }
        public void LoadList()

        {

            String query = "SELECT * FROM Ткани";

            sda = new SqlDataAdapter(query, connection);

            ds = new DataSet();

            sda.Fill(ds, "Ткани");

            dataGridView1.DataSource = ds.Tables["Ткани"];

/*

            DataGridViewImageColumn img = new DataGridViewImageColumn();

            img.Name = "img";

            img.HeaderText = "Картинка";

            dataGridView1.Columns.Add(img);

            for (int i = 0; i < dataGridView1.RowCount; i++)

            {

                if (dataGridView1.Rows[i].Cells[1].Value != null)

                {

                //    string basePath = "C:/Users/lickett2019/source/repos/App/App/images/tkani/";

                    string filename = dataGridView1.Rows[i].Cells[1].Value.ToString() + ".jpg";

                    string fullPath = basePath + filename;

                    Image image;

                    if (File.Exists(fullPath))

                    {

                        image = Image.FromFile(fullPath);

                    }

                    else

                    {

                        image = Image.FromFile(basePath + "empty.jpg");

                    }

                    dataGridView1.Rows[i].Cells["img"].Value = image;

                }

            }


            */
        }
      

        private void TkaniForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "soloveva_OlifirDataSet6.Ткани". При необходимости она может быть перемещена или удалена.
            //   this.тканиTableAdapter1.Fill(this.soloveva_OlifirDataSet6.Ткани);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "soloveva_OlifirDataSet2.Ткани". При необходимости она может быть перемещена или удалена.
            //  this.тканиTableAdapter.Fill(this.soloveva_OlifirDataSet2.Ткани);
            



                LoadList();

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

                foreach (DataGridViewRow items in dataGridView1.SelectedRows)

                {

                    dataGridView1.Rows.RemoveAt(items.Index);

                }

                button3_Click(sender, e);

            }
        

        private void button3_Click(object sender, EventArgs e)
        {

            changes = ds.GetChanges();

            if (changes != null)

            {

                SqlCommandBuilder builder = new SqlCommandBuilder(sda);

                builder.GetInsertCommand();

                int updatesRows = sda.Update(changes, "Ткани");

                ds.AcceptChanges();

            }

            LoadList();





            MessageBox.Show("Успешно!", "Заголовок", MessageBoxButtons.OKCancel);



        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
