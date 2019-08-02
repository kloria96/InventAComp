using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using DAO;

namespace BL
{
    /// <summary>
    /// Clase intermedia entre la Interfaz Gráfica (UI) y el acceso a base de datos (DAO) para gestionar las cuenta de
    /// usuario del sistema
    /// Los métodos de esta clase hacen referencia a aquellos en DAOCuenta, y tienen la misma funcionalidad
    /// </summary>
    public class ManejadorCuenta
    {
        /// <summary>
        /// Retorna los datos de la cuenta asociada al nombre de usuario y la contraseña
        /// </summary>
        /// <param name="nombre">Nombre de usuario de la cuenta</param>
        /// <param name="contra">Contraseña asociada al nombre de usuario</param>
        /// <returns>Demás datos de la cuenta</returns>
        public BLCuenta buscarCuenta(string nombre, string contra)
        {
            DAOCuenta dao = new DAOCuenta();
            return convert(dao.buscarCuenta(nombre, contra));
        }

        /// <summary>
        /// Verifica si existe una cuenta de usuario bajo el identificador (nombre de usuario) especificado. Retorna los datos
        /// de la cuenta
        /// </summary>
        /// <param name="id">Nombre de usuario</param>
        /// <returns>Datos de la cuenta asociada al nombre de usuario</returns>
        public BLCuenta existeIdentificador(string id)
        {
            DAOCuenta dao = new DAOCuenta();
            return convert(dao.existeId(id));
        }

        /// <summary>
        /// Ingresa una nueva cuenta de usuario al sistema
        /// </summary>
        /// <param name="cuenta">Cuenta a ingresar. Objeto que contiene los datos de la cuenta</param>
        public void insertar(BLCuenta cuenta)
        {
            DAOCuenta dao = new DAOCuenta();
            dao.insertarCuenta(convert(cuenta));
        }

        /// <summary>
        /// Retorna una lista con todas las cuentas existentes en el sistema
        /// </summary>
        /// <returns>Lista de cuentas en el sistema</returns>
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

        /// <summary>
        /// Modifica los datos de una cuenta del sistema
        /// </summary>
        /// <param name="cuenta">Cuenta a modificar y datos de la nueva cuenta</param>
        /// <returns>True en caso de que la cuenta se haya modificado correctamente, false de lo contrario</returns>
        public bool modificarCuenta(BLCuenta cuenta)
        {
            DAOCuenta dao = new DAOCuenta();
            return dao.actualizarCuenta(convert(cuenta));
        }

        /// <summary>
        /// Convierte una cuenta de la capa de Lógica de Negocios (BL) a la capa Objetos de Transferencia (TO). Método usado
        /// localmente
        /// </summary>
        /// <param name="cuenta">Cuenta de Lógica de Negocios a convertir</param>
        /// <returns>Cuenta de Objetos de Transferencia convertida</returns>
        private TOCuenta convert(BLCuenta cuenta)
        {
            return new TOCuenta(cuenta.idUsuario, cuenta.nombreEmpleado, cuenta.contrasenna, cuenta.privilegio, cuenta.estado);
        }

        /// <summary>
        /// Convierte una cuenta de la capa de Objetos de Transferencia (TO) a la capa Lógica de Negocios. Método usado
        /// localmente
        /// </summary>
        /// <param name="cuenta">Cuenta de Objetos de Transferencia a convertir</param>
        /// <returns>Cuenta de Lógica de Negocios convertida</returns>
        private BLCuenta convert(TOCuenta cuenta)
        {
            return new BLCuenta(cuenta.idUsuario,  cuenta.nombreEmpleado, cuenta.contrasenna, cuenta.privilegio, cuenta.estado);
        }
    }
}
