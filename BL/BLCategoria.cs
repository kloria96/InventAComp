using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLCategoria
    {

        public int idCategoria { get; set; }
        public String nombreCategoria { get; set; }

        public BLCategoria()
        {

        }

        public BLCategoria(int idCategoria, String nombreCategoria)
        {
            this.idCategoria = idCategoria;
            this.nombreCategoria = nombreCategoria;
        }
    }
}
