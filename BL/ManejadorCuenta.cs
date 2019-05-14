using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using DAO;

namespace BL
{
    //Clase intermedia entre la Interfaz Gráfica (UI) y el acceso a base de datos (DAO) para gestionar las cuenta de
    //usuario del sistema
    //Los métodos de esta clase hacen referencia a aquellos en DAOCuenta, y tienen la misma funcionalidad
    public class ManejadorCuenta
    {

        /**
         * Retorna los datos de la cuenta asociada al nombre de usuario y la contraseña
         * 
         * @param nombre Nombre de usuario de la cuenta
         * @param contra Contraseña asociada al nombre de usuario
         * @return Demás datos de la cuenta
         **/
        public BLCuenta buscarCuenta(string nombre, string contra)
        {
            DAOCuenta dao = new DAOCuenta();
            return convert(dao.buscarCuenta(nombre, contra));
        }

        /**
         * Verifica si existe una cuenta de usuario bajo el identificador (nombre de usuario) especificado. Retorna los datos
         * de la cuenta
         * 
         * @param id Nombre de usuario
         * @return Datos de la cuenta asociada al nombre de usuario
         **/
        public BLCuenta existeIdentificador(string id)
        {
            DAOCuenta dao = new DAOCuenta();
            return convert(dao.existeId(id));
        }

        /**
         * Ingresa una nueva cuenta de usuario al sistema
         * 
         * @param cuenta Cuenta a ingresar. Objeto que contiene los datos de la cuenta
         **/
        public void insertar(BLCuenta cuenta)
        {
            DAOCuenta dao = new DAOCuenta();
            dao.insertarCuenta(convert(cuenta));
        }

        /**
         * Retorna una lista con todas las cuentas existentes en el sistema
         * 
         * @return Lista de cuentas en el sistema
         **/
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

        /**
         * Modifica los datos de una cuenta del sistema
         * 
         * @param cuenta Cuenta a modificar y datos de la nueva cuenta
         * @return True en caso de que la cuenta se haya modificado correctamente, false de lo contrario
         **/
        public bool modificarCuenta(BLCuenta cuenta)
        {
            DAOCuenta dao = new DAOCuenta();
            return dao.actualizarCuenta(convert(cuenta));
        }


        /**
         * Convierte una cuenta de la capa de Lógica de Negocios (BL) a la capa Objetos de Transferencia (TO). Método usado
         * localmente
         * 
         * @param cuenta Cuenta de Lógica de Negocios a convertir
         * @return Cuenta de Objetos de Transferencia convertida
         **/
        private TOCuenta convert(BLCuenta cuenta)
        {
            return new TOCuenta(cuenta.idUsuario, cuenta.nombreEmpleado, cuenta.contrasenna, cuenta.privilegio, cuenta.estado);
        }

        /**
         * Convierte una cuenta de la capa de Objetos de Transferencia (TO) a la capa Lógica de Negocios. Método usado
         * localmente
         * 
         * @param cuenta Cuenta de Objetos de Transferencia a convertir
         * @return Cuenta de Lógica de Negocios convertida
         **/
        private BLCuenta convert(TOCuenta cuenta)
        {
            return new BLCuenta(cuenta.idUsuario,  cuenta.nombreEmpleado, cuenta.contrasenna, cuenta.privilegio, cuenta.estado);
        }

    }
}
