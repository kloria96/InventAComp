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
    public class ManejadorPrestamo
    {
        private DAOPrestamo daoPrestamo = new DAOPrestamo();

        public bool agregarPrestamo(BLPrestamo nuevoPrest)
        {
            return daoPrestamo.agregarPrestamo(convert(nuevoPrest));
        }

        public List<BLPrestamo> obtenerPrestamosArticulo(int idArticulo)
        {
            List<BLPrestamo> lista = new List<BLPrestamo>();
            foreach (TOPrestamo toPrestamo in daoPrestamo.obtenerPrestamosArticulo(idArticulo))
            {
                lista.Add(new BLPrestamo(toPrestamo.numeroContrato, toPrestamo.paciente, toPrestamo.responsable, toPrestamo.fechaPrestamo, toPrestamo.fechaEntrega, toPrestamo.idArticulo));
            }
            return lista;
        }

        public bool eliminarPrestamo(int idPrestamo)
        {
            return daoPrestamo.eliminarPrestamo(idPrestamo);
        }

        public List<BLPrestamo> obtenerArticulosPrestamo()
        {
            List<BLPrestamo> lista = new List<BLPrestamo>();
            foreach (TOPrestamo toPrest in daoPrestamo.obtenerArticulosPrestamo())
            {
                lista.Add(new BLPrestamo(toPrest.idPrestamo, toPrest.numeroContrato, toPrest.paciente, toPrest.responsable, toPrest.fechaPrestamo, toPrest.fechaEntrega, toPrest.numeroPlacaArticulo, toPrest.nombreArticulo));
            }
            return lista;
        }

        public List<BLArticulo> consultarArticulosDisponibles()
        {
            List<BLArticulo> lista = new List<BLArticulo>();
            foreach (TOArticulo toArt in daoPrestamo.consultarArticulosDisponibles())
            {
                lista.Add(new BLArticulo(toArt.idArticulo, toArt.numeroPlaca, toArt.nombArticulo, toArt.fechaIngreso, toArt.descripcArticulo, toArt.estadoArticulo, toArt.ubicacionArticulo, toArt.nombreCategoria));
            }
            return lista;
        }

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
            return prest;
        }

        //Desactiva el préstamo (estado = 0), no lo elimina de la BD. Ademas, establece el estado del artículo como 0
        public bool terminarPrestamo(int idPrestamo)
        {
            return daoPrestamo.terminarPrestamo(idPrestamo);
        }

        //Retorna el id del artículo en préstamo. Para ver los datos del artículo desde VerPrestamo
        public Int32 articuloEnPrestamo(int idPrestamo)
        {
            return daoPrestamo.articuloEnPrestamo(idPrestamo);
        }

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

        private TOPrestamo convert(BLPrestamo prestamo)
        {
            return new TOPrestamo(prestamo.numeroContrato, prestamo.paciente, prestamo.responsable, prestamo.fechaPrestamo, prestamo.fechaEntrega, prestamo.idArticulo);
        }

    }
}
