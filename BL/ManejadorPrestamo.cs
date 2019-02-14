﻿using System;
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
                lista.Add(new BLPrestamo(toPrest.idPrestamo, toPrest.numeroContrato, toPrest.paciente, toPrest.nombreArticulo, toPrest.numeroPlacaArticulo));
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

        private TOPrestamo convert(BLPrestamo prestamo)
        {
            return new TOPrestamo(prestamo.numeroContrato, prestamo.paciente, prestamo.responsable, prestamo.fechaPrestamo, prestamo.fechaEntrega, prestamo.idArticulo);
        }

    }
}