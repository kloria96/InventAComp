using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using TO;
using System.Data;

namespace BL
{
    
    /// <summary>
    /// Clase intermedia entre la Interfaz Gráfica (UI) y el acceso a base de datos (DAO) para gestionar los préstamos del sistema
    /// Los métodos de esta clase hacen referencia a aquellos en DAOPrestamo, y tienen la misma funcionalidad
    /// </summary>
    public class ManejadorPrestamo
    {
        private DAOPrestamo daoPrestamo = new DAOPrestamo();




        public int ultimoPrestamoCodigo()
        {
            return new DAOPrestamo().ultimoPrestamoCodigo();
        }


        /// <summary>
        /// Ingresa un nuevo préstamo en la base de datos
        /// </summary>
        /// <param name="nuevoPrest">Préstamo a ingresar. Objeto Préstamo que contiene los datos del préstamo a ingresar</param>
        /// <returns>True en caso de que el préstamo se haya ingresado correctamente, false de la contrario</returns>
        public bool agregarPrestamo(BLPrestamo nuevoPrest)
        {
            return daoPrestamo.agregarPrestamo(convert(nuevoPrest));
        }

        /// <summary>
        /// Retorna una lista con todos los préstamos asociados al artículo especificado
        /// </summary>
        /// <param name="idArticulo">Identificador numérico del artículo</param>
        /// <returns>Lista de préstamos asociados al artículo</returns>
        public List<BLPrestamo> obtenerPrestamosArticulo(int idArticulo)
        {
            List<BLPrestamo> lista = new List<BLPrestamo>();
            foreach (TOPrestamo toPrestamo in daoPrestamo.obtenerPrestamosArticulo(idArticulo))
            {
                lista.Add(new BLPrestamo(toPrestamo.numeroContrato, toPrestamo.paciente, toPrestamo.responsable, toPrestamo.fechaPrestamo, toPrestamo.fechaEntrega, toPrestamo.idArticulo, toPrestamo.telefono));
            }
            return lista;
        }

        /// <summary>
        /// Elimina un préstamo de la base de datos
        /// </summary>
        /// <param name="idPrestamo">Identificador del préstamo a eliminar</param>
        /// <returns>True en caso de que el artículo se haya eliminado correctamente, false de la contrario</returns>
        public bool eliminarPrestamo(int idPrestamo)
        {
            return daoPrestamo.eliminarPrestamo(idPrestamo);
        }

        /// <summary>
        /// Retorna una lista con datos del préstamo, y su artículo correspondiente, que actualmente se encuentren bajo préstamo
        /// </summary>
        /// <returns>Lista de préstamos actualmente en condición de préstamo</returns>
        public List<BLPrestamo> obtenerArticulosPrestamo()
        {
            List<BLPrestamo> lista = new List<BLPrestamo>();
            foreach (TOPrestamo toPrest in daoPrestamo.obtenerArticulosPrestamo())
            {
                lista.Add(new BLPrestamo(toPrest.idPrestamo, toPrest.numeroContrato, toPrest.paciente, toPrest.responsable, toPrest.fechaPrestamo, toPrest.fechaEntrega, toPrest.numeroPlacaArticulo, toPrest.nombreArticulo, toPrest.telefono));
            }
            return lista;
        }

        /// <summary>
        /// Retorna una lista con los artículos que actualmente se encuentren disponibles para prestar (que no estén
        /// bajo préstamo)
        /// </summary>
        /// <returns>Lista con los artículos disponibles para prestar</returns>
        public List<BLArticulo> consultarArticulosDisponibles()
        {
            List<BLArticulo> lista = new List<BLArticulo>();
            foreach (TOArticulo toArt in daoPrestamo.consultarArticulosDisponibles())
            {
                lista.Add(new BLArticulo(toArt.idArticulo, toArt.numeroPlaca, toArt.nombArticulo, toArt.fechaIngreso, toArt.descripcArticulo, toArt.estadoArticulo, toArt.ubicacionArticulo, toArt.nombreCategoria));
            }
            return lista;
        }

