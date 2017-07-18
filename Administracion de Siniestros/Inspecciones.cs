using System;
using System.Windows.Forms;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Administracion_de_Siniestros
{
    class Inspecciones
    {
        private static DataClass data = new DataClass();
        private DataTable dt;

        public int Id { get; set; }
        public int IdInspector { get; set; }
        public int IdSiniestro { get; set; }
        public DateTime FechaIp { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaActa { get; set; }
        public Boolean finalizar { set; get; }

        public DataTable InspeccionesActivas()
        {
            dt = data.getData("select ip.id,i.Nombre,ip.idSiniestro,ip.fechaIP,ip.fechaActa,julianday(date('now','localtime'))-julianday(ip.fechaIP) as demora, ip.finalizar,ip.Observaciones " +
                "from Inspecciones ip, Inspectores i " +
                "where ip.idInspector=i.id and ip.fechaActa is null");
            return dt;
        }

        public DataTable InspeccionesTodas()
        {
            dt = data.getData("select ip.id,i.Nombre,ip.idSiniestro,ip.fechaIP,ip.fechaActa," +
                "(case " +
                "when ip.fechaActa is null then (julianday(date('now','localtime'))-julianday(ip.fechaIP)) " +
                "when ip.fechaActa is not null then (julianday(ip.fechaActa)-julianday(ip.fechaIP))end) as demora, ip.finalizar,ip.Observaciones " +
                "from Inspecciones ip, Inspectores i " +
                "where ip.idInspector=i.id");
            return dt;
        }

        public DataTable InspeccionesInspector(int id)
        {
            dt = data.getData("select ip.id,i.Nombre,ip.idSiniestro,ip.fechaIP,ip.fechaActa," +
                "(case " +
                "when ip.fechaActa is null then (julianday(date('now','localtime'))-julianday(ip.fechaIP)) " +
                "when ip.fechaActa is not null then (julianday(ip.fechaActa)-julianday(ip.fechaIP))end) as demora, ip.finalizar,ip.Observaciones " +
                "from Inspecciones ip, Inspectores i " +
                "where ip.idInspector=i.id and i.id="+id);
            return dt;
        }
        public void SetModificado(DataRow dr)
        {
            data.SetRowInspecciones(dr);
        }
    }
}
