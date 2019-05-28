namespace WindowsFormsApp4
{
    partial class TkaniForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.soloveva_OlifirDataSet = new WindowsFormsApp4.Soloveva_OlifirDataSet();
            this.solovevaOlifirDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soloveva_OlifirDataSet2 = new WindowsFormsApp4.Soloveva_OlifirDataSet2();
            this.тканиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.тканиTableAdapter = new WindowsFormsApp4.Soloveva_OlifirDataSet2TableAdapters.ТканиTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.артикулDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цветDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рисунокDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.изображениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.составDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ширинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.длинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.тканиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.soloveva_OlifirDataSet6 = new WindowsFormsApp4.Soloveva_OlifirDataSet6();
            this.тканиTableAdapter1 = new WindowsFormsApp4.Soloveva_OlifirDataSet6TableAdapters.ТканиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.soloveva_OlifirDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solovevaOlifirDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soloveva_OlifirDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тканиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тканиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soloveva_OlifirDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = " Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(798, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(920, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // soloveva_OlifirDataSet
            // 
            this.soloveva_OlifirDataSet.DataSetName = "Soloveva_OlifirDataSet";
            this.soloveva_OlifirDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // solovevaOlifirDataSetBindingSource
            // 
            this.solovevaOlifirDataSetBindingSource.DataSource = this.soloveva_OlifirDataSet;
            this.solovevaOlifirDataSetBindingSource.Position = 0;
            // 
            // soloveva_OlifirDataSet2
            // 
            this.soloveva_OlifirDataSet2.DataSetName = "Soloveva_OlifirDataSet2";
            this.soloveva_OlifirDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // тканиBindingSource
            // 
            this.тканиBindingSource.DataMember = "Ткани";
            this.тканиBindingSource.DataSource = this.soloveva_OlifirDataSet2;
            // 
            // тканиTableAdapter
            // 
            this.тканиTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.артикулDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.цветDataGridViewTextBoxColumn,
            this.рисунокDataGridViewTextBoxColumn,
            this.изображениеDataGridViewTextBoxColumn,
            this.составDataGridViewTextBoxColumn,
            this.ширинаDataGridViewTextBoxColumn,
            this.длинаDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.тканиBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1042, 375);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // артикулDataGridViewTextBoxColumn
            // 
            this.артикулDataGridViewTextBoxColumn.DataPropertyName = "Артикул";
            this.артикулDataGridViewTextBoxColumn.HeaderText = "Артикул";
            this.артикулDataGridViewTextBoxColumn.Name = "артикулDataGridViewTextBoxColumn";
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            // 
            // цветDataGridViewTextBoxColumn
            // 
            this.цветDataGridViewTextBoxColumn.DataPropertyName = "Цвет";
            this.цветDataGridViewTextBoxColumn.HeaderText = "Цвет";
            this.цветDataGridViewTextBoxColumn.Name = "цветDataGridViewTextBoxColumn";
            // 
            // рисунокDataGridViewTextBoxColumn
            // 
            this.рисунокDataGridViewTextBoxColumn.DataPropertyName = "Рисунок";
            this.рисунокDataGridViewTextBoxColumn.HeaderText = "Рисунок";
            this.рисунокDataGridViewTextBoxColumn.Name = "рисунокDataGridViewTextBoxColumn";
            // 
            // изображениеDataGridViewTextBoxColumn
            // 
            this.изображениеDataGridViewTextBoxColumn.DataPropertyName = "Изображение";
            this.изображениеDataGridViewTextBoxColumn.HeaderText = "Изображение";
            this.изображениеDataGridViewTextBoxColumn.Name = "изображениеDataGridViewTextBoxColumn";
            // 
            // составDataGridViewTextBoxColumn
            // 
            this.составDataGridViewTextBoxColumn.DataPropertyName = "Состав";
            this.составDataGridViewTextBoxColumn.HeaderText = "Состав";
            this.составDataGridViewTextBoxColumn.Name = "составDataGridViewTextBoxColumn";
            // 
            // ширинаDataGridViewTextBoxColumn
            // 
            this.ширинаDataGridViewTextBoxColumn.DataPropertyName = "Ширина";
            this.ширинаDataGridViewTextBoxColumn.HeaderText = "Ширина";
            this.ширинаDataGridViewTextBoxColumn.Name = "ширинаDataGridViewTextBoxColumn";
            // 
            // длинаDataGridViewTextBoxColumn
            // 
            this.длинаDataGridViewTextBoxColumn.DataPropertyName = "Длина";
            this.длинаDataGridViewTextBoxColumn.HeaderText = "Длина";
            this.длинаDataGridViewTextBoxColumn.Name = "длинаDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // тканиBindingSource1
            // 
            this.тканиBindingSource1.DataMember = "Ткани";
            this.тканиBindingSource1.DataSource = this.soloveva_OlifirDataSet6;
            // 
            // soloveva_OlifirDataSet6
            // 
            this.soloveva_OlifirDataSet6.DataSetName = "Soloveva_OlifirDataSet6";
            this.soloveva_OlifirDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // тканиTableAdapter1
            // 
            this.тканиTableAdapter1.ClearBeforeFill = true;
            // 
            // TkaniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "TkaniForm";
            this.Text = "TkaniForm";
            this.Load += new System.EventHandler(this.TkaniForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.soloveva_OlifirDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solovevaOlifirDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soloveva_OlifirDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тканиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тканиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soloveva_OlifirDataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource solovevaOlifirDataSetBindingSource;
        private Soloveva_OlifirDataSet soloveva_OlifirDataSet;
        private Soloveva_OlifirDataSet2 soloveva_OlifirDataSet2;
        private System.Windows.Forms.BindingSource тканиBindingSource;
        private Soloveva_OlifirDataSet2TableAdapters.ТканиTableAdapter тканиTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Soloveva_OlifirDataSet6 soloveva_OlifirDataSet6;
        private System.Windows.Forms.BindingSource тканиBindingSource1;
        private Soloveva_OlifirDataSet6TableAdapters.ТканиTableAdapter тканиTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn артикулDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn цветDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рисунокDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn изображениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn составDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ширинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn длинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
    }
}