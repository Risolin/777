namespace WindowsFormsApp4
{
    partial class ConstructorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.тканиBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.soloveva_OlifirDataSet11 = new WindowsFormsApp4.Soloveva_OlifirDataSet11();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.фурнитураBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soloveva_OlifirDataSet9 = new WindowsFormsApp4.Soloveva_OlifirDataSet9();
            this.soloveva_OlifirDataSet8 = new WindowsFormsApp4.Soloveva_OlifirDataSet8();
            this.тканиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.тканиTableAdapter = new WindowsFormsApp4.Soloveva_OlifirDataSet8TableAdapters.ТканиTableAdapter();
            this.фурнитураTableAdapter = new WindowsFormsApp4.Soloveva_OlifirDataSet9TableAdapters.ФурнитураTableAdapter();
            this.soloveva_OlifirDataSet10 = new WindowsFormsApp4.Soloveva_OlifirDataSet10();
            this.тканиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.тканиTableAdapter1 = new WindowsFormsApp4.Soloveva_OlifirDataSet10TableAdapters.ТканиTableAdapter();
            this.тканиTableAdapter2 = new WindowsFormsApp4.Soloveva_OlifirDataSet11TableAdapters.ТканиTableAdapter();
            this.soloveva_OlifirDataSet12 = new WindowsFormsApp4.Soloveva_OlifirDataSet12();
            this.фурнитураBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.фурнитураTableAdapter1 = new WindowsFormsApp4.Soloveva_OlifirDataSet12TableAdapters.ФурнитураTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.тканиBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soloveva_OlifirDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фурнитураBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soloveva_OlifirDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soloveva_OlifirDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тканиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soloveva_OlifirDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тканиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soloveva_OlifirDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фурнитураBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(77, 198);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(184, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(77, 242);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(184, 20);
            this.textBox5.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 22);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить ткань";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 26);
            this.button2.TabIndex = 6;
            this.button2.Text = "Просмотр";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(593, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Закрыть";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(693, 366);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Сохранить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(293, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 302);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Название изделия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Тип ткани";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Длина";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ширина";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Тип фурнитуры";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Схема изделия";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.тканиBindingSource2;
            this.comboBox1.DisplayMember = "Наименование";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(77, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // тканиBindingSource2
            // 
            this.тканиBindingSource2.DataMember = "Ткани";
            this.тканиBindingSource2.DataSource = this.soloveva_OlifirDataSet11;
            // 
            // soloveva_OlifirDataSet11
            // 
            this.soloveva_OlifirDataSet11.DataSetName = "Soloveva_OlifirDataSet11";
            this.soloveva_OlifirDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.фурнитураBindingSource1;
            this.comboBox2.DisplayMember = "Наименование";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(77, 301);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(184, 21);
            this.comboBox2.TabIndex = 15;
            this.comboBox2.ValueMember = "id";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // фурнитураBindingSource
            // 
            this.фурнитураBindingSource.DataMember = "Фурнитура";
            this.фурнитураBindingSource.DataSource = this.soloveva_OlifirDataSet9;
            // 
            // soloveva_OlifirDataSet9
            // 
            this.soloveva_OlifirDataSet9.DataSetName = "Soloveva_OlifirDataSet9";
            this.soloveva_OlifirDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // soloveva_OlifirDataSet8
            // 
            this.soloveva_OlifirDataSet8.DataSetName = "Soloveva_OlifirDataSet8";
            this.soloveva_OlifirDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // тканиBindingSource
            // 
            this.тканиBindingSource.DataMember = "Ткани";
            this.тканиBindingSource.DataSource = this.soloveva_OlifirDataSet8;
            // 
            // тканиTableAdapter
            // 
            this.тканиTableAdapter.ClearBeforeFill = true;
            // 
            // фурнитураTableAdapter
            // 
            this.фурнитураTableAdapter.ClearBeforeFill = true;
            // 
            // soloveva_OlifirDataSet10
            // 
            this.soloveva_OlifirDataSet10.DataSetName = "Soloveva_OlifirDataSet10";
            this.soloveva_OlifirDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // тканиBindingSource1
            // 
            this.тканиBindingSource1.DataMember = "Ткани";
            this.тканиBindingSource1.DataSource = this.soloveva_OlifirDataSet10;
            // 
            // тканиTableAdapter1
            // 
            this.тканиTableAdapter1.ClearBeforeFill = true;
            // 
            // тканиTableAdapter2
            // 
            this.тканиTableAdapter2.ClearBeforeFill = true;
            // 
            // soloveva_OlifirDataSet12
            // 
            this.soloveva_OlifirDataSet12.DataSetName = "Soloveva_OlifirDataSet12";
            this.soloveva_OlifirDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // фурнитураBindingSource1
            // 
            this.фурнитураBindingSource1.DataMember = "Фурнитура";
            this.фурнитураBindingSource1.DataSource = this.soloveva_OlifirDataSet12;
            // 
            // фурнитураTableAdapter1
            // 
            this.фурнитураTableAdapter1.ClearBeforeFill = true;
            // 
            // ConstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Name = "ConstructorForm";
            this.Text = "ConstructorForm";
            this.Load += new System.EventHandler(this.ConstructorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.тканиBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soloveva_OlifirDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фурнитураBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soloveva_OlifirDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soloveva_OlifirDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тканиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soloveva_OlifirDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тканиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soloveva_OlifirDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фурнитураBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private Soloveva_OlifirDataSet8 soloveva_OlifirDataSet8;
        private System.Windows.Forms.BindingSource тканиBindingSource;
        private Soloveva_OlifirDataSet8TableAdapters.ТканиTableAdapter тканиTableAdapter;
        private Soloveva_OlifirDataSet9 soloveva_OlifirDataSet9;
        private System.Windows.Forms.BindingSource фурнитураBindingSource;
        private Soloveva_OlifirDataSet9TableAdapters.ФурнитураTableAdapter фурнитураTableAdapter;
        private Soloveva_OlifirDataSet10 soloveva_OlifirDataSet10;
        private System.Windows.Forms.BindingSource тканиBindingSource1;
        private Soloveva_OlifirDataSet10TableAdapters.ТканиTableAdapter тканиTableAdapter1;
        private Soloveva_OlifirDataSet11 soloveva_OlifirDataSet11;
        private System.Windows.Forms.BindingSource тканиBindingSource2;
        private Soloveva_OlifirDataSet11TableAdapters.ТканиTableAdapter тканиTableAdapter2;
        private Soloveva_OlifirDataSet12 soloveva_OlifirDataSet12;
        private System.Windows.Forms.BindingSource фурнитураBindingSource1;
        private Soloveva_OlifirDataSet12TableAdapters.ФурнитураTableAdapter фурнитураTableAdapter1;
    }
}