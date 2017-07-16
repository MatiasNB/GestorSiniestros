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
    public partial class FormNuevoSiniestro : Form
    {
        private TextBox auxTextBox; //auxiliar para automatico
        private DataClass data; //auxiliar para conectar con la base de datos
        private DataTable dt; //manejar consultas secundarias
        private DataRow dr;
        private Asegurado aseg;
        //Constructores

        public FormNuevoSiniestro()
        {
            InitializeComponent();
            Clipboard.Clear();
            auxTextBox = this.textBoxIdStro;
            data = new DataClass();
        }

        //Checkbox

        //Automatic
        private void CheckBoxAutomatico_Click(object sender, EventArgs e)
        {
            if (this.checkBoxAutomatico.Checked )
            {
                this.checkBoxAutomatico.Checked = true;
                this.timer.Enabled = true;
            }else
            {
                this.checkBoxAutomatico.Checked = false;
                this.timer.Enabled = false;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                auxTextBox.Text = Clipboard.GetText();
                Clipboard.Clear();
            }
        }

        //TopMost
        private void checkBoxSiempreVisible_Click(object sender, EventArgs e)
        {
            if (checkBoxSiempreVisible.Checked)
            {
                this.checkBoxSiempreVisible.Checked = true;
                this.TopMost = true;
            }
            else
            {
                this.checkBoxSiempreVisible.Checked = false;
                this.TopMost = false;
            }
        }

        //Eventos TextBox
        private void textBox_Click(object sender, EventArgs e)
        {
            (sender as TextBox).Text = "";
        }

        private void textBoxIdStro_TextChanged(object sender, EventArgs e)
        {
            this.textBoxIdStro.ForeColor = System.Drawing.SystemColors.WindowText;
            if (this.checkBoxAutomatico.Enabled) {
                auxTextBox = this.textBoxIdAsegurado;
            }
        }

        private void textBoxIdAsegurado_TextChanged(object sender, EventArgs e)
        {
            this.textBoxIdAsegurado.ForeColor = System.Drawing.SystemColors.WindowText;
            if (this.checkBoxAutomatico.Enabled)
            {
                auxTextBox = this.textBoxPoliza;
            }          
        }

        private void textBoxPoliza_TextChanged(object sender, EventArgs e)
        {
            this.textBoxPoliza.ForeColor = System.Drawing.SystemColors.WindowText;
            if (this.checkBoxAutomatico.Enabled)
            {                
                auxTextBox = this.textBoxFSiniestro;
            }
        }

        private void textBoxFSiniestro_TextChanged(object sender, EventArgs e)
        {
            this.textBoxFSiniestro.ForeColor = System.Drawing.SystemColors.WindowText;
            if (this.checkBoxAutomatico.Enabled)
            {
                auxTextBox = this.textBoxFDeclaracion;
            }
        }

        private void textBoxFDeclaracion_TextChanged(object sender, EventArgs e)
        {
            this.textBoxFDeclaracion.ForeColor = System.Drawing.SystemColors.WindowText;
            if (this.checkBoxAutomatico.Enabled)
            {
                auxTextBox = this.textBoxVehiculo;
            }
        }

        private void textBoxVehiculo_TextChanged(object sender, EventArgs e)
        {
            this.textBoxVehiculo.ForeColor = System.Drawing.SystemColors.WindowText;
            if (this.checkBoxAutomatico.Enabled)
            {
                auxTextBox = this.textBoxAño;
            }
        }

        private void textBoxAño_TextChanged(object sender, EventArgs e)
        {
            this.textBoxAño.ForeColor = System.Drawing.SystemColors.WindowText;
            if (this.checkBoxAutomatico.Enabled)
            {
                auxTextBox = this.textBoxPatente;
            }
        }

        private void textBoxPatente_TextChanged(object sender, EventArgs e)
        {
            this.textBoxPatente.ForeColor = System.Drawing.SystemColors.WindowText;
            if (this.checkBoxAutomatico.Enabled)
            {
                auxTextBox = this.textBoxCobertura;
            }
        }     

        private void textBoxCobertura_TextChanged(object sender, EventArgs e)
        {
            this.textBoxCobertura.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkBoxAutomatico.Checked = false;
            this.timer.Enabled = false;
        }

        private void textBoxAsegurados_TextChanged(object sender, EventArgs e)
        {
            (sender as TextBox).ForeColor = SystemColors.WindowText;
        }
       
        //Botones

       

        private void GuardarSiniestro()
        {
            dt = new DataTable("siniestro");

            dt.Columns.Add("idStro", typeof(int));
            dt.Columns.Add("idAsegurado", typeof(int));
            dt.Columns.Add("poliza", typeof(string));
            dt.Columns.Add("fechaSiniestro", typeof(string));
            dt.Columns.Add("fechaDeclaracion", typeof(string));
            dt.Columns.Add("vehiculo", typeof(string));
            dt.Columns.Add("año", typeof(int));
            dt.Columns.Add("dominio", typeof(string));
            dt.Columns.Add("cobertura", typeof(string));
            try
            {
                dr = dt.NewRow();
                dr["idStro"]=Convert.ToInt32(textBoxIdStro.Text);
                dr["idAsegurado"]=Convert.ToInt32(textBoxIdAsegurado.Text);
                dr["poliza"]=textBoxPoliza.Text;
                dr["fechaSiniestro"] = textBoxFSiniestro.Text;
                dr["fechaDeclaracion"]=textBoxFDeclaracion.Text;
                dr["vehiculo"]=textBoxVehiculo.Text;
                dr["año"]=Convert.ToInt32(textBoxAño.Text);
                dr["dominio"]=textBoxPatente.Text;
                dr["cobertura"]=textBoxCobertura.Text;

                data.setDataSiniestro(dr);
            }
            catch (FormatException) { MessageBox.Show("Debe ser un numero."); }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string messege = "¿Desea Guardas/Actualizar los datos del Asegurado?";
            string caption = "Info Asegurado";
            if (MessageBox.Show(messege,caption,MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                aseg.Nombre = textBoxNombre.Text;
                aseg.Telefono = textBoxTelefono.Text;
                aseg.Celular = textBoxCelular.Text;
                aseg.Mail = textBoxMail.Text;
                aseg.Direccion = textBoxDireccion.Text;
                Asegurado.SaveAsegurado(aseg);
            }
            //this.GuardarSiniestro();
        }

        private void buttonBuscarAseg_Click(object sender, EventArgs e)
        {         
            try
            {
                aseg = new Asegurado(Convert.ToInt32(this.textBoxIdAsegurado.Text));
                
                this.textBoxNombre.Text = aseg.Nombre;
                this.textBoxTelefono.Text = aseg.Telefono;
                this.textBoxCelular.Text = aseg.Celular;
                this.textBoxMail.Text = aseg.Mail;
                this.textBoxDireccion.Text = aseg.Direccion;
                
            }
            catch (FormatException) { MessageBox.Show("Debe ingresar un numero", MessageBoxButtons.OK.ToString()); }

            this.buttonGuardar.Enabled = true;
        }

        
    }
}
