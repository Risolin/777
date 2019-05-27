﻿using System;
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
            label1.Text = "Добро пожаловать, " + this.name;
        }

        private void изделияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IzdelieForm izdelieForm = new IzdelieForm();
            izdelieForm.Show();
            this.Hide();

        }

        private void тканиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TkaniForm izdelieForm = new TkaniForm();
            izdelieForm.Show();
            this.Hide();
        }

        private void фурнитураToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FurnitureForm izdelieForm = new FurnitureForm();
            izdelieForm.Show();
            this.Hide();
        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderListForm izdelieForm = new OrderListForm();
            izdelieForm.Show();
            this.Hide();
        }
    }
}
