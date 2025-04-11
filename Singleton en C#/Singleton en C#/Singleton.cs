using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton _instance;
        public string mensaje;

        // Constructor privado
        private Singleton()
        {
            mensaje = "Hola mundo";
        }

        // Propiedad pública para acceder a la instancia
        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }
    }
}
