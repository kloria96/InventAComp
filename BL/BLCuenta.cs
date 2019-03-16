using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLCuenta
    {
        public string idUsuario { get; set; }
        public string nombreEmpleado { get; set; }
        public string contrasenna { get; set; }
        public string privilegio { get; set; }
        public Boolean estado { get; set; }

        public BLCuenta()
        {

        }

        public BLCuenta(string idUsuario, string nombreEmpleado, string contrasenna, string privilegio, Boolean estado)
        {
            this.idUsuario = idUsuario;
            this.nombreEmpleado = nombreEmpleado;
            this.contrasenna = contrasenna;
            this.privilegio = privilegio;
            this.estado = estado;
        }
    }
}
