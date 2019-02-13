using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO
{
    public class TOContribucion
    {
        public int idContribucion { get; set; }
        public string numeroRecibo { get; set; }
        public string cuota { get; set; }
        public DateTime fecha { get; set; }
        public int idPrestamo { get; set; }

        public TOContribucion() { }

        public TOContribucion(int idContribucion, string numeroRecibo, string cuota, DateTime fecha, int idPrestamo)
        {
            this.idContribucion = idContribucion;
            this.numeroRecibo = numeroRecibo;
            this.cuota = cuota;
            this.fecha = fecha;
            this.idPrestamo = idPrestamo;
        }

        public TOContribucion(string numeroRecibo, string cuota, DateTime fecha, int idPrestamo)
        {
            this.numeroRecibo = numeroRecibo;
            this.cuota = cuota;
            this.fecha = fecha;
            this.idPrestamo = idPrestamo;
        }

    }
}
