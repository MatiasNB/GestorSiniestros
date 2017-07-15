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
    public partial class FormConsulta : Form
    {
        public FormConsulta(string text)
        {
            InitializeComponent();
            switch (text)
            {
                case "Inspectores":
                    MessageBox.Show("Inspectores");
                    break;
                case "Talleres":
                    MessageBox.Show("Talleres");
                    break;
                default:
                    MessageBox.Show(text);
                    break;
            }
        }
        public void gridViewSource (DataTable dt)
        {
            bindingSource1.DataSource = dt;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 130;
            dataGridView1.Columns[2].Width = 104;
            dataGridView1.Columns[3].Width = 190;
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
