using System;
using System.Windows.Forms;
using System.Drawing;

namespace Administracion_de_Siniestros
{
    class DataGridViewInspecciones : DataGridView
    {
        public DataGridViewInspecciones():base() { }
        
        public void MostrarVencimientos()
        {
            foreach (DataGridViewRow row in this.Rows)
            {
                if (Convert.ToInt32(row.Cells["demora"].Value) == 1)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if (Convert.ToInt32(row.Cells["demora"].Value) > 1)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        public void Inicializar()
        {
            this.Columns["id"].Width = 40;
            this.Columns["id"].HeaderText = "ID";
            this.Columns["id"].ReadOnly = true;
            this.Columns["Nombre"].Width = 120;
            this.Columns["Nombre"].HeaderText = "Nombre Inspector";
            this.Columns["Nombre"].ReadOnly = true;
            this.Columns["idSiniestro"].Width = 90;
            this.Columns["idSiniestro"].HeaderText = "N° Siniestro";
            this.Columns["idSiniestro"].ReadOnly = true;
            this.Columns["fechaIP"].Width = 80;
            this.Columns["fechaIP"].HeaderText = "Fecha Inspecion";
            this.Columns["fechaIP"].ReadOnly = true;
            this.Columns["fechaActa"].Width = 80;
            this.Columns["fechaActa"].HeaderText = "Fecha Acta";
            this.Columns["demora"].Width = 50;
            this.Columns["demora"].HeaderText = "Demora";
            this.Columns["demora"].ReadOnly = true;
            this.Columns["finalizar"].Width = 50;
            this.Columns["finalizar"].HeaderText = "Finalizar";
            this.Columns["Observaciones"].Width = 200;
            this.Columns["Observaciones"].HeaderText = "Observaciones";
        }
        
    }
}
