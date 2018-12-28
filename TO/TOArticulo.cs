﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO
{
    public class TOArticulo
    {
        public String numeroPlaca { get; set;  }
        public String nombArticulo { get; set; }
        public int idArticulo { get; set; }
        public DateTime fechaIngreso { get; set; }
        public String descripcArticulo { get; set; }
        public String estadoArticulo { get; set; }
        public int idCategoria { get; set; }

        public TOArticulo()
        {

        }

        public TOArticulo(String numPlaca, String nombArticulo, int idArticulo, DateTime fechaIngreso, String descripcArticulo, String estadoArticulo, int idCategoria)
        {
            this.numeroPlaca = numPlaca;
            this.nombArticulo = nombArticulo;
            this.idArticulo = idArticulo;
            this.fechaIngreso = fechaIngreso;
            this.descripcArticulo = descripcArticulo;
            this.estadoArticulo = estadoArticulo;
            this.idCategoria = idCategoria;
        }

    }
}