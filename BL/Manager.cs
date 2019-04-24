using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Manager
    {
        private static Manager mana;
        public string rol= "";
        public string nombre = "";
        public string id = "";

        private Manager()
        {

        }

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
