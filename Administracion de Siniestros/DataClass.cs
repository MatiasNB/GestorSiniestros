using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;


namespace Administracion_de_Siniestros
{
    class DataClass
    {
        private SQLiteConnection sqlite;
        private SQLiteDataAdapter ad;
        private SQLiteCommand cmd;
        private DataTable returnDT;

        public DataClass()
        {
            sqlite = new SQLiteConnection("Data Source = C:/Users/benit/Google Drive/PS/Bases de Datos/General.db");
        }

        public DataTable getData (string query)
        {
            
            DataTable dt = new DataTable();
            try
            {
                sqlite.Open();
                cmd = sqlite.CreateCommand();
                cmd.CommandText = query;
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt);
            }
            catch(SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlite.Close();
            return dt;
        }
        public DataTable getAllTalleres ()
        {
            return this.getData("select Nombre,Direccion,Telefonos,Mail "
                +"from Talleres");
        }

        public DataTable getAllInspectores()
        {
            return this.getData("select * "
                + "from Inspectores");
        }
    }
}
