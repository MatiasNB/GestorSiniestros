using System;
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
    public partial class FormConsultaInspectores : Form
    {
        private DataClass data;
        public FormConsultaInspectores()
        {
            InitializeComponent();
            data = new DataClass();
            bindingSource1.DataSource = data.getAllInspectores();
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 110;
            dataGridView1.Columns[3].Width = 190;
        }
        public void gridViewSource (DataTable dt)
        {
            bindingSource1.DataSource = dt;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 110;
            dataGridView1.Columns[3].Width = 190;
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
