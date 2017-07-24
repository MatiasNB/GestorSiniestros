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
            sqlite = new SQLiteConnection("Data Source = DataBase.db");
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

        // guardar Asegurado
        public void SetDataAsegurado(Asegurado aseg)
        {
            try
            {
                sqlite.Open();
                cmd = sqlite.CreateCommand();
                cmd.CommandText = "insert into Asegurado (idCliente,nombre,telefono,celular,mail,direccion)" +
                                  "values (@id,@nombre,@telefono,@celular,@mail,@direccion)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@id",aseg.Id);
                cmd.Parameters.AddWithValue("@nombre",aseg.Nombre);
                cmd.Parameters.AddWithValue("@telefono",aseg.Telefono);
                cmd.Parameters.AddWithValue("@celular", aseg.Celular);
                cmd.Parameters.AddWithValue("@mail", aseg.Mail);
                cmd.Parameters.AddWithValue("@direccion", aseg.Direccion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se agrego asegurado");
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message,"Error Base de Datos", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            sqlite.Close();
        }

        //UpData Asegurado
        public void UpdateAsegurado(Asegurado aseg)
        {
            try
            {
                sqlite.Open();
                cmd = sqlite.CreateCommand();
                cmd.CommandText = "update Asegurado " +
                    "set nombre=@nombre, telefono=@telefono, celular=@celular,mail=@mail,direccion=@direccion " +
                    "where idCliente=@id";

                cmd.Parameters.Add("@id", DbType.Int32).Value = aseg.Id;
                cmd.Parameters.Add("@nombre", DbType.String).Value = aseg.Nombre;
                cmd.Parameters.Add("@telefono", DbType.String).Value = aseg.Telefono;
                cmd.Parameters.Add("@celular", DbType.String).Value = aseg.Celular;
                cmd.Parameters.Add("@mail", DbType.String).Value = aseg.Mail;
                cmd.Parameters.Add("@direccion", DbType.String).Value = aseg.Direccion;
                cmd.ExecuteNonQuery();

                string messege = "Se ha actualizado Asegurado";
                string caption = "Listo";
                MessageBox.Show(messege,caption,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "Error Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        //Update Inspecciones Finalizado

        public void SetRowInspecciones(DataRow dr)
        {
            try
            {
                sqlite.Open();
                cmd = sqlite.CreateCommand();
                cmd.CommandText = "update Inspecciones " +
                    "set finalizar=@Finalizar, fechaActa=@fecha, Observaciones=@Observaciones, idSiniestro=@idSiniestro " +
                    "where id=@id";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@id", dr["id"]);
                if (dr["finalizar"].ToString() == "True")
                {
                    cmd.Parameters.AddWithValue("@finalizar", dr["finalizar"]);
                    cmd.Parameters.AddWithValue("@fecha", DateTime.Now.ToLocalTime().Date);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@finalizar", dr["finalizar"]);
                    cmd.Parameters.AddWithValue("@fecha", null);
                }
                cmd.Parameters.AddWithValue("@idSiniestro", dr["idSiniestro"]);
                cmd.Parameters.AddWithValue("@Observaciones", dr["Observaciones"]);

                cmd.ExecuteNonQuery();

                string messege = "Se ha actualizado Inspeccion";
                string caption = "Listo";
                MessageBox.Show(messege, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "Error Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sqlite.Close();
        }


        //Insert Inspeccion

        public void SetDataInspeccion(Inspecciones ip)
        {
            try
            {
                sqlite.Open();
                cmd = sqlite.CreateCommand();
                cmd.CommandText = "insert into Inspecciones (idInspector,idSiniestro,fechaIP,Observaciones) " +
                                  "values (@idInspector,@idSiniestro,@fechaIP,@Observaciones)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@idInspector", ip.IdInspector);
                cmd.Parameters.AddWithValue("@idSiniestro", ip.IdSiniestro);
                cmd.Parameters.AddWithValue("@fechaIP", ip.FechaIp);
                cmd.Parameters.AddWithValue("@Observaciones", ip.Observaciones);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se agrego Inspeccion");
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "Error Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sqlite.Close();
        }
    }
}
