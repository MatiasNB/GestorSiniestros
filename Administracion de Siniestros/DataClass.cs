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

        public DataClass()
        {
            sqlite = new SQLiteConnection("Data Source = C:/Users/benit/Google Drive/PS/Bases de Datos/General.db");
        }
        //Genericos
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
        
        //Consultas Talleres

        public DataTable GetAllTalleres ()
        {
            return this.getData("select Nombre,Direccion,Telefonos,Mail "
                +"from Talleres");
        }

        public DataTable getListTalleres()
        {
            return this.getData("select Nombre,Direccion,Telefonos,Mail " +
                "from Talleres " +
                "where Listado = 'true'");
        }

        public DataTable findTaller(string find)
        {
            return this.getData("select Nombre,Direccion,Telefonos,Mail  " +
                "from Talleres "+
                "where Nombre like '%"+find+"%'");
        }

        //Consulta Inspectores

        public DataTable getAllInspectores()
        {
            return this.getData("select * "
                + "from Inspectores");
        }

        //Consulta Asegurados

        public DataTable getAsegurado(int i)
        {
            return this.getData("select * "+
                "from Asegurado "+
                "where idCliente = "+i);
        }

        /*
        public void setData(string query, DataRow dr)
        {
            try
            {
                sqlite.Open();
                cmd = sqlite.CreateCommand();
                cmd.CommandText = query;
                cmd.Prepare();
                cmd.Parameters.AddWithValue
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlite.Close();
        }
        */
        // guardar Asegurado
        public void setDataAsegurado(DataRow dr)
        {
            try
            {
                sqlite.Open();
                cmd = sqlite.CreateCommand();
                cmd.CommandText = "insert into Asegurado (idCliente,nombre,telefono,celular,mail,direccion)" +
                                  "values (@id,@nombre,@telefono,@celular,@mail,@direccion)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@id",dr["idCliente"]);
                cmd.Parameters.AddWithValue("@nombre",dr["nombre"]);
                cmd.Parameters.AddWithValue("@telefono",dr["telefono"]);
                cmd.Parameters.AddWithValue("@celular", dr["celular"]);
                cmd.Parameters.AddWithValue("@mail", dr["mail"]);
                cmd.Parameters.AddWithValue("@direccion", dr["direccion"]);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se agrego asegurado");
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlite.Close();
        }

        //Guardar Siniestro

        public void setDataSiniestro(DataRow dr)
        {
            try
            {
                sqlite.Open();
                cmd = sqlite.CreateCommand();
                cmd.CommandText = "insert into Siniestro (idStro,idAsegurado,poliza,fechaSiniestro,fechaDeclaracion,vehiculo,año,dominio,cobertura,idTaller) " +
                                  "values (@idStro,@idAsegurado,@poliza,@fechaSiniestro,@fechaDeclaracion,@vehiculo,@año,@dominio,@cobertura,@idTaller)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@idStro", dr["idStro"]);
                cmd.Parameters.AddWithValue("@idAsegurado", dr["idAsegurado"]);
                cmd.Parameters.AddWithValue("@poliza", dr["poliza"]);
                cmd.Parameters.AddWithValue("@fechaSiniestro", dr["fechaSiniestro"]);
                cmd.Parameters.AddWithValue("@fechaDeclaracion", dr["fechaDeclaracion"]);
                cmd.Parameters.AddWithValue("@vehiculo", dr["vehiculo"]);
                cmd.Parameters.AddWithValue("@año", dr["año"]);
                cmd.Parameters.AddWithValue("@dominio", dr["dominio"]);
                cmd.Parameters.AddWithValue("@cobertura", dr["cobertura"]);
                cmd.Parameters.AddWithValue("@idTaller", null);
               
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se agrego Siniestro");
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlite.Close();
        }
    }
}
