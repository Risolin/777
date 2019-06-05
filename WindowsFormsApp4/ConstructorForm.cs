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
    public partial class ConstructorForm : Form
    {
        

        private class Tkani

        {

            public int id { get; set; }


            public string Наименование { get; set; }

            public string Цвет { get; set; }

            public double Цена { get; set; }



            public Tkani(int i, string n, string c, double p)

            {

                id = i;

                Наименование = n;

                Цвет = c;

                Цена = p;

            }

        }
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.Параметр);

        string name;
        public ConstructorForm(string name)
        {
            InitializeComponent();
            this.name = name;
        }

        private void ConstructorForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "soloveva_OlifirDataSet12.Фурнитура". При необходимости она может быть перемещена или удалена.
            this.фурнитураTableAdapter1.Fill(this.soloveva_OlifirDataSet12.Фурнитура);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "soloveva_OlifirDataSet11.Ткани". При необходимости она может быть перемещена или удалена.
            this.тканиTableAdapter2.Fill(this.soloveva_OlifirDataSet11.Ткани);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "soloveva_OlifirDataSet10.Ткани". При необходимости она может быть перемещена или удалена.
            this.тканиTableAdapter1.Fill(this.soloveva_OlifirDataSet10.Ткани);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "soloveva_OlifirDataSet9.Фурнитура". При необходимости она может быть перемещена или удалена.
            this.фурнитураTableAdapter.Fill(this.soloveva_OlifirDataSet9.Фурнитура);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "soloveva_OlifirDataSet8.Ткани". При необходимости она может быть перемещена или удалена.
            this.тканиTableAdapter.Fill(this.soloveva_OlifirDataSet8.Ткани);


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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form addtkan = new AddTkani();
            addtkan.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int selected_tkani = Convert.ToInt32(comboBox1.SelectedValue);
            int selected_furniture = Convert.ToInt32(comboBox2.SelectedValue);
             
            //try

            //{

                connection.Open();

                Random random = new Random();

                String artikul = "User-" + random.Next(1000000);

                SqlCommand command = new SqlCommand("INSERT INTO Изделия ( Артикул, Наименование, Длина, Ширина) " +

                    "VALUES (@Artikul,@name,@width,@height); SELECT SCOPE_IDENTITY(); ", connection);

                command.Parameters.AddWithValue("@Artikul", artikul);

                command.Parameters.AddWithValue("@name", textBox1.Text);

                command.Parameters.AddWithValue("@width", textBox5.Text);

                command.Parameters.AddWithValue("@height", textBox3.Text);

              


            int izdelie = Convert.ToInt32(command.ExecuteScalar());
                 


                SqlCommand command1 = new SqlCommand("INSERT INTO Фурнитура_изделия (id фурнитуры, id изделия,Артикул изделия, Ширина, Длина ) " +

                   "VALUES (" + selected_furniture + "," + izdelie + ", 0, 0, 0, 0, 0);", connect  ion);

                  command.Parameters.AddWithValue("@Artikul", artikul);

                  command.Parameters.AddWithValue("@Artikul", artikul);

                  command.Parameters.AddWithValue("@Artikul", artikul);

                  command.Parameters.AddWithValue("@width", textBox5.Text);

                  command.Parameters.AddWithValue("@height", textBox3.Text);

                


            

            command1.ExecuteScalar();



                SqlCommand command2 = new SqlCommand("INSERT INTO Ткани изделия (Артикул ткани, Артикул изделия) " +

                  "VALUES (" + selected_tkani + "," + izdelie + ");", connection);

                command2.ExecuteScalar();



                MessageBox.Show("Изделие успешно добавлено");

                textBox1.Text = "";

                textBox5.Text = "";

                textBox3.Text = "";

                connection.Close();
            //}

            //catch

            //{
            //    MessageBox.Show("Ошибка !\n");
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Draw();
        }
        private void Draw()

        {



            if (textBox3.Text.Trim().Length == 0 || textBox5.Text.Trim().Length == 0)

            {

                MessageBox.Show("Введите размеры изделия!");

            }
            else

            {

                Graphics g = panel1.CreateGraphics();

                g.Clear(Color.White);

                Pen p = new Pen(Color.Black, 1);

                int w = Convert.ToInt32(textBox3.Text.Trim());

                int h = Convert.ToInt32(textBox5.Text.Trim());

                g.DrawRectangle(p, 10, 10, w, h);



                DataRowView item = (DataRowView)comboBox1.SelectedItem;

                String color = item.Row.ItemArray[3].ToString();

                String ris = item.Row.ItemArray[4].ToString();

                Brush brush;

                if (ris.Contains("jpg"))

                {

                    Image img = Image.FromFile(ris);

                    Bitmap bimage = new Bitmap(img);

                    TextureBrush tb = new TextureBrush(bimage);

                    g.FillRectangle(tb, 11, 11, w - 1, h - 1);

                }

                else

                {

                    switch (color)

                    {

                        case "красный":

                            brush = new SolidBrush(Color.Yellow);

                            g.FillRectangle(brush, 11, 11, w - 1, h - 1);

                            break;

                        case "зеленый":

                            brush = new SolidBrush(Color.FromArgb(255, 0, 255, 0));

                            g.FillRectangle(brush, 11, 11, w - 1, h - 1);

                            break;

                        default:

                            brush = new SolidBrush(Color.White);

                            g.FillRectangle(brush, 11, 11, w - 1, h - 1);

                            break;

                    }

                }

            }





        }
    }

   }


