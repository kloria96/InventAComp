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

        public BLCuenta existeIdentificador(string id)
        {
            DAOCuenta dao = new DAOCuenta();
            return convert(dao.existeId(id));
        }

        public void insertar(BLCuenta cuenta)
        {
            DAOCuenta dao = new DAOCuenta();
            dao.insertarCuenta(convert(cuenta));
        }

        public List<BLCuenta> listaCuentas()
        {
            DAOCuenta daoCuenta = new DAOCuenta();
            List<TOCuenta> listTOCuent = daoCuenta.listaCuentas();
            List<BLCuenta> listBLCuent = new List<BLCuenta>();
            foreach (TOCuenta toCuenta in listTOCuent)
            {
                listBLCuent.Add(convert(toCuenta));
            }
            return listBLCuent;
        }

        public bool modificarCuenta(BLCuenta cuenta)
        {
            DAOCuenta dao = new DAOCuenta();
            return dao.actualizarCuenta(convert(cuenta));
        }

        private TOCuenta convert(BLCuenta cuenta)
        {
            return new TOCuenta(cuenta.idUsuario, cuenta.nombreEmpleado, cuenta.contrasenna, cuenta.privilegio, cuenta.estado);
        }

        private BLCuenta convert(TOCuenta cuenta)
        {
            return new BLCuenta(cuenta.idUsuario,  cuenta.nombreEmpleado, cuenta.contrasenna, cuenta.privilegio, cuenta.estado);
        }
    }
}
