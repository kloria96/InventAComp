using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using DAO;

namespace BL
{
    public class ManejadorCuenta
    {
        public BLCuenta buscarCuenta(string nombre, string contra)
        {
            DAOCuenta dao = new DAOCuenta();
            return convert(dao.buscarCuenta(nombre, contra));
        }

        private TOCuenta convert(BLCuenta cuenta)
        {
            return new TOCuenta(cuenta.nombreUsuario, cuenta.contrasenna, cuenta.privilegio, cuenta.estado);
        }

        private BLCuenta convert(TOCuenta cuenta)
        {
            return new BLCuenta(cuenta.nombreUsuario, cuenta.contrasenna, cuenta.privilegio, cuenta.estado);
        }
    }
}
