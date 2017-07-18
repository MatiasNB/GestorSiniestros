using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion_de_Siniestros
{
    class Siniestro
    {
        private Asegurado aseg;
        private DataClass data = new DataClass();

        private int id;
        private string poliza;
        private DateTime fechaSiniestro;
        private DateTime fechaDeclaracion;
        private string vehiculo;
        private int año;
        private string dominio;
        private string cobertura;

        //private Taller taller;

        public int Id { get; set; }
        public string Poliza { get; set; }
        public string FechaSiniestro { get; set; }
        public string FechaDeclaracion { get; set; }
        public string Vehiculo { get; set; }
        public int Año { get; set; }
        public string Dominio{ get; set; }
        public string Cobertura{ get; set; }

        public Siniestro(int id)
        {

        }
        
        public static void FindSiniestro(Siniestro stro)
        {

        }
    }
}
