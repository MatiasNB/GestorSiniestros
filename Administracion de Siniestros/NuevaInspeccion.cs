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
    public partial class NuevaInspeccion : Form
    {
        private Boolean stro=false, inspector=false;
        private Inspecciones ip;

        public NuevaInspeccion()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            inspector = true;
            if (stro && inspector)
            {
                buttonGuardar.Enabled = true;
                buttonGuardarCargar.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            stro = true;
            if (stro && inspector)
            {
                buttonGuardar.Enabled = true;
                buttonGuardarCargar.Enabled = true;
            }
            this.textBox1.TextChanged -= textBox1_TextChanged;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            ip = new Inspecciones();
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Eduardo":
                    ip.IdInspector =19357;
                    break;
                case "Diego":
                    ip.IdInspector = 28198;
                    break;
                case "Fernando":
                    ip.IdInspector = 62428;
                    break;
                case "Dario":
                    ip.IdInspector = 66748;
                    break;
                default:
                    MessageBox.Show("Opcion no disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
            ip.IdSiniestro = Convert.ToInt32( textBox1.Text);
            ip.FechaIp = dateTimePicker1.Value.Date;
            ip.Observaciones = textBox2.Text;
            ip.InsertInspeccion();
            this.Close();
        }

        private void buttonGuardarCargar_Click(object sender, EventArgs e)
        {
            ip = new Inspecciones();
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Eduardo":
                    ip.IdInspector = 19357;
                    break;
                case "Diego":
                    ip.IdInspector = 28198;
                    break;
                case "Fernando":
                    ip.IdInspector = 62428;
                    break;
                case "Dario":
                    ip.IdInspector = 66748;
                    break;
                default:
                    MessageBox.Show("Opcion no disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
            ip.IdSiniestro = Convert.ToInt32(textBox1.Text);
            ip.FechaIp = dateTimePicker1.Value.Date;
            ip.Observaciones = textBox2.Text;
            ip.InsertInspeccion();
            this.clear();
        }

        private void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
