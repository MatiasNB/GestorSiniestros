using System;
using System.Data;
using System.Windows.Forms;

namespace Administracion_de_Siniestros
{
    class Asegurado
    {
        private Boolean modificado;
        private Boolean existe;
        private static DataClass data = new DataClass();

        private int id;
        private string nombre;
        private string telefono;
        private string celular;
        private string mail;
        private string direccion;

        public Asegurado(int id)
        {
            this.Id = id;
            this.existe = false;
            FindAsegurado(this);
        }

        public Boolean Existe { get { return existe; } }
        public Boolean Modificado { get { return modificado; } }

        public int Id {
            get
            {
                return id;
            }
            set
            {
                if (!existe) { id = value; }
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (value != "")
                {
                    nombre = value;
                }else
                {
                    nombre = null;
                }
                modificado = true;
            }
        }
        public string Telefono
        {
            get
            {
                return telefono;
            }
            set
            {
                if (value != "")
                {
                    telefono = value;
                }
                else
                {
                    telefono = null;
                }
                modificado = true;
            }
        }
        public string Celular {
            get
            {
                return celular;
            }
            set
            {
                if (value != "")
                {
                    celular = value;
                }
                else
                {
                    celular = null;
                }
                modificado = true;
            }
        }
        public string Mail
        {
            get
            {
                return mail;
            }
            set
            {
                if (value != "")
                {
                    mail = value;
                }
                else
                {
                    mail = null;
                }
                modificado = true;
            }
        }
        public string Direccion
        {
            get
            {
                return direccion;
            }
            set
            {
                if (value != "")
                {
                    direccion = value;
                }
                else
                {
                    direccion = null;
                }
                modificado = true;
            }
        }

        static void FindAsegurado(Asegurado aseg)
        {
            DataTable dt = data.getAsegurado(aseg.Id);
            if (dt.Rows.Count == 1)
            {
                aseg.existe = true;
                aseg.Nombre = dt.Rows[0]["nombre"].ToString();
                aseg.Telefono = dt.Rows[0]["telefono"].ToString();
                aseg.Celular = dt.Rows[0]["celular"].ToString();
                aseg.Mail = dt.Rows[0]["mail"].ToString();
                aseg.Direccion = dt.Rows[0]["direccion"].ToString();
            }
            else
            {
                MessageBox.Show("Asegurado no registrado. Por ingresar sus datos");
                aseg.existe = false;
            }
        }
        public static void SaveAsegurado(Asegurado aseg)
        {
            if (!aseg.Existe)
            {
                data.SetDataAsegurado(aseg);
            }else if (aseg.Modificado)
            {
                data.UpdateAsegurado(aseg);
            }
        }
    }
}
