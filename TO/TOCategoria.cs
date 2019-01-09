using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO
{
   public class TOCategoria
    {
        public int idCategoria { get; set; }
        public String nombreCategoria { get; set; }

        public TOCategoria()
        {

        }

        public TOCategoria(int idCategoria, String nombreCategoria)
        {
            this.idCategoria = idCategoria;
            this.nombreCategoria = nombreCategoria;
        }
    }
}