        /// <summary>
        /// Retorna los datos del préstamo según su identificador
        /// </summary>
        /// <param name="idPrestamo">Identificador numérico del préstamo</param>
        /// <returns>Demás datos del préstamo</returns>
        public BLPrestamo obtenerPrestamo(int idPrestamo)
        {
            TOPrestamo toPrest = daoPrestamo.obtenerPrestamo(idPrestamo);
            BLPrestamo prest = new BLPrestamo();
            prest.numeroContrato = toPrest.numeroContrato;
            prest.paciente = toPrest.paciente;
            prest.responsable = toPrest.responsable;
            prest.fechaPrestamo = toPrest.fechaPrestamo;
            prest.fechaEntrega = toPrest.fechaEntrega;
            prest.idArticulo = toPrest.idArticulo;
            prest.telefono = toPrest.telefono;
            return prest;
        }

        /// <summary>
        /// Desactiva el préstamo de la base de datos (no lo elimina). Además, establece el estado de 'prestado' del
        /// artículo como 0
        /// </summary>
        /// <param name="idPrestamo">Identificador numérico del préstamo</param>
        /// <returns>True si el préstamo fue desactivado correctamente, false de lo contrario</returns>
        public bool terminarPrestamo(int idPrestamo)
        {
            return daoPrestamo.terminarPrestamo(idPrestamo);
        }

        /// <summary>
        /// Retorna el identificador numérico del artículo asociado al préstamo especificado. No necesariamente el artículo
        /// debe encontrarse en condición de préstamo
        /// </summary>
        /// <param name="idPrestamo">Identificador numérico del préstamo</param>
        /// <returns>Identificador del artículo</returns>
        public Int32 articuloEnPrestamo(int idPrestamo)
        {
            return daoPrestamo.articuloEnPrestamo(idPrestamo);
        }

        /// <summary>
        /// Retorna una lista con el histórico de préstamos asociados con el artículo especificado
        /// </summary>
        /// <param name="idArticulo">Identificador numérico del artículo</param>
        /// <returns>Lista con los préstamos asociados al artículo</returns>
        public List<BLPrestamo> prestamosArticulo(int idArticulo)
        {
            DAOPrestamo daoPrest = new DAOPrestamo();
            List<BLPrestamo> listaBL = new List<BLPrestamo>();
            foreach (TOPrestamo toPrest in daoPrest.prestamosArticulo(idArticulo))
            {
                BLPrestamo prest = new BLPrestamo();
                prest.idPrestamo = toPrest.idPrestamo;
                prest.numeroContrato = toPrest.numeroContrato;
                prest.paciente = toPrest.paciente;
                prest.responsable = toPrest.responsable;
                prest.fechaPrestamo = toPrest.fechaPrestamo;
                prest.fechaEntrega = toPrest.fechaEntrega;
                listaBL.Add(prest);
            }
            return listaBL;
        }

        /// <summary>
        /// Indica si existe un préstamo en la base de datos bajo el número de contrato especificado
        /// </summary>
        /// <param name="contrato">Número de contrato del préstamo</param>
        /// <returns>True si existe el préstamo, false de lo contrario</returns>
        public bool existePrestamo(string contrato)
        {
            DAOPrestamo daoPrest = new DAOPrestamo();
            return daoPrest.existePrestamo(contrato);
        }

        /// <summary>
        /// Retorna los datos del préstamo según su número de contrato
        /// </summary>
        /// <param name="contrato">Número de contrato del préstamo</param>
        /// <returns>Demás datos del préstamo</returns>
        public BLPrestamo obtenerPrestamoContrato(string contrato)
        {
            TOPrestamo toPrest = daoPrestamo.obtenerPrestamoContrato(contrato);
            BLPrestamo prestamo = new BLPrestamo();
            prestamo.paciente = toPrest.paciente;
            prestamo.responsable = toPrest.responsable;
            prestamo.fechaPrestamo = toPrest.fechaPrestamo;
            prestamo.fechaEntrega = toPrest.fechaEntrega;
            prestamo.estado = toPrest.estado;
            return prestamo;
        }

        /// <summary>
        /// Convierte un préstamo de la capa de Lógica de Negocios (BL) a la capa Objetos de Transferencia (TO). Método usado
        /// localmente
        /// </summary>
        /// <param name="prestamo">Préstamo de Lógica de Negocios a convertir</param>
        /// <returns>Préstamo de Objetos de Transferencia convertido</returns>
        private TOPrestamo convert(BLPrestamo prestamo)
        {
            return new TOPrestamo(prestamo.numeroContrato, prestamo.paciente, prestamo.responsable, prestamo.fechaPrestamo, prestamo.fechaEntrega, prestamo.idArticulo, prestamo.telefono);
        }
    }
}
