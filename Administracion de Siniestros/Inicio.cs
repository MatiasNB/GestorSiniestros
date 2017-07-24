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

        private void Inicio_Load(object sender, EventArgs e)
        {
            this.ips = new Inspecciones();
            dataGridViewInspecciones1.DataSource = this.ips.InspeccionesActivas();
            dataGridViewInspecciones1.MostrarVencimientos();
            dataGridViewInspecciones1.Inicializar();
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

        private void siniestroNuevo_Click(object sender, EventArgs e)
        {
            FormNuevoSiniestro f = new FormNuevoSiniestro();
            f.ShowDialog();
        }

        private void buttonActivas_Click(object sender, EventArgs e)
        {
            dataGridViewInspecciones1.DataSource = this.ips.InspeccionesActivas();
            dataGridViewInspecciones1.MostrarVencimientos();
        }

        private void dataGridViewInspecciones1_Sorted(object sender, EventArgs e)
        {
            dataGridViewInspecciones1.MostrarVencimientos();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
              switch (comboBox1.SelectedItem.ToString())
              {
                case "Todas":
                    dataGridViewInspecciones1.DataSource = this.ips.InspeccionesTodas();
                    dataGridViewInspecciones1.MostrarVencimientos();
                    break;
                case "Eduardo":
                    dataGridViewInspecciones1.DataSource = this.ips.GetInspeccionesInspector(19357);
                    dataGridViewInspecciones1.MostrarVencimientos();
                    break;
                case "Diego":
                    dataGridViewInspecciones1.DataSource = this.ips.GetInspeccionesInspector(28198);
                    dataGridViewInspecciones1.MostrarVencimientos();
                    break;
                case "Fernando":
                    dataGridViewInspecciones1.DataSource = this.ips.GetInspeccionesInspector(62428);
                    dataGridViewInspecciones1.MostrarVencimientos();
                    break;
                case "Dario":
                    dataGridViewInspecciones1.DataSource = this.ips.GetInspeccionesInspector(66748);
                    dataGridViewInspecciones1.MostrarVencimientos();
                    break;
                default: MessageBox.Show("Opcion no disponible","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    break;
              } 
        }

        private void buttonNuevaInspeccion_Click(object sender, EventArgs e)
        {
            NuevaInspeccion nueva = new NuevaInspeccion();
            nueva.Show();
        }

        private void buttonActualiarInspecciones_Click(object sender, EventArgs e)
        {
            DataTable dt = dataGridViewInspecciones1.DataSource as DataTable;
            foreach (DataRow dr in dt.Rows)
            {
                if (dr.RowState == DataRowState.Modified)
                {
                    this.ips.SetModificado(dr);
                }
            }
        }

        private void textBoxFindInspecciones_TextChanged(object sender, EventArgs e)
        {
            dataGridViewInspecciones1.DataSource = this.ips.FindInspeccion(textBoxFindInspecciones.Text);
            dataGridViewInspecciones1.MostrarVencimientos();
        }
    }
}
