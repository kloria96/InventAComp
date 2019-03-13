using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO
{
    public class TOCuenta
    {
        public string nombreUsuario { get; set; }
        public string contrasenna { get; set; }
        public string privilegio { get; set; }
        public Boolean estado { get; set; }

        public TOCuenta()
        {

        }

        public TOCuenta(string nombreUsuario, string contrasenna, string privilegio, Boolean estado)
        {
            this.nombreUsuario = nombreUsuario;
            this.contrasenna = contrasenna;
            this.privilegio = privilegio;
            this.estado = estado;
        }
    }
}

