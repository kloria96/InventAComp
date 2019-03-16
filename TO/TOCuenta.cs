using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO
{
    public class TOCuenta
    {
        public string idUsuario { get; set; }
        public string nombreEmpleado { get;set; }
        public string contrasenna { get; set; }
        public string privilegio { get; set; }
        public Boolean estado { get; set; }

        public TOCuenta()
        {

        }

        public TOCuenta(string idUsuario, string nombreEmpleado, string contrasenna, string privilegio, Boolean estado)
        {
            this.idUsuario = idUsuario;
            this.nombreEmpleado = nombreEmpleado;
            this.contrasenna = contrasenna;
            this.privilegio = privilegio;
            this.estado = estado;
        }
    }
}

