using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    //Clase utilizada para manejar el patrón de diseño Singleton. Se usa para obtener datos del usuario que utiliza el sistema
    public class Manager
    {
        private static Manager mana; //Instancia única de la clase
        public string rol = "";      //Rol del usuario del sistema
        public string nombre = "";   //Nombre del usuario del sistema
        public string id = "";       //Identificador (nombre de usuario) del usuario del sistema

        //Constructor privado de forma que no se pueden hacer múltiples instancias de la clase
        private Manager()
        {

        }

        /**
         * Devuelve la instancia de la clase, para recuperar los datos del usuario del sistema
         * 
         * @return Instancia única de la clase
         **/
        public static Manager getManager()
        {
            if (mana == null)
            {
                mana = new Manager();
            }
            return mana;
        }

    }
}
