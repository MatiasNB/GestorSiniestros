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
    public partial class FormConsultaTalleres : Form
    {
        private DataClass data;
        public FormConsultaTalleres()
        {
            InitializeComponent();
            data = new DataClass();
            bindingSource1.DataSource = data.getAllTalleres();
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Columns[0].Width = 120;
            dataGridView1.Columns[1].Width = 130;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 200;
        }
        public void gridViewSource (DataTable dt)
        {
            
            //dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[0].Width = 120;
            dataGridView1.Columns[1].Width = 130;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 200;
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
