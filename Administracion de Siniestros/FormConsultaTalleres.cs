﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administracion_de_Siniestros
{
    public partial class FormConsultaTalleres : Form
    {
        private DataClass data;
        public FormConsultaTalleres()
        {
            InitializeComponent();
            data = new DataClass();
            bindingSource1.DataSource = data.GetAllTalleres();
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Columns[0].Width = 120;
            dataGridView1.Columns[1].Width = 130;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 200;
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTodos_Click(object sender, EventArgs e)
        {
            bindingSource1.DataSource = data.GetAllTalleres();
        }

        private void buttonListado_Click(object sender, EventArgs e)
        {
            bindingSource1.DataSource = data.getListTalleres();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bindingSource1.DataSource = data.findTaller(textBox1.Text);
        }
    }
}
