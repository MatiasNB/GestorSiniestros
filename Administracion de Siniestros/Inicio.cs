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
        public Inicio()
        {
            InitializeComponent();
        }

        private void inspectoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaInspectores f = new FormConsultaInspectores();
            f.ShowDialog();
        }

        private void talleresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaTalleres f = new FormConsultaTalleres();
            f.ShowDialog();
        }
    }
}
