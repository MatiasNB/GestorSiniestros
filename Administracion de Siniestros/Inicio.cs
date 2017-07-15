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
    public partial class Inicio : Form
    {
        DataClass data;
        public Inicio()
        {
            InitializeComponent();
            data = new DataClass();
        }

        private void inspectoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaInspectores f = new FormConsultaInspectores((sender as ToolStripMenuItem).Text);
            f.gridViewSource (data.getData("select * from Inspectores"));
            f.ShowDialog();
        }

        private void talleresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaInspectores f = new FormConsultaInspectores((sender as ToolStripMenuItem).Text);
            f.gridViewSource(data.getData("select * from Talleres"));
            f.ShowDialog();
        }
    }
}
