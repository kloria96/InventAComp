using System;
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
        public String ubicacionArticulo { get; set; }
        public Boolean propiedad_JPS { get; set; }
        public Boolean prestado { get; set; }
        public int idCategoria { get; set; }
        public String nombreCategoria { get; set; }

        public TOArticulo()
        {

        }

        public TOArticulo(int idArticulo, String numPlaca, String nombArticulo, DateTime fechaIngreso, String descripcArticulo, String estadoArticulo, String ubicacionArticulo, int idCategoria)
        {
            this.idArticulo = idArticulo;
            this.numeroPlaca = numPlaca;
            this.nombArticulo = nombArticulo;
            this.fechaIngreso = fechaIngreso;
            this.descripcArticulo = descripcArticulo;
            this.estadoArticulo = estadoArticulo;
            this.ubicacionArticulo = ubicacionArticulo;
            this.idCategoria = idCategoria;
        }

        public TOArticulo(int idArticulo, String numPlaca, String nombArticulo, DateTime fechaIngreso, String descripcArticulo, String estadoArticulo, String ubicacionArticulo, String nombreCategoria)
        {
            this.numeroPlaca = numPlaca;
            this.nombArticulo = nombArticulo;
            this.idArticulo = idArticulo;
            this.fechaIngreso = fechaIngreso;
            this.descripcArticulo = descripcArticulo;
            this.estadoArticulo = estadoArticulo;
            this.ubicacionArticulo = ubicacionArticulo;
            this.nombreCategoria = nombreCategoria;
        }

        public TOArticulo(int idArticulo, String numPlaca, String nombArticulo, DateTime fechaIngreso, String descripcArticulo, String estadoArticulo, String ubicacionArticulo, Boolean propiedad_JPS, int idCategoria)
        {
            this.idArticulo = idArticulo;
            this.numeroPlaca = numPlaca;
            this.nombArticulo = nombArticulo;
            this.fechaIngreso = fechaIngreso;
            this.descripcArticulo = descripcArticulo;
            this.estadoArticulo = estadoArticulo;
            this.ubicacionArticulo = ubicacionArticulo;
            this.propiedad_JPS = propiedad_JPS;
            this.idCategoria = idCategoria;
        }

        public TOArticulo(int idArticulo, String numPlaca, String nombArticulo, DateTime fechaIngreso, String descripcArticulo, String estadoArticulo, String ubicacionArticulo, Boolean propiedad_JPS, String nombreCategoria)
        {
            this.numeroPlaca = numPlaca;
            this.nombArticulo = nombArticulo;
            this.idArticulo = idArticulo;
            this.fechaIngreso = fechaIngreso;
            this.descripcArticulo = descripcArticulo;
            this.estadoArticulo = estadoArticulo;
            this.ubicacionArticulo = ubicacionArticulo;
            this.propiedad_JPS = propiedad_JPS;
            this.nombreCategoria = nombreCategoria;
        }

        //Luego de agregar el atributo 'prestado'
        public TOArticulo(int idArticulo, String numPlaca, String nombArticulo, DateTime fechaIngreso, String descripcArticulo, String estadoArticulo, String ubicacionArticulo, Boolean propiedad_JPS, Boolean prestado, String nombreCategoria)
        {
            this.numeroPlaca = numPlaca;
            this.nombArticulo = nombArticulo;
            this.idArticulo = idArticulo;
            this.fechaIngreso = fechaIngreso;
            this.descripcArticulo = descripcArticulo;
            this.estadoArticulo = estadoArticulo;
            this.ubicacionArticulo = ubicacionArticulo;
            this.propiedad_JPS = propiedad_JPS;
            this.prestado = prestado;
            this.nombreCategoria = nombreCategoria;
        }

    }
}
